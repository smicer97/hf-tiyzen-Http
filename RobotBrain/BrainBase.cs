using Environment;
using Robot;
using RobotBrain.Command;
using RobotBrain.LogEntry;
using RobotBrain.State;
using Stand;
using System;

namespace RobotBrain
{

    public class BrainBase : IBrain
    {
        ICommand currentCommand = null;

        private Point targetLocation = new Point(0, 0);

        private Point orderLocation = new Point(0, 0);
        public bool IsRobotLoaded { get; set; }
        public IRobot Robot { get; private set; }
        public IStand Stand { get; }

        public IState CurrentState { get; set; } = null;
        public BrainBase(IRobot robot, IStand stand)
        {
            Robot = robot;
            Stand = stand;
            IsRobotLoaded = false;
            TargetLocation = Robot.Environment.GetObjectsCoordinatesOnTheMap()["Counter"];
            robot.OnTick += Robot_OnTick;
        }
        public bool TrySetTargetLocation(string locationName) {
            // Check if location name given in the argument exists among the objects
            if (Robot.Environment.GetObjectsCoordinatesOnTheMap().ContainsKey(locationName))
            {
                Robot.Environment.GetObjectsCoordinatesOnTheMap().TryGetValue(locationName, out targetLocation);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetCurrentState(IState state) {
            CurrentState = state;
        }
        public bool TryToLoadRobotPayloadWithOrder() {
            bool retVal;
            // Check if there are orders to take to the tables
            if (Stand.Orders.Count != 0)
            {
                // Check if the tablename corresponding to the order can be found in the Dictionary of objects stored in the environment
                if (Robot.Environment.GetObjectsCoordinatesOnTheMap().ContainsKey(Stand.Orders.Peek().TargetTableName)) {
                    Robot.Environment.GetObjectsCoordinatesOnTheMap().TryGetValue(Stand.Orders.Peek().TargetTableName, out targetLocation);
                    Robot.Environment.GetObjectsCoordinatesOnTheMap().TryGetValue(Stand.Orders.Peek().TargetTableName, out orderLocation);
                    Robot.Payload = Stand.Orders.Dequeue();
                    Robot.PayloadWeight = 1.0; // The
                    retVal = true;
                }
                else {
                    retVal = false;
                }
            }
            else {
                retVal = false;
            }
            return retVal;
        }
        public bool DiagnoseRobot()
        {
            // TO DO write diagnostic
            return true;
        }
        public Point TargetLocation
        {
            get => targetLocation;
            set
            {
                targetLocation = value;
            }
        }
        public Point OrderLocation
        {
            get => orderLocation;
            set
            {
                orderLocation = value;
            }
        }
        // 0.01 kg is the weight limit, measurement inaccuracy
        public bool CheckGuestTookFood() {
            return Robot.PayloadWeight < 0.01 ? true : false;
        }
        public double GetRobotSpeed() {
            return Robot.Speed;
        }
        public int[] PerformLineSensorScan() {
            return this.Robot.LineSensor.Scan();
        }
        public void SetRobotAcceleration(double acceleration) {
            this.Robot.Acceleration = acceleration;
        }
        public void SetRobotTurn(double turnInDegrees) {
            this.Robot.Turn = turnInDegrees;
        }

        public Point GetTargetLocation()
        {
            return TargetLocation;
        }

        public Point GetOrderLocation()
        {
            return OrderLocation;
        }
        public bool GetObjectLocation(string objectOnTheMapName, out Point objectOnTheMapLocation) 
        {
            // Check if location name given in the argument exists among the objects
            if (Robot.Environment.GetObjectsCoordinatesOnTheMap().ContainsKey(objectOnTheMapName))
            {
                Robot.Environment.GetObjectsCoordinatesOnTheMap().TryGetValue(objectOnTheMapName, out objectOnTheMapLocation);
                return true;
            }
            else
            {
                objectOnTheMapLocation = new Point(0.0, 0.0);
                throw new ArgumentOutOfRangeException();
                return false;
            }
        }

        public Point GetRobotLocation() {
            return Robot.Location;
        }
        public double GetRobotOrientation() {
            return Robot.Orientation;
        }

        #region Handle simulator events
        protected virtual void Robot_OnTick()
        {
            // Note: currentState is changing often. An OnTick event would need
            //  many subscriptions and unsubscriptions.
            CurrentState.Tick();

            Log(new TickLogEntry());

            if (currentCommand?.IsComplete() ?? false)
                Log(new CommandCompleteLogEntry(currentCommand));
        }
        #endregion

        public void AddCommand(ICommand cmd)
        {
            Log(new GenericLogEntry($"New command received"));
            currentCommand = cmd;
            currentCommand.Brain = this;
            cmd.Execute();
        }

        protected void Log(ILogEntry entry)
        {
            OnLoggedEvent?.Invoke(entry);
        }

        public event OnLoggedEventDelegate OnLoggedEvent;

        public IStand IStand
        {
            get => default;
            set
            {
            }
        }
    }
}
