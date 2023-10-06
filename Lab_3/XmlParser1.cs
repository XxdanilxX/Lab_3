using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_3
{
    internal class XmlParser1
    {
        public static Firma ParseXml(string xml)
        {
            var firma = new Firma();
            var xmlDoc = XDocument.Parse(xml);

            foreach (var personals in xmlDoc.Root.Elements("personal"))
            {
                var personal = new Personal
                {
                    Id = int.Parse(personals.Attribute("id").Value),
                    FirstName = personals.Element("firstname").Value,
                    LastName = personals.Element("lastname").Value,
                    NickName = personals.Element("nickname").Value,
                    Salary = decimal.Parse(personals.Element("salary").Value)
                };
                firma.Employees.Add(personal);
            }

            return firma;
        }
    }
}
