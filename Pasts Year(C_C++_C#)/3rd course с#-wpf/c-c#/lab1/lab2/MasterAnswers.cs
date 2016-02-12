using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace lab2
{
    public class MasterAnswers
    {
        

        public ArrayList _age_groups = new ArrayList();
        public int _gender = 0;
        public int _need_company_name = 0;

        public MasterAnswers()
        {

        }

        public string ToString()
        {
            StringBuilder buf = new StringBuilder();
            buf.Append("Gender - ");
            if (_gender == 0)
                buf.Append("Men\n");
            else
                buf.Append("Women\n");
            buf.Append("Age groups - ");
            foreach (int ag in _age_groups)
            {
                buf.AppendFormat("{0}, ", ag);
            }

            buf.Append("\nNeed Company Name - ");
            if (_need_company_name == 0)
                buf.Append("Yes\n");
            else
                buf.Append("No\n");
            return buf.ToString();
        }
    }
}
