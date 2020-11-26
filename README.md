# Zip.co/NZ MerchantApi - C# Library for the Merchant API

Zip.co New Zealand Merchant API Initial build

This C# SDK was based on the Zip.co Australia C# Library and modified for the different stack used for https://zip.co/nz

- API version: 2020-10-24
- SDK version: 1.0.0
- Original Build package: io.swagger.codegen.languages.CSharpClientCodegen
- Developed by Select Systems International 

<a name="frameworks-supported"></a>
## Frameworks supported
- .netCore 3.1 or later

<a name="dependencies"></a>
## Dependencies
- [Microsoft.CSharp](https://www.nuget.org/packages/RestSharp) - 4.7.0
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3
- [RestSharp](https://www.nuget.org/packages/RestSharp/) - 106.11.7
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations/) - 5.0.0-rc.2.20475.5

<a name="installation"></a>
## Installation
Download Zip and Include Directories from MerchantApi in your Project

using MerchantApi.Api;
using MerchantApi.Model;

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Model;

namespace MerchantApi.Example
{
    /// <summary>
    ///  Class for testing OrdersApi

    public class ApiExample
    {
        AuthorizationApi authorizationApi;
        OrdersApi ordersApi;

        public void main()
        { 
            // Configure API key authorization, get an Access Token, Create an Order, Get an Order

            try
            {
                // Setup Authorization
                authorizationApi = new AuthorizationApi("https://merchant-auth-nz.sandbox.zip.co");
                authorizationApi.Configuration.ClientId = "Your Client Id";
                authorizationApi.Configuration.ClientSecret = "Your Client Secret";

                // Create Acces Token
                var authorization = authorizationApi.AuthorizationCreateToken();
                Debug.WriteLine(authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi: " + e.Message );
            }
	        
            try
            {
                // Create Order
		ordersApi = new OrdersApi("https://sandbox.zip.co/nz/api");
                var createOrderRequest = CreateRequest(CreateOrderRequest.PaymentFlowEnum.Payment);
                var authorization = authorizationApi.AuthorizationCreateToken();

                // Create Order
                var createOrderResponse = ordersApi.OrderCreate(authorization, "Idempotency-Key", createOrderRequest);
                Debug.WriteLine(createOrderResponse);
		
		// Get Order
		var id = createOrderResponse.OrderId;
                var order = ordersApi.OrderGet(id);
                Debug.WriteLine(order);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi: " + e.Message);
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints
*https://docs-nz.zip.co/merchant-api/api-reference*

<a name="status"></a>
## Status of Library
This is the inital build and is not yet complete:
- Still to add Customer endpoints 
- I will be building a nopCommerce plugin based on the Library and changes may be made over the coming weeks

