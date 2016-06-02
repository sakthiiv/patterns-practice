namespace RealWorld.Bootstrapper
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using RealWorld.Extentions;

    public static class RealWorldBootstrapperLocator
    {
        private static IRealWorldBootstrapper instance;        

        public static IRealWorldBootstrapper Bootstrapper
        {
            get { return instance ?? (instance = LocateBootstrapper()); }
            set { instance = value; }
        }

        private static IRealWorldBootstrapper LocateBootstrapper()
        {
            var bootstrapperType = GetBootstrapperType();

            try
            {
                return Activator.CreateInstance(bootstrapperType) as IRealWorldBootstrapper;
            }
            catch (Exception ex)
            {
                var errorMessage = string.Format("Could not initialize bootstrapper of type '{0}'.", bootstrapperType.FullName);
                throw new BootstrapperException(errorMessage, ex);
            }
        }

        private static Type GetBootstrapperType()
        {
            try
            {
                Type initializer = Assembly.GetAssembly(typeof(RealWorldBootstrapperLocator)).GetTypes()
                    .Where(x => x.GetCustomAttribute(typeof(BootStrapperAttribute)) != null)
                    .FirstOrDefault();

                return initializer;
            }
            catch (Exception ex)
            {
                var errorMessage = string.Format("Could not initialize bootstrapper of type '{0}'.", "");
                throw new BootstrapperException(errorMessage);
            }
        }
    }
}
