﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;

namespace ClientModel.Tests.Paging;

// A mock model that illustrate values that can be returned in a page collection
public class ValueItem
{
    public ValueItem(int id, string value)
    {
        Id = id;
        Value = value;
    }

    public int Id { get; }
    public string Value { get; }

    public string ToJson() => $"{{ \"id\" : {Id}, \"value\" : \"{Value}\" }}";

    public static ValueItem FromJson(JsonElement element)
    {
        int id = element.GetProperty("id").GetInt32();
        string value = element.GetProperty("value").GetString()!;
        return new ValueItem(id, value);
    }

    public override string ToString() => ToJson();
}
