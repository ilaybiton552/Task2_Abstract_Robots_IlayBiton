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

		public RobotSpy(string model, DateTime creationDate, double batteryStatus)
		{
			this.model = model;
			this.creationDate = creationDate;
			this.batteryStatus = batteryStatus;
		}
		public string GetModel() { 	return this.model; }
		public DateTime GetDateTime() { return this.creationDate; }
		public double GetBatteryStatus() { return this.batteryStatus; }
		public void SetBatteryStatus(double batteryStatus) { this.batteryStatus = batteryStatus; }

		public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture() { } //4. הוסיפו התייחסות למצב סוללה
		public void ChargeBattery() { } //5. עדכנו את מצב הסוללה ל-100
	}
}
