using System;
/*
namespace RobotBrain.State
{
    public class TurnState : StateBase
    {
        readonly double targetDirection;
        readonly double angularVelocity;

        public TurnState(double targetDirection, double angularVelocity)
        {
            this.targetDirection = targetDirection;
            this.angularVelocity = angularVelocity;
        }

        protected override void Enter()
        {
            Brain.Brain.Turn = angularVelocity;
        }

        public override void Tick()
        {
            if ((angularVelocity > 0 && Brain.Brain.Orientation >= targetDirection)
                || (angularVelocity < 0 && Brain.Brain.Orientation <= targetDirection))
            {
                throw new NotImplementedException();
            }
        }
    }
}
*/