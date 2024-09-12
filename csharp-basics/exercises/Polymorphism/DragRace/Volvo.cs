using System;

namespace DragRace
{
    public class Volvo : Icar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 14;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Ratatatatata......");
        }
    }
}