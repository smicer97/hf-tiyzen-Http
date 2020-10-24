using RobotBrain.LogEntry;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBrain.State
{
    public class ReadyToServeState : StateBase
    {
        public override void Tick()
        {
            base.Tick();
            PerformStateTask();
        }
        public ReadyToServeState(IBrain brain) : base(brain)
        {
            this.Enter();
            NextState = new FollowingLineState(5.0, brain);
        }
        private void PerformStateTask()
        {
            if (this.Brain.TryToLoadRobotPayloadWithOrder())
            {
                this.Exit();
            }
            else
            {
                /*Stay in this state, try to perform the task*/
                //TODO: Log that we are trying to load payload with order
            }
        }
        protected override void Exit()
        {
            base.Exit();
            Brain.SetCurrentState(NextState);
        }
        protected override void Enter()
        {
            
        }
    }
}
