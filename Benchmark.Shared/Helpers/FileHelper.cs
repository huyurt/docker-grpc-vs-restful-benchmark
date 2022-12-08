namespace Benchmark.Shared.Helpers
{
    public class FileHelper
    {
        public static async Task<byte[]> GetFile(string path, string fileName)
        {
            return await System.IO.File.ReadAllBytesAsync(GetFilePath(path, fileName));
        }

        public static async Task<string> GetFileContent(string path, string fileName)
        {
            return await System.IO.File.ReadAllTextAsync(GetFilePath(path, fileName));
        }

        private static string GetFilePath(string path, string fileName)
        {
            return $@"{Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)}/{path}{fileName}";
        }
    }
}
