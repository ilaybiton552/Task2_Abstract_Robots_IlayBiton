using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        private int[] legs;
        // 0 - left front, 1 - right front, 2 - left middle, 3 - right middle
        // 4 - left back, 5 - right back
        private int[] wings;
        // 0 - left front, 1 - right front, 2 - left back, 3 - right back
        public RobotFly() : base("Robofly") 
        {
            legs = new int[6];
            wings = new int[4];
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, 1);
        }

        public override void MoveBackward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, -1);
        }

        public override void TurnLeft()
        {
            MoveLeg(0, -1);
            MoveLeg(1, 1);
            MoveLeg(2, -1);
            MoveLeg(3, 1);
            MoveLeg(4, -1);
            MoveLeg(5, 1);
        }

        public override void TurnRight()
        {
            MoveLeg(0, 1);
            MoveLeg(1, -1);
            MoveLeg(2, 1);
            MoveLeg(3, -1);
            MoveLeg(4, 1);
            MoveLeg(5, -1);
        }

        public void FlyForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveWing(i, 1);
        }

        public void FlyBackward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveWing(i, -1);
        }

        public void FlyLeft()
        {
            MoveWing(0, -1);
            MoveWing(1, 1);
            MoveWing(2, -1);
            MoveWing(3, 1);
        }

        public void FlyRight()
        {
            MoveWing(0, 1);
            MoveWing(1, -1);
            MoveWing(2, 1);
            MoveWing(3, -1);
        }

        private void MoveLeg(int legId, int dir)
        {
            SetBatteryStatus(GetBatteryStatus() - 2);
            legs[legId] += dir;
        }

        private void MoveWing(int wingId, int dir)
        {
            SetBatteryStatus(GetBatteryStatus() - 1.5);
            wings[wingId] += dir;
        }

    }
}
