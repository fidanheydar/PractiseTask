using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTask2.NonGeneric
{
    internal class MyList:IEnumerable
    {
        object[] _values;
        public MyList(int size = 0)
        {
            _values = new object[size];
        }

        public int Length
        {
            get { return _values.Length; }
        }


        public object this[int index]
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
        public void Add(object value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }

        public IEnumerable<object> GetProducts()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                yield return _values[i];
            }
        }

        //public IEnumerator<object> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
