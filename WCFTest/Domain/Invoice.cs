using System.Runtime.Serialization;

namespace WCFTest.Domain
{
    [DataContract]
    public class Invoice
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string InvoiceNumber { get; set; }

        [DataMember]
        public int IdClient { get; set; }

        [DataMember]
        public string NomClient { get; set; }

        [DataMember]
        public decimal InvoiceValue { get; set; }

        [DataMember]
        public decimal TotalTaxes { get; set; }

        [DataMember]
        public decimal TotalInvoice { get; set; }
    }
}