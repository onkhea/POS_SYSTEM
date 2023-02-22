using System.IO;
using POS.DataLayer;

namespace POS.Utilities
{
    class Images
    {
       public void Create(string sqlCommand , string path,  string fileName)
       {
           var dataManagea = new DataManager();
           var dt = dataManagea.GetData(sqlCommand);
               var b = (byte[])dt.Rows[0][0];
               var file = @path + fileName + ".jpg";
           if (File.Exists(file) == true)
           {
               File.Delete(file);
           }
               var fs = new FileStream(file, FileMode.CreateNew, FileAccess.ReadWrite);
               fs.Write(b, 0, b.Length - 1);
               fs.Flush();
               fs.Close();
       }
    }
}
