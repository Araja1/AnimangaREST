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
                            manga.Author = reader["Author"].ToString();
                            manga.Price = (float)reader["Price"];
                            manga.Release = reader["Release"].ToString();
                            manga.Edition = (int)reader["Edition"];
                            manga.Cover = new byte[] { (byte)reader["Cover"]};
                            manga.Description = reader["Description"].ToString();
                            manga.Publisher = reader["Publisher"].ToString();
                            manga.Genre = reader["Genre"].ToString();
                            manga.BookNumber = (int)reader["BookNumber"];

                            listOfManga.Add(manga);
                          }
                      }
                  }
              }

              return listOfManga;
          } 
    }
}