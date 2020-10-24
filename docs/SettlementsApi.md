# MerchantApi.Api.SettlementsApi

All URIs are relative to *https://api.sandbox.zipmoney.com.au/merchant/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SettlementsGet**](SettlementsApi.md#settlementsget) | **GET** /settlements/{id} | Retrieve a settlement
[**SettlementsList**](SettlementsApi.md#settlementslist) | **GET** /settlements | List settlements


<a name="settlementsget"></a>
# **SettlementsGet**
> Settlement SettlementsGet (string id)

Retrieve a settlement

Retrieves the full transactional details of a settlement.

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class SettlementsGetExample
    {
        public void main()
        {
            
            var apiInstance = new SettlementsApi();
            var id = id_example;  // string | The settlement id

            try
            {
                // Retrieve a settlement
                Settlement result = apiInstance.SettlementsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettlementsApi.SettlementsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The settlement id | 

### Return type

[**Settlement**](Settlement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/javascript
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settlementslist"></a>
# **SettlementsList**
> void SettlementsList ()

List settlements

This endpoint will allow a merchant to view the settlements which have occured. To view detailed transaction information for a specific settlement you can use the Retrieve a settlement endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class SettlementsListExample
    {
        public void main()
        {
            
            var apiInstance = new SettlementsApi();

            try
            {
                // List settlements
                apiInstance.SettlementsList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettlementsApi.SettlementsList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/javascript
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

