# MerchantApi.Model.CreateChargeRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Authority** | [**Authority**](Authority.md) |  | 
**Reference** | **string** | The reference for this charge (unique payment reference in your store) | [optional] 
**Amount** | **decimal?** | The amount of the charge | 
**Currency** | **string** | The currency | 
**Capture** | **bool?** | If true this will be a direct capture, pass false to perform an authorisation only | [optional] [default to true]
**Order** | [**ChargeOrder**](ChargeOrder.md) |  | [optional] 
**Metadata** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

