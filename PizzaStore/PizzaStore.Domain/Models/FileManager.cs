using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaStore.Domain.Models
{
    public class FileManager
    {
        //XML = Extensable Markup Language

        private const string _path=@"data/pizza_store.xml";
        public Order Read()
        {
            var reader = new StreamReader(_path);
            var xml = new XmlSerializer(typeof(Order));
            return xml.Deserialize(reader) as Order;
        }

        public void Write(Order order)
        {
            //create a file
            //open the file with write permissions
            //load content to write
            //convert contect to xml
            //write content to file
            //save and close file

            var writer = new StreamWriter(_path);//can write to a file
            var xml = new XmlSerializer(typeof(Order));//can translate typeof(obj) into xml

            xml.Serialize(writer,order);//opens file, converts orders into xml, writes it to the file, and closes the file.. assuming the file exists
            

        }
    }
}