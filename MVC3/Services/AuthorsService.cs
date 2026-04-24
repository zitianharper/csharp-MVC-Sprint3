using MVC3.Models;
using System.Globalization;
using System.Text.Json;
namespace MVC3.Services
{
    public class AuthorsService 
    {
        public List<Authors> FetchAuthors()
        {
            return AuthorsModel.GetAllAuthors();
        }

        public Authors FetchAuthorsById()
        {
            return AuthorsModel.GetAuthorById();
        }

        public void ModelAddAuthor(string input)
        {
            return AuthorsModel.AddAuthor(input);
        }



    }
}
