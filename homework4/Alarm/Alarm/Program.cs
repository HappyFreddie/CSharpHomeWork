using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    public delegate void AlarmHandler(object sender,AlarmEventArgs args);

    // 闹钟的参数
    public class AlarmEventArgs : EventArgs
    {
        public int Hour { get; }
        public int Minute { get; }
        public int Second { get; }
        public string Words { get; }

        public AlarmEventArgs(int hour, int minute, int second, string words)
        {
            this.Hour = hour; this.Minute = minute; this.Second = second; this.Words = words;
        }
    }

    // 闹钟具体功能
    public class Bell
    {
        int Hour = 0, Minute = 0, Second = 0;

        public event AlarmHandler Tick;
        public event AlarmHandler Alarm;

        public void StartBell()
        {
            while(!(DateTime.Now.Hour == Hour && DateTime.Now.Minute == Minute && DateTime.Now.Second == Second))
            { }
            AlarmEventArgs alarmEventArgs1 = new AlarmEventArgs(Hour,Minute,Second,"时间到了!!!");
            Alarm(this, alarmEventArgs1);
        }

        public void _Tick()
        {
            while(!(DateTime.Now.Hour == Hour && DateTime.Now.Minute == Minute && DateTime.Now.Second == Second))
            {
                    AlarmEventArgs alarmEventArgs2 = new AlarmEventArgs(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, "滴答...");
                    Tick(this, alarmEventArgs2);
            }

        }

        public bool SetTime(int h,int m, int s)
        {
            if (h > 24 || m > 60 || s > 60)
                return false;
            Hour = h; Minute = m; Second = s;
            return true;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Bell bell = new Bell();
            bell.SetTime(16, 27, 30);
            bell.Tick += new AlarmHandler(AlarmTrigger);
            bell.Alarm += new AlarmHandler(AlarmTrigger);
            bell._Tick();
            bell.StartBell();
        }

        private static void AlarmTrigger(object sender,AlarmEventArgs a)
        {
            string message = string.Format("{0}时{1}分{2}秒,{3}", a.Hour, a.Minute, a.Second, a.Words);
            Console.WriteLine(message);
        }
    }
}
