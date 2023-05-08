// See https://aka.ms/new-console-template for more information
using ConsoleAppSavePhotos;
using System.Diagnostics.Tracing;

class program
{
    //static SavePhotos savePhotos { get; set; }
    static OperatingSystem os { get; set; }
    static string folder { get; set; }
    static void Main(string[] args)
    {
        string folder = "";
        os = Environment.OSVersion;
        Hello hello = new Hello();
        
        if (args.Length == 0)
        {
            hello.Welcome();
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                KeyEnter();
            }
            else
            {
                OtherKey();
            }

        }

        if (args.Length == 1)
        {


            hello.Welcome();
            folder = args[0].ToString();
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                KeyEnter();
                
            }
            else
            {
                OtherKey();
            }

        }

    } //final metodo main
    static void KeyEnter()
    {
        SavePhotos savePhotos = new SavePhotos();
        savePhotos.SavePhotoWindows();
        os = Environment.OSVersion;
        Console.WriteLine("Current OS Information: \n");
        Console.WriteLine("Platform: {0:G}", os.Platform);
        Console.WriteLine("Platform: {0:G}", os.VersionString);
        Console.WriteLine("Ok thank you for using the software");
        Console.WriteLine("Created by Techcomputerworld");
        Console.WriteLine("https://techcomputerworld.com");
    }
    static void OtherKey()
    {
        SavePhotos savePhotos = new SavePhotos();
        os = Environment.OSVersion;
        folder = "";

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
            savePhotos.SavePhotoWindows(folder);
        }
        else if (read == "no")
        {
            Console.WriteLine("Ok thank you for using the software");
            Console.WriteLine("Created by Techcomputerworld");
            Console.WriteLine("https://techcomputerworld.com");

        }
    }
}



