using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTask
{
    internal class MyList<T> where T :IInfo /*Human */    //generic type gebul eden generic class type-a interface,class,struct
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
    }
}
