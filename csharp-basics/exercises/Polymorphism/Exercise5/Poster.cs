using System;


namespace Exercise5
{
    public class Poster : Advert
    {
        private int _copies;
        private int _costPerCopy;

        public Poster(int fee, int copies, int costPerCopy) : base(fee)
        {
            _copies = copies;
            _costPerCopy = costPerCopy;
        }

        public override int Cost()
        {
            return base.Cost() + (_copies * _costPerCopy);
        }

        public override string ToString()
        {
            return $"Poster cost: {Cost()}";
        }
    }
}
