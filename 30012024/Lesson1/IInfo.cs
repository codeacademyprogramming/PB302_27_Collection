using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal interface IInfo
    {
        void ShowInfo();
        public void ShowName()
        {
            Console.WriteLine("My name is Hikmet");
        }
    }
}
