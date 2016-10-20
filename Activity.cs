using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_v2
{
    public class Activity
    {
        private int ects;
        private string name;
        private string code;
        private Teacher teacher;

        public int ECTS
        {
            get { return ects; }
            set { ects = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get {return code;}
            set {code = value;}
        }

        public Teacher Teacher
        {
            get {return teacher;}
            set {teacher = value;}
        }

        public Activity(int pEcts, string pName, string pCode, Teacher pTeacher)
        {
            this.ects = pEcts;
            this.name = pName;
            this.code = pCode;
            this.teacher = pTeacher;
        }
    }
}
