using System;
using System.CodeDom;
using System.ComponentModel.Design;
using System.Linq;

namespace Telerik.JustMock.EntityFramework
{
	public static class TypeExtensions
	{
        internal static bool IsGenericInterfaceOfType(this Type type, Type intfType)
        {
			return type.IsInterface && type.IsGenericType && type.GetGenericTypeDefinition() == intfType;
        }

        internal static Type GetGenericInterfaceOfType(this Type type, Type intfType)
        {
			return type.IsGenericInterfaceOfType(intfType)
				? type : type.GetInterfaces().FirstOrDefault(intf => intf.IsGenericInterfaceOfType(intfType));
		}
	}
}