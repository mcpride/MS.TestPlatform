using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// ReSharper disable CheckNamespace
namespace System
// ReSharper restore CheckNamespace
{
    public static class TypeExtensions
    {
        public static bool IsAssignableFrom(this Type self, Type baseType)
        {
            return self.GetTypeInfo().IsAssignableFrom(baseType.GetTypeInfo());
        }

        public static IEnumerable<PropertyInfo> GetProperties(this Type self)
        {
            return self.GetRuntimeProperties();
        }

        public static IEnumerable<ConstructorInfo> GetConstructors(this Type self)
        {
            return self.GetTypeInfo().DeclaredConstructors;
        }

        public static IEnumerable<ConstructorInfo> GetPublicInstanceConstructors(this Type self)
        {
            return self.GetTypeInfo().DeclaredConstructors.Where(c => !c.IsStatic && c.IsPublic);
        }

        public static IEnumerable<ConstructorInfo> GetPrivateInstanceConstructors(this Type self)
        {
            return self.GetTypeInfo().DeclaredConstructors.Where(c => !c.IsStatic && !c.IsPublic);
        }

        public static Type[] GetGenericArguments(this Type type)
        {
            return type.GenericTypeArguments;
        }

        public static IEnumerable<Type> GetInterfaces(this Type self)
        {
            return self.GetTypeInfo().ImplementedInterfaces;
        } 

        public static bool IsInstanceOfType(this Type self, object other)
        {
            return other != null && other.GetType().IsAssignableFrom(self);
        }

        public static IEnumerable<Type> GetTypes(this Assembly assembly)
        {
            return assembly.DefinedTypes.Select(t => t.AsType());
        }

        public static MethodInfo GetMethod(this Type self, string name)
        {
            return self.GetTypeInfo().GetDeclaredMethod(name);
        }

        public static IEnumerable<MethodInfo> GetMethods(this Type self, string name)
        {
            return self.GetTypeInfo().GetDeclaredMethods(name);
        }

        public static PropertyInfo GetProperty(this Type self, string name)
        {
            return self.GetTypeInfo().GetDeclaredProperty(name);
        }

        public static FieldInfo GetField(this Type self, string name)
        {
            return self.GetTypeInfo().GetDeclaredField(name);
        }

        public static EventInfo GetEvent(this Type self, string name)
        {
            return self.GetTypeInfo().GetDeclaredEvent(name);
        }

        public static TypeInfo GetNestedType(this Type self, string name)
        {
            return self.GetTypeInfo().GetDeclaredNestedType(name);
        }

        public static IEnumerable<Attribute> GetTypeCustomAttributes(this Type self, Type attributeType, bool inherit)
        {
            return self.GetTypeInfo().GetCustomAttributes(attributeType, inherit);
        }

        public static IEnumerable<Attribute> GetMemberCustomAttributes(this MemberInfo self, Type attributeType, bool inherit)
        {
            return self.GetCustomAttributes(attributeType, inherit);
        }
    }
}