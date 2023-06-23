using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Serializers;

/// <summary>
/// 
/// </summary>
public class DateTimeConverterUsingDateTimeParseMethod : JsonConverter<DateTime>
{
    private readonly string format;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="format"></param>
    public DateTimeConverterUsingDateTimeParseMethod(string format)
    {
        this.format = format;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="typeToConvert"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTime.Parse(reader.GetString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="writer"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(format));
    }
}