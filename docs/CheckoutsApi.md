# MerchantApi.Api.CheckoutsApi

All URIs are relative to *https://api.sandbox.zipmoney.com.au/merchant/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutsCreate**](CheckoutsApi.md#checkoutscreate) | **POST** /checkouts | Create a checkout
[**CheckoutsGet**](CheckoutsApi.md#checkoutsget) | **GET** /checkouts/{id} | Retrieve a checkout


<a name="checkoutscreate"></a>
# **CheckoutsCreate**
> Checkout CheckoutsCreate (CreateCheckoutRequest body = null)

Create a checkout

Creates a zipMoney checkout.  During the checkout process a customer can apply for credit decisioning in real-time. This means the checkout needs to represent a good picture of known customer details along with order information and the checkout entity represents this as a resource.  For more information on how to checkout with zipMoney see the #model:Z2QcrzRGHACY8wM6G guide.

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class CheckoutsCreateExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CheckoutsApi();
            var body = new CreateCheckoutRequest(); // CreateCheckoutRequest |  (optional) 

            try
            {
                // Create a checkout
                Checkout result = apiInstance.CheckoutsCreate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutsApi.CheckoutsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCheckoutRequest**](CreateCheckoutRequest.md)|  | [optional] 

### Return type

[**Checkout**](Checkout.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsget"></a>
# **CheckoutsGet**
> Checkout CheckoutsGet (string id)

Retrieve a checkout

Retrieves a previously created checkout by id.

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class CheckoutsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CheckoutsApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieve a checkout
                Checkout result = apiInstance.CheckoutsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckoutsApi.CheckoutsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**Checkout**](Checkout.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

