using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Generic
{
    internal class MyList<T> :IEnumerable<T>
    {
        T[] _values;

        public MyList(int size = 0)
        {
            _values = new T[size];
        }

        public int Length => _values.Length;

        public T this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }

        public void Add(T value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                yield return _values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
