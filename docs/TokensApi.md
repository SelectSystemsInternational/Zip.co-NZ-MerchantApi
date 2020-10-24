# MerchantApi.Api.TokensApi

All URIs are relative to *https://api.sandbox.zipmoney.com.au/merchant/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TokensCreate**](TokensApi.md#tokenscreate) | **POST** /tokens | Create token


<a name="tokenscreate"></a>
# **TokensCreate**
> Token TokensCreate (CreateTokenRequest body = null, string idempotencyKey = null)

Create token

Tokenises a zip account allowing a charge to be performed at a later date without direct customer involvement.  In order to create a token you will first need to request customer approval by implementing one of the online checkout flows. The checkout id will then be provided as the authority when tokenising.  | Error code | Description | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | account_inoperative | The account is in arrears or closed and cannot be charged | | account_locked | The account is locked |

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class TokensCreateExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TokensApi();
            var body = new CreateTokenRequest(); // CreateTokenRequest |  (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | The unique idempotency key. (optional) 

            try
            {
                // Create token
                Token result = apiInstance.TokensCreate(body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.TokensCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateTokenRequest**](CreateTokenRequest.md)|  | [optional] 
 **idempotencyKey** | **string**| The unique idempotency key. | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

