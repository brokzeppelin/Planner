using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    internal class MyTask
    {
        private string _name;
        private double _duration;
        private TimeSpan _progress;

        public MyTask(string name, double duration, TimeSpan progress)
        {
            _name = name;
            _duration = duration;
            _progress = progress;
        }

        override public String ToString()
        {
            return _name;
        }
    }
}
