namespace RobotBrain.State
{
    public class StateBase : IState
    {
        protected StateBase NextState;
        private IBrain brain;

        protected IBrain Brain { get => brain; set => brain = value; }

        public StateBase(IBrain brain) {
            Brain = brain;
        }
        public virtual void Tick() { }

        public virtual void OnLineAppears() { }
        public virtual void OnLineDisappears() { }

        protected virtual void Exit() { }
        protected virtual void Enter() { }
    }
}
