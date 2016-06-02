namespace RealWorld.Extentions
{
    using System;
    using System.Linq;

    public static class TypeExtensions
    {
        public static bool IsAssignableToGenericType(this Type givenType, Type genericType)
        {
            if (givenType == null || genericType == null)
            {
                return false;
            }

            return givenType == genericType
                || givenType.MapsToGenericTypeDefinition(genericType)
                || givenType.HasInterfaceThatMapsToGenericTypeDefinition(genericType)
                || givenType.BaseType.IsAssignableToGenericType(genericType);
        }

        private static bool MapsToGenericTypeDefinition(this Type givenType, Type genericType)
        {
            return genericType.IsGenericTypeDefinition
                && givenType.IsGenericType
                && givenType.GetGenericTypeDefinition() == genericType;
        }

        private static bool HasInterfaceThatMapsToGenericTypeDefinition(this Type givenType, Type genericType)
        {
            return givenType
                .GetInterfaces()
                .Where(it => it.IsGenericType)
                .Any(it => it.GetGenericTypeDefinition() == genericType);
        }

    }
}
