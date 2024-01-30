using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Human:IInfo
    {
        public string Name;

        public void ShowInfo()
        {
            Console.WriteLine(Name);
        }
    }
}
