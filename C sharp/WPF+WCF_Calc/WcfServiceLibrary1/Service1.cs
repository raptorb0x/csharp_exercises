using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Calc_Logics;

namespace WCF_Calc

{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string Data()
        {
            //return string.Format("You entered: {0}", value);
            return Logics.Data;
        }

        public void addDigit(char digit)
        {
            Logics.addDigit(digit);
        }

        public void Back()
        {
            Logics.Back();
        }

        public void Clear()
        {
            Logics.Clear();
        }

        public void Comma()
        {
            Logics.Comma();
        }
        
        public void Equality()
        {
            Logics.Equality();
        }

        public void Inverse()
        {
            Logics.Inverse();
        }

        public void Oper(char oper)
        {
            Logics.Oper(oper);
        }

        public void Percent()
        {
            Logics.Percent();
        }

        public void Reset()
        {
            Logics.Reset();
        }

        public void Sign()
        {
            Logics.Sign();
        }

        public void Sqrt()
        {
            Logics.Sqrt();
        }
    }
}
