using System;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using I8Beef.Ecobee.Protocol;


namespace I8Beef.Ecobee.Serializers;

/// <summary>
/// JSON serialization helper.
/// </summary>
/// <typeparam name="TType">Type of object to serialize / deserialize to.</typeparam>
public static class JsonSerializer<TType>
    where TType : class
{
    /// <summary>
    /// Serializes an object to JSON
    /// </summary>
    /// <param name="instance">The object to serialize.</param>
        
    /// <returns>Serialized string.</returns>
    public static string Serialize(TType instance)
    {
        var settings = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false,
            TypeInfoResolver = SourceGenerationContext.Default,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };

        settings.Converters.Add(new DateTimeConverterUsingDateTimeParseMethod("yyyy-MM-dd"));

        // too soon
        //settings.Converters.Add(new JsonStringEnumConverter<RequestType>());
        settings.Converters.Add(new JsonStringEnumConverter());
        settings.Converters.Add(new CustomJsonConverterForType());

        return JsonSerializer.Serialize(instance, typeof(TType), settings);
    }

    /// <summary>
    /// DeSerializes an object from JSON
    /// </summary>
    /// <param name="json">The JSON string to deserialize.</param>
        
    /// <returns>Deserialized object.</returns>
    public static TType Deserialize(string json)
    {
        var settings = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false,
            TypeInfoResolver = SourceGenerationContext.Default
        };

        settings.Converters.Add(new DateTimeConverterUsingDateTimeParseMethod("yyyy-MM-dd"));
        settings.Converters.Add(new JsonStringEnumConverter());

        return JsonSerializer.Deserialize(json, typeof(TType), settings) as TType;
    }
}

/// <summary>
/// 
/// </summary>
public class CustomJsonConverterForType : JsonConverter<Type>
{
    /// <inheritdoc />
    public override Type Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options
    )
    {
        // Caution: Deserialization of type instances like this 
        // is not recommended and should be avoided
        // since it can lead to potential security issues.

        // If you really want this supported (for instance if the JSON input is trusted):
        // string assemblyQualifiedName = reader.GetString();
        // return Type.GetType(assemblyQualifiedName);
        throw new NotSupportedException();
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options
    )
    {
        var assemblyQualifiedName = value.AssemblyQualifiedName;
        // Use this with caution, since you are disclosing type information.
        writer.WriteStringValue(assemblyQualifiedName);
    }
}