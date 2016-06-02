namespace RealWorld
{
    using RealWorld.Bootstrapper;
    using RealWorld.IPL.MatchScheduler;
    using System.Collections.Generic;
    using TinyIoC;

    public class DefaultRealWorldBootstrapper : RealWorldBootstrapperBase<TinyIoCContainer>
    {
        protected override TinyIoCContainer GetApplicationContainer()
        {
            return new TinyIoCContainer();
        }

        protected override sealed void RegisterTypes(TinyIoCContainer container, IEnumerable<TypeRegistration> typeRegistrations)
        {
            foreach (var typeRegistration in typeRegistrations)
            {
                container.Register(typeRegistration.RegistrationType, typeRegistration.ImplementationType).AsSingleton();
            }
        }
    }
}
