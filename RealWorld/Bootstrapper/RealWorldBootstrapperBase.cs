namespace RealWorld.Bootstrapper
{
    using RealWorld.IPL.MatchScheduler;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class RealWorldBootstrapperBase<TContainer> : IRealWorldBootstrapper
    {
        private bool initialised;
        private bool disposing;

        private Func<RealWorldInternalConfiguration> internalConfigurationFactory;
        private RealWorldInternalConfiguration internalConfiguration;

        protected RealWorldBootstrapperBase()
        {

        }

        protected TContainer ApplicationContainer { get; private set; }

        protected virtual Func<RealWorldInternalConfiguration> InternalConfiguration
        {
            get { return this.internalConfigurationFactory ?? (this.internalConfigurationFactory = RealWorldInternalConfiguration.Default); }
        }

        private RealWorldInternalConfiguration GetInitializedInternalConfiguration()
        {
            return this.internalConfiguration ?? (this.internalConfiguration = this.InternalConfiguration.Invoke());
        }

        public void Initialise()
        {
            var configuration = this.GetInitializedInternalConfiguration();

            if (configuration == null)
            {
                throw new InvalidOperationException("Configuration cannot be null");
            }

            if (!configuration.IsValid)
            {
                throw new InvalidOperationException("Configuration is invalid");
            }

            this.ApplicationContainer = this.GetApplicationContainer();

            var typeRegistrations = configuration.GetTypeRegistrations();
            this.RegisterTypes(this.ApplicationContainer, typeRegistrations);

            this.initialised = true;

        }

        public void Dispose()
        {
            if (this.disposing)
            {
                return;
            }

            if (!this.initialised)
            {
                return;
            }

            this.disposing = true;

            var container = this.ApplicationContainer as IDisposable;

            if (container != null)
            {
                try
                {
                    container.Dispose();
                }
                catch (ObjectDisposedException)
                {
                }
            }


            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {

        }

        protected abstract TContainer GetApplicationContainer();
        protected abstract void RegisterTypes(TContainer container, IEnumerable<TypeRegistration> typeRegistrations);

        public virtual void Run()
        {

        }
    }
}
