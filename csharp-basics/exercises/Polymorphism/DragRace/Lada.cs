using System;

namespace DragRace
{
    public class Lada : Icar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 15;
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 50;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("bing pow krtktkfastgiadg.......");
        }
    }
}