namespace RobotBrain.State
{
    public class AfterIdleStateDecorator : IState
    {
        private readonly IState decorated;
        private readonly IState follower;

        public AfterIdleStateDecorator(IState decorated, IState follower)
        {
            this.decorated = decorated;
            this.follower = follower;
        }

        // Note: according to Decorator design pattern, we forward everything to the
        //  decorated IState. The added functionality is only in Tick().
        //public IBrain Brain { get => decorated.Brain; set => decorated.Brain = value; }

        public void Tick()
        {
            decorated.Tick();
            // If the decorated state transitioned into idle, we override this
            //  with the follower state. With this step, the decoration is complete.
            //if (Brain.CurrentState is ReadyToServeState)
                //Brain.CurrentState = follower;
        }

        //public void Enter() => decorated.Enter();
        //public void Exit() => decorated.Exit();
        public void OnLineAppears() => decorated.OnLineAppears();
        public void OnLineDisappears() => decorated.OnLineDisappears();
    }
}
