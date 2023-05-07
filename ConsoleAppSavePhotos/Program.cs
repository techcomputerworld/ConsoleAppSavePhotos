// See https://aka.ms/new-console-template for more information
using ConsoleAppSavePhotos;


class program
{
    
    static void Main(string[] args)
    {
        string carpeta = "";
        var os = Environment.OSVersion;
        Hello hello = new Hello();
        SavePhotos savePhotos = new SavePhotos();
        if (args.Length == 0)
        {
            hello.Welcome();
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                savePhotos.SavePhotoWindows();
                Console.WriteLine("Current OS Information: \n");
                Console.WriteLine("Platform: {0:G}", os.Platform);
                Console.WriteLine("Platform: {0:G}", os.VersionString);
                Console.WriteLine("Ok thank you for using the software");
                Console.WriteLine("Created by Techcomputerworld");
                Console.WriteLine("https://techcomputerworld.com");
            }
            else
            {
                OtherKey();
            }

        }

        if (args.Length == 1)
        {


            hello.Welcome();
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
                
            }
            else
            {
                OtherKey();
            }

        }

    } //final metodo main
    static void OtherKey()
    {
        SavePhotos savePhotos = new SavePhotos();
        var os = Environment.OSVersion;
        string carpeta = "";

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



