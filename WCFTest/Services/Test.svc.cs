using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFTest.Domain;

namespace WCFTest.Services
{
    public class Test : ITest
    {
        public void Invoice(Invoice invoice)
        {
            ProcessInvoice(invoice); 
        }

        private void ProcessInvoice(Invoice invoice)
        {
            var inv = invoice;
        }
    }
}
