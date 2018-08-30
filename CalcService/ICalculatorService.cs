using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalcService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int add(int value1, int value2);

        [OperationContract]
        int substract(int value1, int value2);
    }
    
}
