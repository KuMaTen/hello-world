using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _3使用XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test2();
            DelayTimeMethod(1);
            Console.ReadKey();
        }

        public static void Test2()
        {
            XmlDocument doc=new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "John";
            order.AppendChild(customerName);

            XmlElement customerNumber = doc.CreateElement("CustomerNumber");
            customerNumber.InnerText = "10001";
            order.AppendChild(customerNumber);

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem1.SetAttribute("Name", "雨衣1");
            orderItem1.SetAttribute("Count", "100");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem2.SetAttribute("Name", "雨衣2");
            orderItem2.SetAttribute("Count", "200");
            items.AppendChild(orderItem2);

            XmlElement orderItem3 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem3.SetAttribute("Name", "雨衣3");
            orderItem3.SetAttribute("Count", "300");
            items.AppendChild(orderItem3);

            doc.Save("Orders.xml");
            Console.WriteLine("保存成功");
        }

        public static void Test1()
        {
            //通过代码创建XML文档
            //1 命名空间
            //2 创建XML文档对象
            XmlDocument doc = new XmlDocument();
            //3 创建第一行描述信息,添加到doc文档
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //4 创建根节点
            XmlElement books = doc.CreateElement("Books");
            doc.AppendChild(books);

            XmlElement book1 = doc.CreateElement("book1");
            book1.InnerText = "Hello";
            //book1.in
            books.AppendChild(book1);

            doc.Save("Book.xml");
            Console.WriteLine("保存成功");
        }

        public static void DelayTimeMethod(float i)
        {
            DateTime dtstart_0 = DateTime.Now;
            while (true)
            {
                TimeSpan span = new TimeSpan();
                span = DateTime.Now - dtstart_0;
                Console.WriteLine(span.Milliseconds);
                if (span.Seconds >= i)
                    break;
            }
        }
    }
}
