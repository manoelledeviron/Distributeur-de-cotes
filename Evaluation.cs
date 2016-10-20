using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_v2
{
    public class Evaluation
    {
        private Activity activity;
        public Activity Activity
        {
            get { return activity; }
            set { activity = value; }
        }

        private int note;
        public virtual int Note()
        {
            return note;
        }
        public Evaluation(Activity Activity,int cote)
        {
            this.activity = Activity;
            this.note = cote;
        }
    }
}
