using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker
    {
        private double hourlyWage;
        private int hours;
        public OperationalWorker(string name, string id, DateTime bDate, string pass, 
            double hourlyWage, int hours) : base(name, id, bDate, pass)
        {
            this.hourlyWage = hourlyWage;
            this.hours = hours;
        }

        public override double CalcIncome()
        {
            return hourlyWage * hours; 
        }

    }
}
