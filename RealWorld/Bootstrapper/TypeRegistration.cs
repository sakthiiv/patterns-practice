namespace RealWorld.Bootstrapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class TypeRegistration : ContainerRegistration
    {
        public TypeRegistration(Type registrationType, Type implementationType)
        {
            if (registrationType == null)
            {
                throw new ArgumentNullException("registrationType");
            }

            if (implementationType == null)
            {
                throw new ArgumentNullException("implementationType");
            }

            this.RegistrationType = registrationType;
            this.ImplementationType = implementationType;

            this.ValidateTypeCompatibility(implementationType);
        }

        public Type ImplementationType { get; private set; }
    }
}
