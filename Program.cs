namespace IO;

class Program
{
    static void Main(string[] args)
    {
        FileHandler fileHandler = new FileHandler();

        fileHandler.WriteToFile("example3.txt", "example 3");
        fileHandler.ReadFileContent("example.txt");
    }
}
