using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_v2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Person deViron = new Person("Manoëlle", "de Viron");
            Teacher LUR = new Teacher("Quent", "LUR", 2500);
            //LUR.DisplayName();
            Activity info = new Activity(6, "Projet Info", "PI3L",LUR);
            Evaluation coteinfodev = new Appreciation(info, "X");
            Evaluation coteinfobullshit = new Appreciation(info, "N");

            Teacher GNG = new Teacher("Fran", "GNG", 3500);
            //GNG.DisplayName();
            Activity electro = new Activity(4, "Electronique Analogique", "EA3T", GNG);
            Evaluation coteelectrodev = new Cote(electro, 16);
            Evaluation coteelectrobullshit = new Cote(electro, 2);

            Student deVironM = new Student("Manoëlle", "de Viron"); //No activity, activities added below!
            deVironM.Add(coteinfodev);
            deVironM.Add(coteelectrodev);

            Student newStud = new Student("Bullshit", "Hello!");
            newStud.Add(coteinfobullshit);
            newStud.Add(coteelectrobullshit);

            Console.WriteLine(deVironM.Bulletin()+"\n \n"+newStud.Bulletin());
            Console.Read();
        }
    }
}
