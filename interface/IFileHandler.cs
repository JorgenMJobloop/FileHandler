public interface IFileHandler
{
    public void WriteToFile(string filePath, string content);

    public void ReadFileContent(string filePath);
}