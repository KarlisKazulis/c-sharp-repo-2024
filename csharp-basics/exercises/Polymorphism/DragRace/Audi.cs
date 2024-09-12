using System;

namespace DragRace
{
    public class Audi : Icar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 10;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}