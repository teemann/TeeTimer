using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeeTimer
{
    class Timer
    {
        public delegate void OnTimerFinishHandler(Timer sender);

        public event OnTimerFinishHandler TimerFinished;

        private string _name;
        private TimeSpan _time;

        private Thread thr;
        DateTime last;

        public string name {
            get{
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public TimeSpan time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        public Timer(string name, TimeSpan time)
        {
            _name = name;
            _time = time;
            Thread thr = new Thread(Run);
            thr.Priority = ThreadPriority.Lowest;
        }

        public void Start()
        {
            if(thr.ThreadState != ThreadState.Running)
                thr.Start();
        }

        private void Run()
        {
            while (_time.TotalSeconds > double.Epsilon)
            {
                if (last == null)
                {
                    last = DateTime.Now;
                    continue;
                }
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
