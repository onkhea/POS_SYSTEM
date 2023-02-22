using System.Data;
using System.Xml;

namespace POS.Utilities
{
    class XMLFLA
    {
        public void Write(string path,DataTable dataTable)
        {
            var writer = new XmlTextWriter(@path,
                                           System.Text.Encoding.UTF8);
                                    writer.WriteStartElement("photos");
                                    writer.WriteStartAttribute("path");
                                    writer.WriteValue(@"images/");
            for (int i = dataTable.Rows.Count; i >= 1 ; i--)
            {
                writer.WriteStartElement("photo");
                writer.WriteStartAttribute("url");
                writer.WriteValue(dataTable.Rows[i-1][0].ToString() + ".jpg");
                var ddd = dataTable.Rows[i - 1][0].ToString();
                writer.WriteFullEndElement();
            }
                                        
            writer.WriteEndElement();
                                    // Flush
            writer.Flush();
                                    //Write the XML to file and close the writer
            writer.Close();
        }
    }
}
