using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Calc
{
    /// <summary>
    /// Интерфейс с методами, которая пердоставляет служба
    /// </summary>
    [ServiceContract]  //атрибут сервиса
    public interface IService1
    {

        [OperationContract] //атрибут контракта-метода
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
