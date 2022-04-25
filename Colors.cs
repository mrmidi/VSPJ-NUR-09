using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV09
{
    class Colors
    {
        private String name;
        private int r, g, b;
        public Colors()
        {

        }
        public Colors(String name, int r, int g, int b)
        {
            this.name = name;
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public string getName()
        {
            return this.name;
        }
        //public int getR()
        //{
        //    return r;
        //}
        //public int getG()
        //{
        //    return g;
        //}
        //public int getB()
        //{
        //    return b;
        //}
        public int[] getRGB()
        {
            int[] result = { this.r, this.g, this.b };
            return result;
        }

        public string getNeuter()
        {
            string result = this.name.Remove(this.name.Length - 1) + "é";
            return result;
        }

        public Boolean contains(String searchstring)
        {
            if (this.name.Equals(searchstring))
                return true;
            return false;
        }
    }
}
