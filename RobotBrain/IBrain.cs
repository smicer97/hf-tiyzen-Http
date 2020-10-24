using Environment;
using Robot;
using RobotBrain.Command;
using RobotBrain.LogEntry;
using RobotBrain.State;
using Stand;
using System;

namespace RobotBrain
{
    public interface IBrain
    {
        event OnLoggedEventDelegate OnLoggedEvent;

        void AddCommand(ICommand cmd);
        bool TryToLoadRobotPayloadWithOrder();
        bool DiagnoseRobot();
        bool TrySetTargetLocation(string locatioName);
        void SetCurrentState(IState state);
        bool CheckGuestTookFood();
        double GetRobotSpeed();
        int[] PerformLineSensorScan();
        void SetRobotAcceleration(double acceleration);
        void SetRobotTurn(double turnInDegrees);
        Point GetTargetLocation();
        Point GetOrderLocation();
        bool GetObjectLocation(string objectOnTheMap, out Point objectOnTheMapLocation);
        Point GetRobotLocation();
        double GetRobotOrientation();
    }

    public delegate void OnLoggedEventDelegate(ILogEntry newEntry);
}
