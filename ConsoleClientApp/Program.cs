using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpClient client = new HttpClient();

                //Define Headers
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
                client.DefaultRequestHeaders.Add("SOAPAction", "http://tempuri.org/Invoice");

                string xmlObject = "<? xml version=\"1.0\" encoding=\"utf-8\" ?><soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap:Body><Invoice xmlns=\"http://tempuri.org/\"><invoice><Id>1 </Id><InvoiceNumber>FA001</InvoiceNumber><IdClient>1</IdClient><NomClient>Cliente 1</NomClient><InvoiceValue>100.25</InvoiceValue><TotalTaxes> 10.25</TotalTaxes><TotalInvoice>110.50</TotalInvoice></invoice></Invoice></soap:Body></soap:Envelope>";

                var response = client.PostAsync("http://localhost:54601/Test.asmx", new StringContent(xmlObject, Encoding.UTF8, "text/xml")).Result;
                var content = response.Content.ReadAsStringAsync().Result;

                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}