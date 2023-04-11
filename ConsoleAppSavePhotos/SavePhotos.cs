using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSavePhotos
{
    //Clase que usare tanto para Windows 10/11, como para Mac OS X y Ubuntu
    public class SavePhotos
    {
        public string DirectoryWindows { get; set; }
        public string DirecotoryLinux { get; set; }
        public string DirectoryMac { get; set; }
        public void SavePhotoWindows()
        {
            string UserName = Environment.UserName;
            string path1 = Path.GetFullPath("C:\\Users\\" + UserName);
            string path2 = "\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\" +
                "LocalState\\Assets";
            string path3 = Path.GetFullPath(path1 + path2);
            string path4 = "C:\\Users\\" + UserName;
            string path5 = "\\Documents";
            string pathDocuments = Path.GetFullPath(path4);

                
            try
            {
                string[] fileList = Directory.GetFiles(path3);
                foreach (string file in fileList)
                {
                    string file1 = file.ToString();
                    string file2 = file1 + ".jpg";
                    string file3 = Path.GetFileName(file1);
                    string file4 = Path.GetFileName(file2);
                    
                    //quiero cambiar el nombre del fichero pero no sé como hacerlo porque puedo darle a elegir al usuario
                    File.Copy(Path.Combine(path3, file3), Path.Combine(pathDocuments, file4), true);
                }
                Console.WriteLine("images copied successfully");
                
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
