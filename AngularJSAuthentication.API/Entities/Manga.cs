using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace AngularJSAuthentication.API.Entities
{
    public class Manga
    {
        [Key]
        public int MId { get; set; }
        [MaxLength(13)]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public string Release { get; set; }
        public int Edition { get; set; }
        public byte[] Cover { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int BookNumber { get; set; }

         public static List<Manga> GetMangas()
          {
              List<Manga> listOfManga = new List<Manga> { };

             using (var connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AngularJSAuth;Integrated Security=True"))
              {
                  connection.Open();
                  string sql = "SELECT * FROM Manga";
                  using (var command = new SqlCommand(sql, connection))
                  {
                      using (var reader = command.ExecuteReader())
                      {
                          while (reader.Read())
                          {
                              var manga = new Manga();
                              manga.MId = (int)reader["MId"];
                            manga.Title = reader["Title"].ToString();
                            manga.ISBN = reader["ISBN"].ToString();
                            //   manga.LastName = reader["LastName"].ToString();
                            //   manga.Age = Convert.ToInt32(reader["Age"]);

                            listOfManga.Add(manga);
                          }
                      }
                  }
              }

              return listOfManga;
          } 
    }
}