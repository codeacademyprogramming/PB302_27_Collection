using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Car:IInfo
    {
        public string Model;
        public string Brand;

        public void ShowInfo()
        {
            Console.WriteLine(Model+" - "+Brand);
        }
    }
}
