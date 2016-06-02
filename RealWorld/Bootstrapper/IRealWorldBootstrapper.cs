namespace RealWorld.Bootstrapper
{
    using System;

    public interface IRealWorldBootstrapper : IDisposable, IRealWorldEngine
    {
        void Initialise();
    }
}
