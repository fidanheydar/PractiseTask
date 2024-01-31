using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTask
{
    internal class Car:IInfo
    {
        public string Model;
        public string Brand;

        public void ShowInfo()
        {
            Console.WriteLine(Model);
        }
    }
}
