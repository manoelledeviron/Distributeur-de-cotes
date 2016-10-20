using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_v2
{

    public class Student : Person
    {
        private List<Evaluation> cours;
        public List<Evaluation> Cours
        {
            get { return cours; }
            set { cours = value; }
        }

        public static object Name { get; set; }

        public Student(string firstname, string lastname) : base(firstname, lastname) //base appelle le constructeur de person
        { cours = new List<Evaluation>(); }

        public void Add(Evaluation evaluation)
        {
            cours.Add(evaluation);

        }

        public double Average()
        {
            int total = 0;
            int totECTS = 0;
            for (int i = 0; i < cours.Count; i++)
            {
                total = total + (cours.ElementAt(i).Note()* cours.ElementAt(i).Activity.ECTS);
                totECTS = totECTS + cours.ElementAt(i).Activity.ECTS;
            }
            double Average = total / (totECTS);
            return Average;

        }

        public string Bulletin()
        {
            string bulletin= "";
            for (int j = 0; j < cours.Count; j++)
            {
                Evaluation moncours = cours.ElementAt(j);
                int note=moncours.Note();
                string nomducours = moncours.Activity.Name;
                bulletin = bulletin +nomducours+": "+note +"\n";
            }
            
            return (Lastname+" "+Firstname+"\n"+"bulletin: \n"+bulletin +"average: "+ Average());

        }
    }

}
