using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSavePhotos
{
    //Clase que usare tanto para Windows 10/11, como para Mac OS X y Ubuntu
    public class SavePhotos
    {
        public string PathStartupPhotos { get; set; }
        public string PathUser { get; set; }
        public string FileStartupPhoto { get; set; }
        public string FileUserPhoto { get; set; }
        //string carpeta va a ser para decir a que carpeta vamos a copiar todas las fotos
        //este metodo para uan aplicación de consola
        public void SavePhotoWindows(string carpeta)
        {
            string userName = Environment.UserName;
            PathStartupPhotos = Path.GetFullPath("C:\\Users\\" + userName + "\\AppData\\Local\\Packages"
                + "\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\" +
                 "LocalState\\Assets");
            PathUser = Path.GetFullPath("C:\\Users\\" + userName);
            if (carpeta == "documents")
            {
                PathUser = Path.GetFullPath("C:\\Users\\" + userName + "\\Documents");
            }
            else if (carpeta == "Downloads")
            {
                PathUser = Path.GetFullPath("C:\\Users\\" + userName + "\\Downloads");
            }
            else
            {
                PathUser = Path.GetFullPath("C:\\Users\\" + userName + "\\" + carpeta);

            }
            //comprobar que existe el directorio
            try
            {
                DirectoryInfo directory = new DirectoryInfo(PathUser);
                if (!directory.Exists)
                {
                    Directory.CreateDirectory(PathUser);
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                string[] fileList = Directory.GetFiles(PathStartupPhotos);
                foreach (string file in fileList)
                {
                    FileStartupPhoto = Path.GetFileName(file.ToString());
                    FileUserPhoto = Path.GetFileName(FileStartupPhoto + ".jpg");
                    //
                    //quiero cambiar el nombre del fichero pero no sé como hacerlo porque puedo darle a elegir al usuario
                    File.Copy(Path.Combine(PathStartupPhotos, FileStartupPhoto), Path.Combine(PathUser, FileUserPhoto), true);
                }
                Console.WriteLine("images copied successfully");
                
            } 
            catch (Exception e)
            {
                //Console.WriteLine(ex.Message);
                string exception = e.ToString();
            }
        }
    }
}
