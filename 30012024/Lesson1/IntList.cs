using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class IntList 
    {
        int[] _values;

        public IntList(int size = 0)
        {
            _values = new int[size];
        }

        public int Length => _values.Length;

        public int this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }

        public void Add(int value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }
    }
}
