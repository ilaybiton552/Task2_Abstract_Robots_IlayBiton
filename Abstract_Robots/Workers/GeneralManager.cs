using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        private double monthlySalary;
        private int workingRobots;

        public GeneralManager(string name, string id, DateTime bDate, string pass, 
            double monthlySalary, int workingRobots) :base (name,id,bDate,pass)
        {
            this.monthlySalary = monthlySalary;
            this.workingRobots = workingRobots;
        }

        public override double CalcIncome()
        {
            if (workingRobots > 30) 
            {
                return monthlySalary * 1.15;
            }
            return monthlySalary;
        }

    }
}
