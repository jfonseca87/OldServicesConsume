using System.ServiceModel;
using WCFTest.Domain;

namespace WCFTest.Services
{
    [ServiceContract]
    public interface ITest
    {
        [OperationContract]
        void Invoice(Invoice invoice);
    }
}
