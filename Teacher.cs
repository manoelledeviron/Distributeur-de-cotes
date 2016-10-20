using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_v2
{
    public class Teacher : Person
    {
        private double salary;
        public double Salary
        {
            get {return salary;}
            set {salary = value;}
        }

        public static object Name { get; set; }

        public Teacher(string firstname, string lastname, double salary) : base(firstname, lastname) //base appelle le constructeur de person
            {this.salary = Salary;}
    }
}
