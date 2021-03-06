/* 
 * Merchant API
 *
 * ZipMoney Merchant API Initial build
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;
using RestSharp;

using MerchantApi.Api;
using MerchantApi.Model;

namespace MerchantApi.Test
{
    /// <summary>
    ///  Class for testing OrdersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrdersApiTests
    {
        private AuthorizationApi authorizationApi;
        private Metadata metaData;
        private OrdersApi instance;
        

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            authorizationApi = new AuthorizationApi("https://merchant-auth-nz.sandbox.zip.co");
            authorizationApi.Configuration.ClientId = "VxBHMqt9aI4cPHjRBBmLt1Orw6xkk63n";
            authorizationApi.Configuration.ClientSecret = "o7fNo_1vfSDYUyMA_ZD2sVqxAiO-oeEkYo2FDQhiyUdeJ-8-rx91wRrUkUEJmgEe";
            
            metaData = new Metadata("platform", "nopCommerce v4.2 Payment Plugin");
            instance = new OrdersApi("https://sandbox.zip.co/nz/api");
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrdersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrdersApi
            Assert.IsInstanceOf(typeof(OrdersApi), instance, "instance is a OrdersApi");
        }

        /// <summary>
        /// Crate a Test Order Request
        /// </summary>
        public CreateOrderRequest CreateRequest(CreateOrderRequest.PaymentFlowEnum paymentFlow)
        {
            var phoneNumber = new PhoneNumber("string", true);
            var consumer = new Consumer(phoneNumber, "Given Name", "Surname", "youremail@yourwebsite.com");
            var billing = new OrderAddress("AddressLine1", "AddressLine2", "Suburb", "Billing", "9999", "State");
            var shipping = new OrderAddress("AddressLine1", "AddressLine2", "Suburb", "Shipping", "9999", "State");

            var item1 = new OrderItem("Decription1", "Name1", "SKU1", 1, 123, "Merchant 1");
            var item2 = new OrderItem("Decription1", "Name1", "SKU1", 1, 123, "Merchant 1");
            var items = new List<OrderItem>();
            items.Add(item1);
            items.Add(item2);

            string RedirectConfirmUrl = "https://orders.yourwebsite.com/confirm";
            string RedirectCancelUrl = "https://orders.yourwebsite.com/cancel";

            var merchant = new Merchant(RedirectConfirmUrl, RedirectCancelUrl);

            string promotion1 = "Promotion1";
            string promotion2 = "Promotion2";
            var promotions = new string[2];
            promotions[0] = promotion1;
            promotions[1] = promotion2;

            var pairing = new Pairing("Pairing Token");

            var createOrderRequest = new CreateOrderRequest(CreateOrderRequest.TypeEnum.Classic, 123, consumer, billing, shipping, "Description", items, merchant,
                "Merchant Refernece", 123, 456, "Token1", promotions, pairing, paymentFlow, metaData);

            return createOrderRequest;
        }

        /// <summary>
        /// Test Order Create
        /// </summary>
        [Test]
        public void OrdersCreateTest()
        {
            // TODO uncomment below and replace AccessToken to test the basic method

            //var client = new RestClient("https://sandbox.zip.co/nz/api/order");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "Bearer <AccessToken>");
            //request.AddParameter("application/json", "{\r\n  \"productType\": \"Classic\",\r\n  \"amount\": 123,\r\n  \"consumer\": {\r\n    \"phoneNumber\": {\r\n      \"number\": \"string\",\r\n      \"isVerified\": true\r\n    },\r\n    \"givenNames\": \"string\",\r\n    \"surname\": \"string\",\r\n    \"email\": \"string\"\r\n  },\r\n  \"billing\": {\r\n    \"addressLine1\": \"string\",\r\n    \"addressLine2\": \"string\",\r\n    \"suburb\": \"string\",\r\n    \"city\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"state\": \"string\"\r\n  },\r\n  \"shipping\": {\r\n    \"addressLine1\": \"string\",\r\n    \"addressLine2\": \"string\",\r\n    \"suburb\": \"string\",\r\n    \"city\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"state\": \"string\"\r\n  },\r\n  \"description\": \"string\",\r\n  \"items\": [\r\n    {\r\n      \"description\": \"string\",\r\n      \"name\": \"string\",\r\n      \"sku\": \"string\",\r\n      \"quantity\": 123,\r\n      \"price\": 123,\r\n      \"merchantChannel\": \"string\"\r\n    }\r\n  ],\r\n  \"merchant\": {\r\n    \"redirectConfirmUrl\": \"https://v43demo.selectsystems.com.au/confirm\",\r\n    \"redirectCancelUrl\": \"https://v43demo.selectsystems.com.au/cancel\"\r\n  },\r\n  \"merchantReference\": \"string\",\r\n  \"taxAmount\": 123,\r\n  \"shippingAmount\": 123,\r\n  \"token\": \"string\",\r\n  \"promotions\": [\r\n    \"string\"\r\n  ],\r\n  \"pairing\": {\r\n    \"token\": \"string\"\r\n  },\r\n  \"paymentFlow\": \"payment\"\r\n}", ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            var authorization = authorizationApi.AuthorizationCreateToken("https://auth-dev.partpay.co.nz");
            var createOrderRequest = CreateRequest(CreateOrderRequest.PaymentFlowEnum.Payment);

            var response = instance.OrderCreate(authorization, "IK001", createOrderRequest);

            Assert.IsInstanceOf<OrderCreateResponse>(response, "response is OrderCreateResponse");
        }

        /// <summary>
        /// Test Order Get
        /// </summary>
        [Test]
        public void OrdersGetTest()
        {
            // TODO uncomment below and replace merchant access key to test the basic method

            //var client = new RestClient("https://sandbox.zip.co/nz/api/order/{{order_id}}");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "Bearer <AccessToken>");
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            string id = null;

            var authorization = authorizationApi.AuthorizationCreateToken("https://auth-dev.partpay.co.nz");
            var createOrderRequest = CreateRequest(CreateOrderRequest.PaymentFlowEnum.Payment);
            var createOrderResponse = instance.OrderCreate(authorization, "IK002", createOrderRequest);
            id = createOrderResponse.OrderId;

            System.Threading.Thread.Sleep(2000); // Give the system time to complete the creation of the order

            var response = instance.OrderGet(authorization, id);
            Assert.IsInstanceOf<CheckoutOrder> (response, "response is Checkout");
        }

        /// <summary>
        /// Test Order Update Merchant Reference
        /// </summary>
        [Test]
        public void OrderUpdateMerchantReference()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string id = null;

            var authorization = authorizationApi.AuthorizationCreateToken("https://auth-dev.partpay.co.nz");
            var createOrderRequest = CreateRequest(CreateOrderRequest.PaymentFlowEnum.Payment);
            var createOrderResponse = instance.OrderCreate(authorization, "IK003", createOrderRequest);
            id = createOrderResponse.OrderId;

            System.Threading.Thread.Sleep(2000); // Give the system time to complete the creation of the order

            var order = instance.OrderGet(authorization, id);

            instance.OrderUpdateMerchantReference(order.OrderId, "new reference");

            System.Threading.Thread.Sleep(2000); // Give the system time to complete the update of the order

            var response = instance.OrderGet(authorization, id);

            Assert.AreEqual("new reference", response.MerchantReference, "response is Updated");
        }

        /// <summary>
        /// Test Order Refund Payment
        /// </summary>
        [Test]
        public void OrderCapturePayment()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string id = null;

            var authorization = authorizationApi.AuthorizationCreateToken("https://auth-dev.partpay.co.nz");
            var createOrderRequest = CreateRequest(CreateOrderRequest.PaymentFlowEnum.Authorization);
            var createOrderResponse = instance.OrderCreate(authorization, "IK004", createOrderRequest);
            id = createOrderResponse.OrderId;

            System.Threading.Thread.Sleep(2000); // Give the system time to complete the creation of the order

            var order = instance.OrderGet(authorization, id);

            var capture = new CreateCaptureRequest(id, 50);

            var response = instance.OrderCapture(authorization, id, "IK005", capture);

            Assert.IsInstanceOf<CaptureOrder>(response, "response is Refund");
        }

        /// <summary>
        /// Test Order Refund Payment
        /// </summary>
        [Test]
        public void OrderRefundPayment()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string id = null;

            var authorization = authorizationApi.AuthorizationCreateToken("https://auth-dev.partpay.co.nz");
            var createOrderRequest = CreateRequest(CreateOrderRequest.PaymentFlowEnum.Payment);
            var createOrderResponse = instance.OrderCreate(authorization, "IK006", createOrderRequest);
            id = createOrderResponse.OrderId;

            System.Threading.Thread.Sleep(2000); // Give the system time to complete the creation of the order

            var order = instance.OrderGet(authorization, id);

            var refund = new CreateRefundRequest(50, "Refund test");

            var response = instance.OrderRefund(authorization, id, "IK007", refund);

            Assert.IsInstanceOf<RefundOrder>(response, "response is Refund");
        }


        /// <summary>
        /// Test Order Void Payment
        /// </summary>
        [Test]
        public void OrderVoidPayment()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string id = null;

            var authorization = authorizationApi.AuthorizationCreateToken("https://auth-dev.partpay.co.nz");
            var createOrderRequest = CreateRequest(CreateOrderRequest.PaymentFlowEnum.Authorization);
            var createOrderResponse = instance.OrderCreate(authorization, "IK008", createOrderRequest);
            id = createOrderResponse.OrderId;

            System.Threading.Thread.Sleep(2000); // Give the system time to complete the creation of the order

            var order = instance.OrderGet(authorization, id);

            var voidRequest = new CreateVoidRequest(50);

            var response = instance.OrderVoid(authorization, id, "IK009", voidRequest);

            Assert.IsInstanceOf<VoidOrder>(response, "response is VoidOrder");
        }

    }

}
