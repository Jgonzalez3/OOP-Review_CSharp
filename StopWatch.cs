using System;
using System.Collections.Generic;

namespace OOP{

    public class StopWatch{
        private TimeSpan time;
        private DateTime start;
        private bool started = false;
        public string stop {
            get{
                System.Console.WriteLine(started);
                if(started){
                    started = false;
                    System.Console.WriteLine(started);
                    int timeSpan = DateTime.Now.Millisecond - start.Millisecond;
                    if(timeSpan > 60){
                        var seconds = timeSpan/60;
                        return $"Milliseconds {seconds}";
                    }
                    return $"Seconds {timeSpan}";
                }
                return "Watch has not started yet";
            }
        }
        public StopWatch(){
        }
        public void StartTime(){
            if(started){
                throw new InvalidOperationException("Stopwatch has already started!!");
            }
            start = DateTime.Now;
            started = true;
            System.Console.WriteLine($"start time: {start}");
        }
        public void StopTime(){
            if(!started){
                throw new InvalidOperationException("Stopwatch has not Started yet!!");
            };
            started = false;
            time = start - DateTime.Now;
            System.Console.WriteLine(time);
        }
        public TimeSpan GetTimeInterval(){
            return time;
        }
    }
}