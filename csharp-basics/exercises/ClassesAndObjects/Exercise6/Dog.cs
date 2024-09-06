using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Dog
    {
        private string _name;
        private string _sex;
        private Dog _mother;
        private Dog _father;

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public void SetParents(Dog mother, Dog father)
        {
            _mother = mother;
            _father = father;
        }

        public string GetFatherName()
        {
            if (_father != null)
            {
                return _father._name;
            }
            else
            {
                return "Unknown";
            }
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return this._mother == otherDog._mother;
        }
    }
}
    
    

