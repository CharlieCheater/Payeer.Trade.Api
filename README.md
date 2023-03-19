# Payeer API Client
### C#.NET client for Payeer Trades API.

## Features
- **Very easy** to understand and get started.
- API results **deserialized** to concrete objects for ease of usage.

## Getting Started
In order to use signed methods you need to [create a Payeer account](https://payeer.com/024501462), if you already have one, go to your account and create a [new Trade API private key](https://payeer.com/en/account/api/?tab=trade)

Create an instance of the **ApiClient** which receive the following parameters:

* **ApiId** - *Key used to authenticate within the API.*
* **ApiSecret** - *API secret used for signed API calls.*
* **ApiUrl (Optional)** - *Base URL of the API.*
```c#
    var apiClient = new ApiClient("@Your-API-Id", "@Your-API-Secret");
```

Create an instance of the **PayeerClient** which will receive the previously created ApiClient
```c#
    var payeerClient = new PayeerClient(apiClient);
```
