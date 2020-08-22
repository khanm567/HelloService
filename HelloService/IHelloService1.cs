using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService1" in both code and config file together.
    [ServiceContract(Name="IHelloService")]
    public interface IHelloService1
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
