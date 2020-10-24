﻿using System;
using System.Collections.Generic;
using System.Text;
using Environment;
using Robot;
using RobotBrain;
using RobotBrain.Command;
using RobotBrain.State;
using Xunit;

namespace RobotBrainTests
{
    public class WallsAndLinesDemoBrainTests
    {
        private readonly Map map;
        private readonly DefaultEnvironment environment;
        private readonly LineAndWallDetectorRobot robot;
        private readonly WallsAndLinesDemoBrain brain;

        public WallsAndLinesDemoBrainTests()
        {
            map = TestMap1Factory.Create();
            environment = new DefaultEnvironment(map);
            robot = new LineAndWallDetectorRobot(environment, 50);
            brain = new WallsAndLinesDemoBrain(robot);
        }

        [Fact]
        public void InitialState()
        {
            Assert.True(brain.CurrentState is ReadyToServeState);
        }

        [Fact]
        public void FollowingLineWithCorner()
        {
            // put robot over the line
            TestMap1Factory.PutRobotInA(robot);
            brain.AddCommand(new GenericSingleStateCommand(new FollowingLineState(1.0)));
            Assert.True(brain.CurrentState is FollowingLineState);

            Assert.Equal(0.0, robot.Acceleration, 2);
            environment.Tick();
            // State should accelerate
            Assert.True(robot.Acceleration > 0.1);

            for (int t = 0; t < 100; t++)
                environment.Tick();

            Assert.True(robot.Location.X > 60); // Turned and moved right (along line).
        }

        [Fact]
        public void FollowingWallOnLeftWithCorner()
        {
            // put robot over the line
            TestMap1Factory.PutRobotInB(robot);
            brain.AddCommand(new GenericSingleStateCommand(new FollowingWallOnLeftState(5,10)));

            for (int t = 0; t < 30; t++)
                environment.Tick();

            Assert.True(robot.Location.Y > 170); // Turned along wall and moved south.
        }

        [Fact]
        public void FollowingWallOnRightWithCorner()
        {
            // put robot over the line
            TestMap1Factory.PutRobotInB(robot);
            brain.AddCommand(new GenericSingleStateCommand(new FollowingWallOnRightState(5,10)));

            for (int t = 0; t < 30; t++)
                environment.Tick();

            Assert.True(robot.Location.Y < 130); // Turned along wall and moved north.
        }
    }
}
