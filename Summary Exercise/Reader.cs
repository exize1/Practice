using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Summary_Exercise
{
    internal class Reader
    {
        public static string GetHighestASCIIName(params string[] names)
        {
            int highestASCIIValue = 0;
            string HighestASCIIKey = "";
            foreach (string name in names)
            {
                int asciiValue = ASCIIEncoding.ASCII.GetByteCount(name);
                if (asciiValue > highestASCIIValue)
                {
                    highestASCIIValue = asciiValue;
                    HighestASCIIKey = name;
                }
            }

            return HighestASCIIKey;
        }

        //public static void OpenDirectories()
        //{
        //    Directory.GetDirectories(@"C:\Users\amio1\OneDrive\שולחן העבודה\Amit", )
        //}
    }
}
