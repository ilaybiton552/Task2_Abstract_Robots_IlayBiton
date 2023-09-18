using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        private double hourlyWage;
        private int hours;
        private int tasksDone;
        public OperationManager(string name, string id, DateTime bDate, string pass, 
            double hourlyWage, int hours, int tasksDone) : base(name, id, bDate, pass)
        {
            this.hourlyWage = hourlyWage;
            this.hours = hours;
            this.tasksDone = tasksDone;
        }

        public override double CalcIncome()
        {
            return hourlyWage * hours * 1.03 * tasksDone;
        }
    }
}
