using Environment;
using Stand;

namespace Robot
{
    /// <summary>
    /// Generic base class for robots: position, orientation, speed etc., time OnTick,
    /// reference to IEnvironment.
    /// </summary>
    public class RobotBase : IRobot
    {
        private LocOri locationOrientation;
        private OrderType payload;
        public double PayloadWeight { get; set; }
        public LineSensor LineSensor { get; set; }
        public OrderType Payload
        {
            get => payload;
            set => payload = value;
        }
        public LocOri LocationOrientation
        {
            get => locationOrientation;
            set => locationOrientation = value;
        }
        public Point Location
        {
            get => locationOrientation.Location;
            set => locationOrientation.Location = value;
        }
        public double Orientation
        {
            get => locationOrientation.Orientation;
            set => locationOrientation.Orientation = value;
        }

        private double speed;
        public double Speed
        {
            get => speed;
            set => speed = value;
        }

        public double Turn { get; set; }

        public double Acceleration { get; set; }

        public IEnvironment Environment { get; set; }

        public RobotBase(IEnvironment env)
        {
            Environment = env;
            env.OnTick += Environment_OnTick;
        }

        private void Environment_OnTick()
        {
            CheckAndMoveRobot();
            // Note: OnTick will be the last event to fire. After all sensor related events
            //  have been fired as necessary.
            CheckSensorValuesAndFireEvents();
            OnTick?.Invoke();
        }

        /// <summary>
        /// If the robot can move with given speed, updates location.
        /// In case of collision with wall, does not update location.
        /// </summary>
        /// <returns>True if the move could be performed (without collision).</returns>
        public virtual bool CheckAndMoveRobot()
        {
            Orientation += Turn;
            if (Orientation > 360.0)
                Orientation -= 360.0;
            if (Orientation < 0.0)
                Orientation += 360.0;

            Location += Helpers.GetVector(Orientation, speed);
            Speed += Acceleration;
            if (Speed < 0)
                Speed = 0;
            return true;
        }

        /// <summary>
        /// Override this to handle robot sensors. Robots OnTick() will be fired after these.
        /// </summary>
        protected virtual void CheckSensorValuesAndFireEvents()
        {
        }

        /// <summary>
        /// Override in the current robot to measure weight of the payload plate
        /// </summary>
        protected virtual double MeasureWeightOfPayloadPlate()
        {
            return 0.0;
        }

        public event OnTickDelegate OnTick;
    }
}

