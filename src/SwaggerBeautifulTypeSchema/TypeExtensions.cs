using System.Collections;
using Demo.Api;

namespace SwaggerBeautifulTypeSchema;

internal static class TypeExtensions
{
    private const string ARRAY_SYMBOL = "[]";

    internal static string? BeautifulName(this Type type)
    {
        if(type.IsObjectType())
        {
            return type.Name;
        }

        if(type.IsArray())
        {
            return type.Name;
        }


        var typeName = type.GetName();


        // Is nested object?
        if(type.DeclaringType is not null)
        {
            var baseType = type.DeclaringType;
            while(baseType is not null && !baseType.IsObjectType())
            {
                var baseTypeName = baseType.GetName();
                if(!string.IsNullOrWhiteSpace(baseTypeName))
                {
                    typeName = $"{baseTypeName}.{typeName}";
                }

                baseType = baseType.DeclaringType;
            }
        }

        // Example:
        //    Response`1<Int32> -> Response<Int32>
        //    Response`1<List<Int32>> -> Response<List<Int32>>
        //    Data`2<Client, Product> -> Data<Client, Product>
        if(!string.IsNullOrEmpty(typeName))
        {
            typeName = BeautifulTypeRegex._genericIndexRegex()
                                         .Replace(typeName, "");
        }

        return typeName;
    }

    public static string? GetName(this Type type, bool rawName = false)
    {
        if(type.IsNullableType())
        {
            return null;
        }

        if(type.IsArray())
        {
            return type.Name;
        }

        if(type.IsListingType())
        {
            return $"{string.Join(',', type.GetGenericArguments().Select(GetRawName))}{ARRAY_SYMBOL}";
        }

        if(type.IsGenericType)
        {
            var genericTypes = type.GetGenericArguments()
                                   .Select(type => type.GetName(true))
                                   .Where(name => !string.IsNullOrWhiteSpace(name));

            return $"{type.GetRawName()}<{string.Join(',', genericTypes)}>";
        }

        return rawName ?
            type.GetRawName() :
            type.GetNameIfNotPrimitive();
    }

    internal static string? GetRawName(this Type type)
        => type switch
        {
            Type when type == typeof(ValueType) => null,
            Type when type == typeof(float) => "Float", // The real name is Single

            _ => type.Name
        };

    internal static string? GetNameIfNotPrimitive(this Type type)
        => type switch
        {
            Type when type == typeof(bool) => null,
            Type when type == typeof(bool) => null,
            Type when type == typeof(byte) => null,
            Type when type == typeof(sbyte) => null,
            Type when type == typeof(short) => null,
            Type when type == typeof(ushort) => null,
            Type when type == typeof(int) => null,
            Type when type == typeof(uint) => null,
            Type when type == typeof(long) => null,
            Type when type == typeof(ulong) => null,
            Type when type == typeof(float) => null,
            Type when type == typeof(double) => null,
            Type when type == typeof(decimal) => null,
            Type when type == typeof(char) => null,
            Type when type == typeof(object) => null,
            Type when type == typeof(string) => null,
            Type when type == typeof(nint) => null,
            Type when type == typeof(nuint) => null,
            Type when type == typeof(Guid) => null,
            Type when type == typeof(DateTime) => null,
            Type when type == typeof(ValueType) => null,

            _ => type.Name
        };

    internal static bool IsObjectType(this Type? type)
        => type == typeof(object);

    internal static bool IsArray(this Type? type)
    {
        if(type is null)
        {
            return false;
        }

        if(type.IsArray)
        {
            return true;
        }

        return type switch
        {
            Type when type == typeof(Array) => true,
            Type when type == typeof(ArrayList) => true,

            _ => false
        };
    }

    internal static bool IsListingType(this Type? type)
    {
        if(type is null)
        {
            return false;
        }

        if(type.IsIndexedListType())
        {
            return false;
        }

        if(type.IsArray())
        {
            return true;
        }

        if(!type.IsGenericType)
        {
            return false;
        }

        if(typeof(IEnumerable<>).IsAssignableFrom(type.GetGenericTypeDefinition()))
        {
            return true;
        }

        return type.GetInterfaces().Any(a =>
           typeof(IEnumerable<>).IsAssignableFrom(a) ||
           typeof(IEnumerable<>).IsAssignableFrom(a.GetGenericTypeDefinition()));
    }

    internal static bool IsIndexedListType(this Type type)
    {
        if(type is null)
        {
            return false;
        }

        if(!type.IsGenericType)
        {
            return false;
        }

        return
            typeof(IDictionary<,>).IsAssignableFrom(type.GetGenericTypeDefinition()) ||
            typeof(Dictionary<,>).IsAssignableFrom(type.GetGenericTypeDefinition());
    }

    internal static bool IsNullable(this Type type)
    {
        if(type.IsNullableType())
        {
            return true;
        }

        if(type.IsListingType())
        {
            return true;
        }

        return type switch
        {
            Type when type == typeof(string) => true,
            Type when type == typeof(ValueType) => false,

            Type when type.IsClass => true,

            _ => false
        };
    }

    internal static bool IsNullableType(this Type type)
    {
        if(type is null)
        {
            return false;
        }

        if(type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            return true;
        }

        return false;
    }
}
