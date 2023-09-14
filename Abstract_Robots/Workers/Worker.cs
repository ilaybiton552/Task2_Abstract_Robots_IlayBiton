using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            fullName = name;
            idNumber = id;
            birthDate = bDate;
            password = pass;
        }

        public string GetFullName() { return fullName; }
        public string GetIdNumber() { return idNumber; }
        public DateTime GetBirthDate() { return birthDate; }
        public string GetPassword() { return password; }

        public void SetFullName(string name) { fullName = name; }
        public void SetPassword(string pass) { password = pass; }

        public abstract double CalcIncome();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
