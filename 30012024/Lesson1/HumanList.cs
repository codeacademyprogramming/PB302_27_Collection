using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class HumanList
    {
        Human[] _values;

        public HumanList(int size = 0)
        {
            _values = new Human[size];
        }

        public int Length => _values.Length;

        public Human this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }

        public void Add(Human value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }
    }
}
