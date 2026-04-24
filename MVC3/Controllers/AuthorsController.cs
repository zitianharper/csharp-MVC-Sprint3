using Microsoft.AspNetCore.Mvc;
using MVC3.Services;

namespace MVC3.Controllers
{
    [ApiController]
    [Route("[authors]")]
    public class AuthorsController : Controller
    {

        //[HttpGet("{books}")]
        //public IActionResult GetBooks()
        //{
        //    var books = BooksService.FetchBooks();
        //    return Ok(books);
        //}

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = AuthorsService.FetchAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorById()
        {
            var authors = AuthorsService.FetchAuthorsById();
            return Ok(authors);
        }

        [HttpPost()]
        public IActionResult PostAuthor()
        {
            var authors = AuthorsService.something here but what???

                return Results.Created();
        }
    }
}
