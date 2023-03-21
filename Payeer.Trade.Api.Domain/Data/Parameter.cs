﻿namespace Payeer.Trade.Api.Domain.Data;

public class Parameter
{
    public Parameter(string name, string value)
    {
        Name = name;
        Value = value;
    }
    public string Name { get; set; }
    public string Value { get; set; }
}