# MerchantApi.Api.CustomersApi

All URIs are relative to *https://api.sandbox.zipmoney.com.au/merchant/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomersGet**](CustomersApi.md#customersget) | **GET** /customers/{id} | Retrieve customer
[**CustomersList**](CustomersApi.md#customerslist) | **GET** /customers | List customers


<a name="customersget"></a>
# **CustomersGet**
> void CustomersGet (string id)

Retrieve customer

Retrieves the details of a customer by id. This will only return customer details for customers who have transacted previously via the zip Merchant API.

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class CustomersGetExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieve customer
                apiInstance.CustomersGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGet: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/javascript
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerslist"></a>
# **CustomersList**
> void CustomersList ()

List customers

Returns a list of all customers who have transacted previously with your merchant account.

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class CustomersListExample
    {
        public void main()
        {
            
            var apiInstance = new CustomersApi();

            try
            {
                // List customers
                apiInstance.CustomersList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersList: " + e.Message );
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

