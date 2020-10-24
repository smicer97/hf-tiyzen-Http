using System;
using System.Runtime.CompilerServices;
using Robot;
using RobotBrain.LogEntry;
using RobotBrain.State;
using Stand;

namespace RobotBrain
{
    public class WallsAndLinesDemoBrain : BrainBase
    {
        public WallsAndLinesDemoBrain(LineAndWallDetectorRobot robot,StandBase stand) : base(robot,stand)
        {
            CurrentState = new SelfDiagnosticState(this); 
            robot.OnLineAppears += Robot_OnLineAppears;
            robot.OnLineDisappears += Robot_OnLineDisappears;
        }
        protected override void Robot_OnTick()
        {
            if (true == DetermineNextState()){

            }
            else { 
            }
        }

        private bool DetermineNextState()
        {
            throw new System.NotImplementedException();
        }

        #region Event forwarding to CurrentState
        private void Robot_OnLineDisappears()
        {
            LogCall();
            CurrentState.OnLineDisappears();
        }

        private void Robot_OnLineAppears()
        {
            LogCall();
            CurrentState.OnLineAppears();
        }
        #endregion

        public void LogCall([CallerMemberName] string caller = null)
        {
            Log(new RobotEventLogEntry(caller));
        }
    }
}
