using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public decimal InvoiceValue { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal TotalInvoice { get; set; }
    }
}