namespace RealWorld
{
    using System;
    using RealWorld.IPL.MatchScheduler;
    using RealWorld.Bootstrapper;

    class Initializer
    {
        static void Main(string[] args)
        {
            var bootstrapper = RealWorldBootstrapperLocator.Bootstrapper;
            bootstrapper.Initialise();
            bootstrapper.Run();
            Console.ReadKey();
        }
    }
}
