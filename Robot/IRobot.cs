using Environment;
using Stand;

namespace Robot
{
    public interface IRobot
    {
        LocOri LocationOrientation { get; set; }
        OrderType Payload { get; set; }
        Point Location { get; set; }
        double Orientation { get; set; }
        double Speed { get; set; }
        double Turn { get; set; }
        double Acceleration { get; set; }
        double PayloadWeight { get; set; }
        LineSensor LineSensor { get; set; }
        IEnvironment Environment { get; set; }
        event OnTickDelegate OnTick;

    }

    public delegate void OnTickDelegate();

}
