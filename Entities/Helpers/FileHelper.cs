namespace EjercicioIntegrador2_YouTify.Helpers
{
    internal class FileHelper
    {
        private const string CONNECTION_STRING_FILE_PATH = "../Files/ConnectionString.txt";
        private const string DEBUG_CONNECTION_STRING_FILE_PATH = "../../../../Entities/Files/ConnectionString.txt";

        internal static string ReadConnectionString()
        {
            string line = "";
            using (StreamReader sr = new StreamReader(DEBUG_CONNECTION_STRING_FILE_PATH))
            {
                line = sr.ReadLine();
            }
            
            return line;
        }

        internal static void WriteToFile(string content, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(content);
            }

        }
    }
}