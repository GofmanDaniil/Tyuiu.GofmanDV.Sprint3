using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GofmanDV.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            char b = 'e';
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    value = value.Replace(chr, b);
                }
            }
            return value;
        }
    }
}
