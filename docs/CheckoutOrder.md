# MerchantApi.Model.CheckoutOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reference** | **string** | The order id in the eCommerce system | [optional] 
**Amount** | **decimal?** | The total amount of the order | 
**Currency** | **string** | The ISO-4217 currency code. See https://en.wikipedia.org/wiki/ISO_4217 | 
**Shipping** | [**OrderShipping**](OrderShipping.md) |  | 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | The order item breakdown | [optional] 
**CartReference** | **string** | The shopping cart reference id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

