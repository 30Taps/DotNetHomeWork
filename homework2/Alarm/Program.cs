using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    public delegate void AlarmHandler(object sender, AlarmEventArgs args);
    public class AlarmEventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
    }
    public class Time
    {
        public event AlarmHandler time;
        public void Alarm(int hour,int minute)
        {
            Console.WriteLine($"Alarm alarms on {hour}:{minute}");
            AlarmEventArgs args = new AlarmEventArgs()
            {
                Hour = hour,
                Minute = minute

            };
            if(args.Minute==00) time(this, args);
        }
        public void Tick(int hour,int minute)
        {
            Console.WriteLine($"Alarm ticks on {hour}:{minute}");
            AlarmEventArgs args = new AlarmEventArgs()
            {
                Hour = hour,
                Minute = minute
            };
            if(args.Minute!=00) time(this, args);
        }
    }
    public class AlarmClock
    {
        public Time time1 = new Time();
        public Time time2 = new Time();

        void Time_Tick(object sender,AlarmEventArgs args)
        {
            Console.WriteLine("The alarmclock is ticking!");
        }
        void Time_Alarm(object sender,AlarmEventArgs args)
        {
            Console.WriteLine("The alarmclock is alarming!");
        }
        public AlarmClock()
        {
            time1.time += new AlarmHandler(Time_Tick);
            time2.time += new AlarmHandler(Time_Alarm);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock time1 = new AlarmClock();
            time1.time1.Tick(16, 23);
            time1.time2.Tick(16, 23);

            AlarmClock time2 = new AlarmClock();
            time2.time2.Alarm(14, 00);
            time2.time1.Alarm(14, 00);
        }
    }
}
