// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;



string connectionString = @"Data Source=STARSCREAM\SQLEXPRESS;Initial Catalog=Arts;Integrated Security=True;TrustServerCertificate=True";



// Query 1: Recuperare la lista contenente museo, nome opera, nome personaggio degli artisti italiani
string query1 = "SELECT M.MuseumName, AW.Name, C.Name " +
                        "FROM MUSEUM M " +
                        "JOIN ARTWORK AW ON M.Id_Museum = AW.ID_Museum " +
                        "JOIN CHARACTER C ON AW.ID_Character = C.ID_Character " +
                        "JOIN ARTIST A ON AW.ID_Artist = A.Id_Artist " +
                        "WHERE A.Country = 'Italia'";

// Query 2: Recuperare i nomi degli artisti, opere di quali sono conservate a Parigi
        string query2 = "SELECT A.Name, AW.Name " +
                        "FROM ARTIST A " +
                        "JOIN ARTWORK AW ON A.Id_Artist = AW.ID_Artist " +
                        "JOIN MUSEUM M ON AW.ID_Museum = M.Id_Museum " +
                        "WHERE M.City = 'Parigi'";

 // Query 3: Recuperare la città in cui è conservato il quadro "Flora"
        string query3 = "SELECT M.City " +
                        "FROM MUSEUM M " +
                        "JOIN ARTWORK AW ON M.Id_Museum = AW.ID_Museum " +
                        "WHERE AW.Name ='Flora'";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Eseguiamo la prima query
                Console.WriteLine("Query 1:");
                Console.WriteLine();

                using (SqlCommand command = new SqlCommand(query1, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                    
                        while (reader.Read())
                        {
                            Console.WriteLine("Museo: " + reader.GetString(0));
                            Console.WriteLine("Nome opera: " + reader.GetString(1));
                            Console.WriteLine("Nome personaggio: " + reader.GetString(2));
                        }
                
                    
                

                Console.WriteLine();
                Console.WriteLine();

                // Eseguiamo la seconda query
                Console.WriteLine("Query 2:");
                Console.WriteLine();

                using (SqlCommand command = new SqlCommand(query2, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                    
                        while (reader.Read())
                        {
                            Console.WriteLine("Nome artista: " + reader.GetString(0));
                            Console.WriteLine("Nome opera: " + reader.GetString(1));
                        }
                    
                

                Console.WriteLine();
                Console.WriteLine();

                // Eseguiamo la terza query
                Console.WriteLine("Query 3:");

                using (SqlCommand command = new SqlCommand(query3, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                    
                        while (reader.Read())
                        {
                            Console.WriteLine("Città: " + reader.GetString(0));
                        }
                    
                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Si è verificato un errore: " + ex.Message);
        }

        
    
