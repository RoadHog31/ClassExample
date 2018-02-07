using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Die
    {
        private int face;

        // Static Class Random
        Random rand = new Random();

        // default constructor
        public Die()
        {
            face = rand.Next(6) + 1;
        }

        public int Face
        {
            get { return face; }
            set { face = value; }
        }

        public int roll()
        {
            face = rand.Next(6) + 1;
            return face;
        }

        public override string ToString()
        {
            return "Face value is: " + face;
        }
    }
}
