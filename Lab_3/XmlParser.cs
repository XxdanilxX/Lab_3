using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_3
{
    internal static class XmlParser
    {
        public static Notepad ParseXml(string xml)
        {
            var notepad = new Notepad();
            var xmlDoc = XDocument.Parse(xml);

            foreach (var noteElement in xmlDoc.Root.Elements("note"))
            {
                var note = new Note
                {
                    Id = int.Parse(noteElement.Attribute("id").Value),
                    Date = noteElement.Attribute("date").Value,
                    Time = noteElement.Attribute("time").Value,
                    Subject = noteElement.Element("subject").Value,
                    Text = noteElement.Element("text").Value,
                    Telephone = noteElement.Element("text").Element("tel")?.Value,
                    Importance = noteElement.Element("importance")?.Value
                };
                notepad.Notes.Add(note);
            }

            return notepad;
        }
    }
}
