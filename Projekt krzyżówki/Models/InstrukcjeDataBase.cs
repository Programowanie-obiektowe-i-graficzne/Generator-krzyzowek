using System.Collections.ObjectModel;
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
        public ObservableCollection<Pytania> ReadPytania()
        {
            ObservableCollection<Pytania> pytania = new ObservableCollection<Pytania>();
            using (conn)
            {
                conn.Open();
                string sql = "Select * from Pytania";
                using (SQLiteCommand com = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pytania pyt = new Pytania();
                            pyt.IdPytania = reader.GetInt32(0);
                            pyt.Tresc = reader.GetString(1);
                            pyt.Trudnosc = reader.GetInt32(2);
                            pyt.Id_Odpowiedzi = reader.GetInt32(3);
                            pytania.Add(pyt);

                        }
                    }
                }
                conn.Close();
            }
            return pytania;
        }

        public ObservableCollection<Slowa> ReadSlowa()
        {
            ObservableCollection<Slowa> slowa = new ObservableCollection<Slowa>();
            using (conn)
            {
                conn.Open();
                string sql = "Select * from Slowa";
                using (SQLiteCommand com = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Slowa slow = new Slowa();
                            slow.IdSlowa = reader.GetInt32(0);
                            slow.Nazwa = reader.GetString(1);
                            slow.Kategoria = reader.GetString(2);
                            slow.Podkategoria = reader.GetInt32(3);
                            slow.Anagram = reader.GetBoolean(4);
                            slowa.Add(slow);
                        }
                    }
                }
                conn.Close();
            }
            return slowa;
        }

        public void InsertWord(Slowa s)
        {
            using (conn)
            {
                conn.Open();
                string sql = "Insert into Slowa (IdSlowa, Nazwa, Kategoria, Podkategoria, Anagram) values (@IdSlowa, @Nazwa, @Kategoria, @Podkategoria, @Anagram);";
                using (SQLiteCommand com = new SQLiteCommand(sql, conn))
                {
                    com.Parameters.AddWithValue("@IdSlowa", s.IdSlowa);
                    com.Parameters.AddWithValue("@Nazwa", s.Nazwa);
                    com.Parameters.AddWithValue("@Kategoria", s.Kategoria);
                    com.Parameters.AddWithValue("@Podkategoria", s.Podkategoria);
                    com.Parameters.AddWithValue("@Anagram", s.Anagram);
                    com.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void InsertQuestion(Pytania p)
        {
            using (conn)
            {
                string sql = "INSERT INTO Pytanie (IdPytania, Tresc, Trudnosc, Kategoria, Id_Odpowiedzi) VALUES (@IdPytania, @Tresc, @Trudnosc, @Kategoria, @Id_Odpowiedzi);";
                using (SQLiteCommand com = new SQLiteCommand(sql, conn))
                {
                    com.Parameters.AddWithValue("@IdPytania", p.IdPytania);
                    com.Parameters.AddWithValue("@Tresc", p.Tresc);
                    com.Parameters.AddWithValue("@Trudnosc", p.Trudnosc);
                    com.Parameters.AddWithValue("@Kategoria", p.Kategoria);
                    com.Parameters.AddWithValue("@Id_Odpowiedzi", p.Id_Odpowiedzi);
                    com.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
