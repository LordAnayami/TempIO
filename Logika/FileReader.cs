using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public class FileReader
    {
        public List<(double, double)> TempList;

        public FileReader()
        {
            TempList = new List<(double, double)>();
            try
            {
                using (StreamReader sr = new StreamReader("24hTemp.txt"))
                {
                    string line;
                    double i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        TempList.Add((i, Double.Parse(line)));
                        i++;
                    }

                }

            }
            catch (Exception)
            {
                TempList = null;
            }
        }
    }
}
