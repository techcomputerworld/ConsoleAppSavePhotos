// See https://aka.ms/new-console-template for more information
using ConsoleAppSavePhotos;


string carpeta = "";
var os = Environment.OSVersion;
if (args.Length <= 1)
{
    Console.WriteLine("Hello, this program is copy startup photos, first version for Windows 10 / 11");
    Console.WriteLine("come on copy startup photos on Windows 10/11");
    Console.WriteLine("C:\\Users\\<nombre de usuario>\\AppData\\Local\\ " +
        "Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Assets");
    Console.WriteLine("Press enter to proceed the copy startup photos if you don't want to copy, press another key");
    SavePhotos savePhotos = new SavePhotos();
    carpeta = args[0].ToString();
    if (Console.ReadKey().Key == ConsoleKey.Enter)
    {
        savePhotos.SavePhotoWindows(carpeta);
        Console.WriteLine("Current OS Information: \n");
        Console.WriteLine("Platform: {0:G}", os.Platform);
        Console.WriteLine("Platform: {0:G}", os.VersionString);
        Console.WriteLine("Ok thank you for using the software Save Photos Startup on Windows 10 / 11");
        Console.WriteLine("Created by Techcomputerworld");
        Console.WriteLine("https://techcomputerworld.com");
        Console.Read();
    }
    else
    {
        Console.WriteLine("Are you sure that don't copy your startup photos?");
        Console.WriteLine("could you response: yes or no");
        Console.WriteLine("if press enter for default response is enter.");
        String read = Console.ReadLine();
        if (read == "yes" || read == "")
        {
            
            //detectar en que sistema operativo estamos antes de realizar el proceso.
            
            Console.WriteLine("Current OS Information: \n");
            Console.WriteLine("Platform: {0:G}", os.Platform);
            Console.WriteLine("Platform: {0:G}", os.VersionString);
            savePhotos.SavePhotoWindows(carpeta);
        }
        else if (read == "no")
        {
            Console.WriteLine("Ok thank you for using the software");
            Console.WriteLine("Created by Techcomputerworld");
            Console.WriteLine("https://techcomputerworld.com");

        }
    }
    
}


