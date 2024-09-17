using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _dictionary;

        public PhoneDirectory()
        {
            _dictionary = new SortedDictionary<string, string>();
        }

        public string GetNumber(string name)
        {
            if (_dictionary.ContainsKey(name))
            {
                return _dictionary[name];
            }
            else
            {
                return null;
            }
        }

        public void PutNumber(string name, string number) 
        {
            _dictionary[name] = number;
        }
    }
}