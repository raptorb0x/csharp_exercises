using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Calc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Data();

        [OperationContract]
        void addDigit(char digit);

        [OperationContract]
        void Back();

        [OperationContract]
        void Clear();

        [OperationContract]
        void Reset();

        [OperationContract]
        void Comma();

        [OperationContract]
        void Sign();

        [OperationContract]
        void Oper(char oper);

        [OperationContract]
        void Equality();

        [OperationContract]
        void Sqrt();

        [OperationContract]
        void Inverse();

        [OperationContract]
        void Percent();
        // TODO: Add your service operations here
    }


}
