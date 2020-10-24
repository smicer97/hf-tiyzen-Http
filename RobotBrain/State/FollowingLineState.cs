using Robot;

namespace RobotBrain.State
{
    public class FollowingLineState : StateBase
    {
        // This state requires a LineAndWallDetectorRobot.

        private readonly double targetSpeed;

        public FollowingLineState(double targetSpeed, IBrain brain) : base (brain)
        {
            this.Enter();
            this.targetSpeed = targetSpeed;
            NextState = new ReadyToServeState(Brain);
        }

        public override void Tick()
        {
            base.Tick();
            PerformStateTask();
            //this.Brain.Robot.Environment.GetObjectsCoordinatesOnTheMap().TryGetValue("A_table", out Point);
            if (this.Brain.GetRobotSpeed() < targetSpeed)
                this.Brain.SetRobotAcceleration(1.0);
            else if (this.Brain.GetRobotSpeed() > targetSpeed)
            {
                this.Brain.SetRobotAcceleration(0.0);
            }
            else {
                this.Brain.SetRobotAcceleration(-0.5);
            }

            int[] scan = Brain.PerformLineSensorScan();
            int middleIndex = (scan.Length / 2) + 1;
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < scan.Length; i++)
            {
                if (scan[i] > 0)
                {
                    if (i < middleIndex)
                        sumLeft++;
                    else if (i > middleIndex)
                        sumRight++;
                }
            }
            if (sumLeft > sumRight)
                Brain.SetRobotTurn(-10.0);
            else if (sumLeft < sumRight)
                Brain.SetRobotTurn(10.0);
            else if (sumLeft+sumRight > 0)
                Brain.SetRobotTurn(0.0);
            // If line is entirely lost, keep turning.
        }
        private void PerformStateTask()
        {

            if (this.Brain.GetTargetLocation() == this.Brain.GetOrderLocation()) //Going to a table
            {
                
            }
            else //Going to the counter
            {
                //Stay in this state, try to perform the task
                // TO DO: Log that the Self Diagnostic Failed
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