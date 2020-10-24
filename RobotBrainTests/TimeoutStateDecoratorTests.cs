﻿using Environment;
using Robot;
using RobotBrain;
using RobotBrain.Command;
using RobotBrain.State;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RobotBrainTests
{
    public class TimeoutStateDecoratorTests
    {
        [Fact]
        public void TimeoutChangesStateToFollower()
        {
            var brain = new BrainBase(new RobotBase(new DefaultEnvironment(new Map(10,10))));
            var decoratedState = new ReadyToServeState();
            var followerState = new ReadyToServeState();
            var state = new TimeoutStateDecorator(decoratedState, 3, followerState);
            brain.CurrentState = state;
            Assert.Equal(state, brain.CurrentState);
            state.Tick();
            Assert.Equal(state, brain.CurrentState);
            state.Tick();
            Assert.Equal(state, brain.CurrentState);
            state.Tick();
            Assert.Equal(followerState, brain.CurrentState);
            state.Tick();
        }
    }
}
