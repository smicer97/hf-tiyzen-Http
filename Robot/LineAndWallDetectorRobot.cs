using Environment;
using System.Linq;

namespace Robot
{
    /// <summary>
    /// Class of the actual robot with sensors for wall and line following.
    /// On the map, 0 is empty, 1-9 is line, 10+ (MinMapValueForObstacle) is wall.
    /// Events indicate sensor status changes, they are not fired continuously, only once.
    /// </summary>
    public class LineAndWallDetectorRobot : RobotBase
    {
        //public LineSensor LineSensor { get; set; }

        private readonly int minMapValueForObstacle;

        //public int WallSensorMaxDistance { get; }

        public LineAndWallDetectorRobot(IEnvironment env, int wallSensorMaxDistance=100,
            int minMapValueForObstacle=10) : base(env)
        {
            //this.WallSensorMaxDistance = wallSensorMaxDistance;
            this.minMapValueForObstacle = minMapValueForObstacle;
            LineSensor = new LineSensor(this);
        }

        public override bool CheckAndMoveRobot()
        {
            Point newLocation = Location + Helpers.GetVector(Orientation, Speed);
            if (this.Environment.GetMapValueAtLocation(newLocation) < minMapValueForObstacle)
            {
                return base.CheckAndMoveRobot();
            }
            else
            {
                Speed = 0.0;
                return false;
            }
        }

        protected override void CheckSensorValuesAndFireEvents()
        {
            base.CheckSensorValuesAndFireEvents();
            PollLineSensor();
        }
        protected override double MeasureWeightOfPayloadPlate()
        {
            // The body is currently simulated. Command button is needed on the GUI to zero the current measured weight so to simulate that the user took the order off the robot
            PayloadWeight = 0.0;
            return PayloadWeight;
        }

        #region Polling sensors
        private bool? lastLineStatus = null;

        private void PollLineSensor()
        {
            UpdateSensorStatus(LineSensor.Scan().Max() > 0,
                ref lastLineStatus, OnLineAppears, OnLineDisappears);
        }

        #endregion

        /// <summary>
        /// Helper method for bool sensor status updates. Fires event is status has changed.
        /// </summary>
        /// <param name="newStatus">New sensor status</param>
        /// <param name="previousStatus">Reference to variable storing previous value</param>
        /// <param name="onTrueEvent">Event to fire if status changed to true.</param>
        /// <param name="onFalseEvent">Event to fire if status changed to false.</param>
        private void UpdateSensorStatus(bool newStatus, ref bool? previousStatus,
            SensorStatusChangeDelegate onTrueEvent, SensorStatusChangeDelegate onFalseEvent)
        {
            if (!previousStatus.HasValue || previousStatus != newStatus)
            {
                if (newStatus)
                    onTrueEvent?.Invoke();
                else
                    onFalseEvent?.Invoke();
                previousStatus = newStatus;
            }
        }

        #region Events indicating sensed environment changes
        public event SensorStatusChangeDelegate OnLineAppears;
        public event SensorStatusChangeDelegate OnLineDisappears;

        public delegate void SensorStatusChangeDelegate();
        #endregion
    }
}
