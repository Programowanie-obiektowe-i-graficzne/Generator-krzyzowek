using System.Data.SQLite;
namespace Projekt_krzyżówki.Models
{
    public class InstrukcjeDataBase
    {
        static string FindSolutionFilePath(string directory) {                                                    
            while (!string.IsNullOrEmpty(directory))
            {
                string[] solutionFiles = Directory.GetFiles(directory, "*.db");
                if (solutionFiles.Length > 0)
                {
                    return solutionFiles[0];
                }
                directory = Directory.GetParent(directory)?.FullName;
            }
            return null;
        }
        static string datasource = "Datasource=" + FindSolutionFilePath(Directory.GetCurrentDirectory()) + ";Version=3";
        SQLiteConnection conn = new SQLiteConnection(datasource);
        public void ReadDataBase()
        {

        }
        public void AddQuestion()
        {

        }
        public void AddAnswer()
        {

        }
        public void AddAnagram()
        {

        }
    }
}
