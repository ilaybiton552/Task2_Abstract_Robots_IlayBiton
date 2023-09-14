using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private string model;
		private DateTime creationDate;
		private double batteryStatus; 

		public RobotSpy(string model)
		{
			this.model = model;
			this.creationDate = DateTime.Now;
			this.batteryStatus = 100;
		}
		public string GetModel() { 	return this.model; }
		public DateTime GetDateTime() { return this.creationDate; }
		public double GetBatteryStatus() { return this.batteryStatus; }
		public void SetBatteryStatus(double batteryStatus) { this.batteryStatus = batteryStatus; }

		public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture() 
		{
			batteryStatus -= 5;
		}
		public void ChargeBattery()
		{
			batteryStatus = 100;
		}
	}
}
