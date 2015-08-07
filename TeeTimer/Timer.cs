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
        public delegate void OnTimerTickHandler(Timer sender, TimeSpan delta);

        public event OnTimerFinishHandler TimerFinished;
        public event OnTimerTickHandler TimerTick;

        private string _name;
        private TimeSpan _time;
        private bool _paused;
        private bool _running;

        private Thread thr;
        private DateTime last;

        public string Name {
            get{
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public TimeSpan Time
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

        public bool Paused
        {
            get { return _paused; }
            set
            {
                last = DateTime.Now;
                _paused = value;
            }
        }

        public Timer(string name, TimeSpan time)
        {
            _name = name;
            _time = time;
            thr = new Thread(Run);
            thr.IsBackground = true;
            thr.Priority = ThreadPriority.Lowest;
        }

        public void Start()
        {
            if (thr.ThreadState != ThreadState.Running)
            {
                last = DateTime.Now;
                _running = true;
                thr.Start();
            }
        }

        public void Stop()
        {
            _running = false;
        }

        private void Run()
        {
            while (_time.TotalSeconds > double.Epsilon && _running)
            {
                if (Paused)
                {
                    Thread.Sleep(250);
                    continue;
                }
                TimeSpan ts = DateTime.Now - last;
                _time -= ts;
                last = DateTime.Now;
                if (_time.TotalSeconds <= double.Epsilon || !_running)
                    break;
                TimerTick.Invoke(this, ts);
                Thread.Sleep(500);
            }
            _time = TimeSpan.Zero;
            if (_running)
            {
                TimerTick.Invoke(this, TimeSpan.Zero);
                TimerFinished.Invoke(this);
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public string TimeString()
        {
            StringBuilder ret = new StringBuilder();
            TimeSpan ts = Time;
            if (ts.Days > 0)
                ret.AppendFormat("{0} days ", ts.Days);
            if (ts.Hours > 0)
                ret.AppendFormat("{0} h ", ts.Hours);
            if (ts.Minutes > 0)
                ret.AppendFormat("{0} min ", ts.Minutes);
            if (ts.Seconds > 0 || ret.Length == 0)
                ret.AppendFormat("{0} sec ", ts.Seconds);
            return ret.ToString(0, ret.Length - 1);
        }
    }
}
