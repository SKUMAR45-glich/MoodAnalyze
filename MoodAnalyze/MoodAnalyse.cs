using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyze
{
    public class MoodAnalyse
    {
        string _mood;
        public MoodAnalyse()
        {
            _mood = "";
        }
        public string AnalyseMood(string msg)
        {

            Regex regexExp = new Regex("^(.*[ ])*[sS][aA][dD]([ ].*)*");
            _mood = regexExp.IsMatch(msg) ? "SAD" : "HAPPY";
            return _mood;
        }


    }
}
