using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBrain.State
{
    public interface IState
    {

        // Called by Brain when it is notified by the Simulator about a new time tick.
        void Tick();
        void OnLineAppears();
        void OnLineDisappears();

    }
}
