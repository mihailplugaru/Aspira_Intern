using Newtonsoft.Json;
using RestSharp;
using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Payment_Request
{
    public class Program
    {
        public class TransactionAmount
        {
            public string total { get; set; }
            public string currency { get; set; }
        }

        public class ExpiryDate
        {
            public string month { get; set; }
            public string year { get; set; }
        }

        public class PaymentCard
        {
            public string number { get; set; }
            public string securityCode { get; set; }
            public ExpiryDate expiryDate { get; set; }
        }

        public class PaymentMethod
        {
            public PaymentCard paymentCard { get; set; }
        }

        public class Root
        {
            public string requestType { get; set; }
            public string merchantTransactionId { get; set; }
            public TransactionAmount transactionAmount { get; set; }
            public PaymentMethod paymentMethod { get; set; }
        }

        static void Main(string[] args)
        {
            var client =
                new RestClient("https://prod.emea.api.fiservapps.com/sandbox/ipp/payments-gateway/v2/payments/")
                {
                    Timeout = -1
                };

            //Calculate UNIX time

            var pDate = DateTimeOffset.Parse(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff"), CultureInfo.InvariantCulture);
            var time = pDate.ToUnixTimeMilliseconds();

            
            var apiAppKey = "YMda70xNsG3G6ASPul7ek2yA5HPAstxp";
            var apiAppSecret = "A5rbOQIGlXA78rIG1NzeToMG9RXy37HhV4de9SfjAnj";

            var clientRequestId = Guid.NewGuid().ToString();

            var root = new Root
            {
                merchantTransactionId = "Merchant-1234",
                paymentMethod = new PaymentMethod
                {
                    paymentCard = new PaymentCard
                    {
                        number = "5204740000001002",
                        expiryDate = new ExpiryDate { month = "10", year = "22" },
                        securityCode = "002"
                    }
                },
                requestType = "PaymentCardSaleTransaction",
                transactionAmount = new TransactionAmount { currency = "GBP", total = "54.62" },
            };

            var requestBody = JsonConvert.SerializeObject(root);

            var messageContent = new[] {apiAppKey, clientRequestId, time.ToString(), requestBody};

            var rawSignature = string.Join("", messageContent.Select(x => x));

            var computedHmac = GenerateHash(rawSignature, apiAppSecret);

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Client-Request-Id", clientRequestId.ToString());
            request.AddHeader("Api-Key", apiAppKey);
            request.AddHeader("Timestamp", time.ToString());
            request.AddHeader("Message-Signature", computedHmac);

            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            request.AddParameter("application/json", requestBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            Console.WriteLine(requestBody);
            Console.WriteLine(response.Content);
            Console.ReadKey();
        }


        public static string GenerateHash(string str, string cypherKey)
        {
            var encoder = new UTF8Encoding();
            byte[] keyBytes = encoder.GetBytes(cypherKey);
            byte[] messageBytes = encoder.GetBytes(str);

            byte[] hashBytes = new HMACSHA256(keyBytes).ComputeHash(messageBytes);
            var hexString = ToHexString(hashBytes);
            var base64 = Convert.ToBase64String(encoder.GetBytes(hexString));

            return base64;
        }

        private static string ToHexString(byte[] array)
        {
            StringBuilder hex = new StringBuilder(array.Length * 2);
            foreach (byte b in array)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
    }
}