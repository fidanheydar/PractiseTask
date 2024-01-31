using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTask2
{
    internal class MyList<T> : IEnumerable<T>
    {
        T[] _values;
        public MyList(int size = 0)
        {
            _values = new T[size];
        }

        public int Length
        {
            get { return _values.Length; }
        }


        public T this[int index]
        {
            get
            {
                return _values[index];
            }
            set
            {
                _values[index] = value;
            }

        }
        public void Add(T value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }

      public IEnumerable<T> GetProducts()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                yield return _values[i];
            }
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_values).GetEnumerator();
        }
    }
}
