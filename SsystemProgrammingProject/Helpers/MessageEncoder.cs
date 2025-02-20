﻿using ChatestDomain.BusinessEntities.DTOs;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

public static class MessageEncoder
{
    private static JsonSerializerOptions Options = new()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true
    };

    public static byte[] MessageSerialize(ReadMessageDTO dto)
	{
        var json = JsonSerializer.Serialize(dto, Options);
        return Encoding.UTF8.GetBytes(json);
    }
}
