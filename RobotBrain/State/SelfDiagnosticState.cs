using RobotBrain.LogEntry;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBrain.State
{
    public class SelfDiagnosticState : StateBase
    {

        public override void Tick()
        {
            base.Tick();
            PerformStateTask();
        }
        public SelfDiagnosticState(IBrain brain) : base(brain) 
        {
            this.Enter();
            NextState = new ReadyToServeState(Brain);
        }
        private void PerformStateTask()
        {

            if (this.Brain.DiagnoseRobot())
            {
                this.Exit();
            }
            else
            {
                /*Stay in this state, try to perform the task*/
                // TO DO: Log that the Self Diagnostic Failed
            }
        }
        protected override void Exit()
        {
            base.Exit();
            Brain.SetCurrentState(NextState) ;
        }
        protected override void Enter()
        {
        }
    }
}