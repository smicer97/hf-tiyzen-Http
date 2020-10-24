using RobotBrain.State;
using System;
using System.Collections.Generic;
using System.Text;

//this.Brain.TargetLocation = this.Brain.Robot.Environment.GetObjectsCoordinatesOnTheMap()["Counter"];
namespace RobotBrain
{
    public class AtTheTableState : State.StateBase
    {
        public override void Tick()
        {
            base.Tick();
            PerformStateTask();
        }
        public AtTheTableState(IBrain brain) : base(brain)
        {
            this.Enter();
            NextState = new FollowingLineState(5.0, brain);

        }
        private void PerformStateTask()
        {
            //TODO: set target location in Brain

            if (Brain.TrySetTargetLocation("Counter") && Brain.CheckGuestTookFood()) 
            {
                this.Exit();
            }
            else
            {
                // Stay in the task and log event
                //TODO: Log that we are at the table, unloading
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