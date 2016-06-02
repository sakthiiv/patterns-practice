namespace RealWorld.Bootstrapper
{
    using System;
    using System.Linq;
    using RealWorld.Extentions;

    public abstract class ContainerRegistration
    {
        public Type RegistrationType { get; protected set; }

        protected void ValidateTypeCompatibility(params Type[] types)
        {
            if (this.RegistrationType == null)
            {
                throw new InvalidOperationException("The RegistrationType must be set first.");
            }

            var incompatibleTypes =
                types.Where(type => !this.RegistrationType.IsAssignableFrom(type) && !type.IsAssignableToGenericType(this.RegistrationType)).ToArray();

            if (incompatibleTypes.Any())
            {
                var incompatibleTypeNames =
                    string.Join(", ", incompatibleTypes.Select(type => type.FullName));

                var errorMessage =
                    string.Format("{0} must implement {1} inorder to be registered by {2}", incompatibleTypeNames, this.RegistrationType.FullName, this.GetType().Name);

                throw new ArgumentException(errorMessage);
            }
        }
    }
}
