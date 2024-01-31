﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTask
{
    internal class StringList
    {
        string[] _values;
        public StringList(int size=0)
        {
            _values = new string[size];
        }

        public int Length
        {
            get { return _values.Length; }
        }


        public string this[int index]
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
        public void Add(string value)
        {
            Array.Resize(ref _values, _values.Length+1);
            _values[_values.Length-1] = value;
        }
    }
}
