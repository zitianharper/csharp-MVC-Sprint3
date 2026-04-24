
using MVC3.Services;
using System.Text.Json;

namespace MVC3.Models
{
    public class AuthorsModel
    {

        public static List<Authors> GetAllAuthors()
        {
            string GetPath(string fileYouWant)
            {
                string pathTo = Path.Combine(AppContext.BaseDirectory, "Resources", $"{fileYouWant}.json");
                string item = File.ReadAllText(pathTo);
                return item;
            }
            var AuthorList = JsonSerializer.Deserialize<List<Authors>>(GetPath("Authors"));


            return AuthorList;
        }

        public static Authors GetAuthorById()
        {
            string GetPath(string fileYouWant)
            {
                string pathTo = Path.Combine(AppContext.BaseDirectory, "Resources", $"{fileYouWant}.json");
                string item = File.ReadAllText(pathTo);
                return item;
            }

            var AuthorById = JsonSerializer.Deserialize<Authors>(GetPath("Authors"));

            return AuthorById;

        }

        public static void AddAuthor(string input)
        {
            //Deseralize json
            string GetPath(string fileYouWant)
            {
                string pathTo = Path.Combine(AppContext.BaseDirectory, "Resources", $"{fileYouWant}.json");
                string item = File.ReadAllText(pathTo);
                return item;
            }
            var AuthorList = JsonSerializer.Deserialize<List<Authors>>(GetPath("Authors"));


            //Post new author
            Authors newAuthor = JsonSerializer.Deserialize<Authors>(input);

            int newAuthorId = AuthorList[AuthorList.Count() - 1].Id + 1;

            newAuthor.Id = newAuthorId;

            AuthorList.Add(newAuthor);
            //Serialize into json

            var outputString = JsonSerializer.Serialize<List<Authors>>(AuthorList);

            File.WriteAllText(Path.Combine(AppContext.BaseDirectory, "Resources", "Authors.json"),
            JsonSerializer.Serialize(outputString)
            );
        }

    }
}
