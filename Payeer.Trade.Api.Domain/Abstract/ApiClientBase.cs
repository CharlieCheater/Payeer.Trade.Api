﻿using Payeer.Trade.Api.Domain.Data;
using Payeer.Trade.Api.Domain.Interfaces;
using Payeer.Trade.Api.Models.General;

namespace Payeer.Trade.Api.Domain.Abstract;

public abstract class ApiClientBase
{
    public string ApiUrl { get; init; }
    public string ApiId { get; init; }
    public string ApiSecret { get; init; }
    public HttpClient Client { get; init; }

    public ApiClientBase(string apiId, string apiSecret, string apiUrl = "https://payeer.com/api/trade/", bool addDefaultHeaders = true)
    {
        ApiUrl = apiUrl;
        ApiId = apiId;
        ApiSecret = apiSecret;
        Client = new HttpClient
        {
            BaseAddress = new Uri(apiUrl)
        };

        if (addDefaultHeaders)
        {
            InitializeHttpClient();
        }
    }

    protected Task<SignatureInfo> GetSignAsync(string apiMethod, List<Parameter> parameters) 
        => SignBuilder.BuildSignAsync(ApiSecret, apiMethod, parameters);
    private void InitializeHttpClient()
    {
        Client.DefaultRequestHeaders.Add("Accept", "application/json");
        Client.DefaultRequestHeaders.TryAddWithoutValidation(ApiHeaders.ApiId, ApiId);
    }
}