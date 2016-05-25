using System;
using RealWorld.IPL.MatchScheduler;

namespace RealWorld
{
    class Initializer
    {
        static void Main(string[] args)
        {
            SchedulerBase schedule = new NormalScheduler();
            schedule.Display();
            //schedule.Matches.ForEach((m) =>
            //{
            //    Console.WriteLine(m.TeamA.Name + " vs " + m.TeamB.Name + " ---------- " + m.Venue.Name);
            //});
            Console.ReadKey();
        }
    }
}
