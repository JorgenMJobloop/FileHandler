public class FileHandler : IFileHandler
{
    public void ReadFileContent(string filePath)
    {
        string text = File.ReadAllText(filePath);
        Console.WriteLine(text);
    }

    public void WriteToFile(string filePath, string content)
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
            return;
        }
        File.WriteAllText(filePath, content);
    }
}