using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        private int rightDir;
        private int leftDir;
        public RobotWheels() : base("Spyke") 
        {
            rightDir = leftDir = 0;
        } 

        public override void MoveForward()
        {
            this.TurnWheels(1, 1);
        }

        public override void MoveBackward()
        {
            TurnWheels(-1, -1);
        }

        public override void TurnRight()
        {
            this.TurnWheels(-1, 0);
        }

        public override void TurnLeft()
        {
            TurnWheels(0, -1);
        }

        private void TurnWheels(int rightDir, int leftDir)
        {
            SetBatteryStatus(GetBatteryStatus() - 4.5);
            this.rightDir += rightDir;
            this.leftDir += leftDir;
        }

        public void WaveHands()
        {
            SetBatteryStatus(GetBatteryStatus() - 2);
        }

    }
}
