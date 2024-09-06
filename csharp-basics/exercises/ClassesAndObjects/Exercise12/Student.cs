using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(ITestpaper paper, string[] answers);
    }

    class Student : IStudent
    {
        private List<string> _testsTaken;

        public Student()
        {
            _testsTaken = new List<string> { "No tests taken" };
        }

        public string[] TestsTaken
        {
            get { return _testsTaken.ToArray(); }
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            int _correctAnswers = 0;
            int _totalQuestions = paper.GetMarkScheme().Length;

            for (int i = 0; i < _totalQuestions; i++)
            {
                if (answers[i] == paper.GetMarkScheme()[i])
                {
                    _correctAnswers++;
                }
            }

            double _percentage = ((double)_correctAnswers / _totalQuestions) * 100;
            
            int _passMark = int.Parse(paper.GetPassMark().TrimEnd('%'));

            string _result;
            if (_percentage >= _passMark)
            {
                _result = "Passed!";
            }
            else
            {
                _result = "Failed!";
            }

            string _testResult = $"{paper.GetSubject()}: {_result} ({_percentage:0.##}%)";

            if (_testsTaken.Count == 1 && _testsTaken[0] == "No tests taken")
            {
                _testsTaken.Clear();
            }

            _testsTaken.Add(_testResult);
        }
    }
}
