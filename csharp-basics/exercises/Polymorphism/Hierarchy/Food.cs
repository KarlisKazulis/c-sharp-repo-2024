using System;


namespace Hierarchy
{
    public abstract class Food
    {
        public int Quantity { get; set; }
    }

    public class Vegetable : Food { }
    
    public class Meat : Food { }
}
