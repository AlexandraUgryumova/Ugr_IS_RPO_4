using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace конвертер_валют_консоль {
    internal class Program {
        static void Main (string[] args) {
            // создаем экземпляр XmlDocument
            XmlDocument doc1 = new XmlDocument();
            XDocument doc2 = XDocument.Parse("Valute.xml");
            doc1.Load("Valute.xml");
            List<ClassValute> valutes = new List<ClassValute>();

            var valutes2 = doc2.Element("ValCurs")
                .Elements("Valute");



            foreach(var valute in valutes2)
            {
                valutes.Add(new ClassValute(Convert.ToString(valute.Attribute("ValueID").Value),
                    Convert.ToInt32(valute.Element("NumCode").Value),
                    Convert.ToString(valute.Element("CharCode").Value),
                    Convert.ToInt32(valute.Element("Nominal").Value),
                    Convert.ToString(valute.Element("Name").Value),
                    Convert.ToDouble(valute.Element("Value").Value)
                    ));
            }
    




            // получаем все узлы в виде коллекции XElement
            // используем методы Element и Elements
            XmlDocument doc = new XmlDocument();
            doc.Load("students.xml");

            var root = doc.DocumentElement;

            var first = root.ChildNodes[0]; // или можно использовать root.FirstChild

            Console.WriteLine("Первый узел");
            Console.WriteLine($"Имя: {first.Name}");
            Console.WriteLine($"Количество дочерних элементов: {first.ChildNodes.Count}");
            Console.WriteLine($"Id: {first.Attributes["id"].Value}");

            foreach (XmlNode student in root)
            {
                Console.WriteLine($"Id: {student.Attributes["id"].InnerText}");
                foreach (XmlNode property in student)
                {
                    Console.WriteLine($"{property.Name} : {property.InnerText}");
                }
            }


            Console.ReadKey();
        }
    }
}
