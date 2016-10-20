using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2_v2
{
    public class Cote : Evaluation
    {
        private int note;
        public override int Note()
        {
            return note;
        }

        public void setNote(int Note)
        {
            this.note = Note;
        }
        public Cote(Activity activity, int note):base(activity,note)
        {
            this.note= note;
        }
    }
}
