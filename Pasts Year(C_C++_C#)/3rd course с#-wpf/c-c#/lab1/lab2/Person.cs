using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace lab2
{
    class Person
    {
        public Person(string n, string sn, string g, string dob, string cn) {
            Name = n;
            Surname = sn;
            Gender = g;
            DateOfBirth = dob;
            CompanyName = cn;

        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Surname {
            get { return surname; }
            set { surname = value; }
        }
        public string Gender {
            get { return gender; }
            set { gender = value; }
        }
        public string DateOfBirth {
            get { return date_of_birth; }
            set { date_of_birth = value; }
        }
        public string CompanyName {
            get { return company_name; }
            set { company_name = value; }
        }
        public XElement ToXml()
        {
            XElement elem = new XElement("person",
                new XElement("name", Name),
                new XElement("surname", Surname),
                new XElement("gender", Gender),
                new XElement("date_of_birth", DateOfBirth),
                new XElement("company_name", CompanyName));
            return elem;
        }
        static public Person FromXml(XElement elem)
        {
            Person p = new Person("", "", "", "", "");
            p.Name = elem.Element("name").Value;
            p.Surname = elem.Element("surname").Value;
            p.Gender = elem.Element("gender").Value;
            p.DateOfBirth = elem.Element("date_of_birth").Value;
            p.CompanyName = elem.Element("company_name").Value;
            return p;
        }

        private string name;
        private string surname;
        private string gender;
        private string date_of_birth;
        private string company_name;

        public bool CheckFilter(Dictionary<string, object> dict)
        {
            foreach (string key in dict.Keys)
            {
                switch (key)
                {
                    case "Name":
                        if (!Name.Contains((String)dict[key]))
                            return false;
                        break;
                    case "Surname":
                        if (!Surname.Contains((String)dict[key]))
                            return false;
                        break;
                    case "Gender":
                        if (!Gender.Contains((String)dict[key]))
                            return false;
                        break;
                    case "DateOfBirth":
                        if (!DateOfBirth.Contains((String)dict[key]))
                            return false;
                        break;
                    case "CompanyName":
                        if (!CompanyName.Contains((String)dict[key]))
                            return false;
                        break;
                }
            }
            return true;
        }

    }
}
