using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public interface ITestpaper
    {
        string GetSubject();
        string[] GetMarkScheme();
        string GetPassMark();
    }
    internal class Testpaper : ITestpaper
    {
        private string _subject;
        private string[] _markScheme;
        private string _passMark;

        public Testpaper(string subject, string[] markScheme, string passMark){
            _subject = subject;
            _markScheme = markScheme;
            _passMark = passMark;
        }

        public string GetSubject()
        {
            return _subject;
        }

        public string[] GetMarkScheme()
        {
            return _markScheme;
        }

        public string GetPassMark()
        {
            return _passMark;
        }
    }
}
