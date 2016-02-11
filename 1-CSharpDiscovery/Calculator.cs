using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    public class Calculator
    {
        const double pi = 3.14;
        public string mName { get; set; }

        public enum euro
        {

        }

        public Calculator()
        {
            mName = "Calculator";
        }

        public Calculator(string pName)
        {
            this.mName = pName;
        }

        public double sumOfTheArray(double[] doubleArray)
        {
            return doubleArray.Sum();
        }

        public double sumOfTheArray(string str)
        {
            string[] strSplit = str.Split('+');
            double wRetour=0.0;
            foreach (var strValue in strSplit)
            {
                var replace = strValue.Replace(" ","").ToLower();
                if (replace == "pi")
                {
                    wRetour += pi;
                }
                else
                {
                    wRetour += Convert.ToDouble(strValue);
                }
            }
            return wRetour;
        }
    }
}
