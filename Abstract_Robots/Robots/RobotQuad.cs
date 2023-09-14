using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        private int[] legs; 
        // 0 - left front, 1 - right front, 2 - left back, 3 - right back

        public RobotQuad() : base("Roboquad")
        { 
            legs = new int[4];
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, 1);
        }

        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, -1);
        }

        public override void TurnLeft()
        {
            MoveLeg(0, -1);
            MoveLeg(1, 1);
            MoveLeg(2, -1);
            MoveLeg(3, 1);
        }

        public override void TurnRight()
        {
            MoveLeg(0, 1);
            MoveLeg(1, -1);
            MoveLeg(2, 1);
            MoveLeg(3, -1);
        }

        private void MoveLeg(int legId, int dir) 
        {
            SetBatteryStatus(GetBatteryStatus() - 3);
            legs[legId] += dir;
        }
    }

}
