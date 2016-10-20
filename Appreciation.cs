using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_v2
{
    public class Appreciation : Evaluation
    {
        private string appreciation;
        private int note;

        public override int Note()
        {
            string apprec = appreciation;
            appreciation = appreciation.Replace("N","4");
            appreciation = appreciation.Replace("C", "8");
            appreciation = appreciation.Replace("TB", "16");
            appreciation = appreciation.Replace("B", "12");
            appreciation = appreciation.Replace("X", "20");
            int cote = Convert.ToInt32(appreciation);
            return cote ;
            
        }
        public void setAppreciation(string Appreciation)
        {
            this.appreciation = Appreciation;
        }
        public Appreciation(Activity activity, string appreciation, int note=0) :base(activity, note)
        {
            this.appreciation = appreciation;
            int cote = Note();
            this.note = cote;
        }

    }
}
