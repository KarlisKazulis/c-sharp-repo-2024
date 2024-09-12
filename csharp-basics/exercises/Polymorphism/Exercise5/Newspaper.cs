using System;


namespace Exercise5
{
    public class Newspaper : Advert
    {
        private int _column;
        private int _rate;

        public Newspaper(int fee, int rate, int column) : base(fee)
        {
            _column = column;
        }

        public override int Cost()
        {
            return base.Cost() + (_rate * _column);
        }

        public override string ToString()
        {
            return $"Newspaper cost: {Cost()}";
        }
    }
}
