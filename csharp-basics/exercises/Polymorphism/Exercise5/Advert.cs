using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Advert
    {
        protected int _fee;

        public Advert()
        {
            _fee = 0;
        }

        public Advert(int fee)
        {
            _fee = fee;
        }

        public int Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

        public virtual int Cost()
        {
            return _fee;
        }

        public override string ToString()
        {
            return $" Advert cost = {_fee}";
        }
    }
}
