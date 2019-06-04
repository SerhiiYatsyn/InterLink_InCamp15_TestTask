using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Person
{
    public class Knowledge
    {
        private int level;

        public int Level
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    level = value;
                }
            }
            get { return level; }
        }

        public Knowledge(int Level)
        {
            this.Level = Level;
        }
    }
}
