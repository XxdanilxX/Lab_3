using System.Xml;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace Lab_3
{
    
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string xml1 = @"<?xml version='1.0' ?>
            <notepad>
                <note id='1' date='12/04/99' time='13:40'>
                    <subject>Важлива ділова зустріч</subject>
                    <importance/>
                    <text>Треба зустрітися з Іваном Івановичем, попередньо зателефонувавши йому за телефоном <tel>123-12-12</tel></text>
                </note>
                <note id='2' date='12/04/99' time='13:58'>
                    <subject>Зателефонувати додому</subject>
                    <text><tel>124-13-13</tel></text>
                </note>
            </notepad>";
            string xml2 = @"<?xml version='1.0'?>
            <firma>
                <personal id='1001'>
                    <firstname>Іван</firstname>
                    <lastname>Іванів</lastname>
                    <nickname>ivanov</nickname>
                    <salary>100000</salary>
                </personal>
                <personal id='2001'>
                    <firstname>Петро</firstname>
                    <lastname>Петрів</lastname>
                    <nickname>petrov</nickname>
                    <salary>200000</salary>
                </personal>
            </firma>";
            Notepad notepad = XmlParser.ParseXml(xml1);
            Console.WriteLine(new string('=', 100));
            Console.WriteLine("1 завдання");          
            foreach (var note in notepad.Notes)
            {
                Console.WriteLine($"ID: {note.Id}");
                Console.WriteLine($"Дата: {note.Date}");
                Console.WriteLine($"Час: {note.Time}");
                Console.WriteLine($"Тема: {note.Subject}");
                Console.WriteLine($"Текст: {note.Text}");
                if (!string.IsNullOrEmpty(note.Telephone))
                {
                    Console.WriteLine($"Телефон: {note.Telephone}");
                }
                if (!string.IsNullOrEmpty(note.Importance))
                {
                    Console.WriteLine($"Важливість: {note.Importance}");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('=', 100));
            Console.WriteLine("2 завдання");
            Console.WriteLine(new string('=', 100));
            Firma firma = XmlParser1.ParseXml(xml2);
            Console.WriteLine("Список працівників у фірмі:");
            foreach (var employee in firma.Employees)
            {
                Console.WriteLine($"ID: {employee.Id}");
                Console.WriteLine($"Ім'я: {employee.FirstName}");
                Console.WriteLine($"Прізвище: {employee.LastName}");
                Console.WriteLine($"Псевдонім: {employee.NickName}");
                Console.WriteLine($"Зарплата: {employee.Salary:C}");
                Console.WriteLine();
            }
            Console.WriteLine(new string('=', 100));
        }
    }
}
