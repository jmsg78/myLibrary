using System;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Data;

namespace MyLibrary.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController:Controller
    {
        private IAuthorService _service;
        public AuthorsController(IAuthorService service)
        {
            _service = service;
        }

        //Create/Add a new Author
        [HttpPost("AddAuthor")]
        public IActionResult AddAuthor([FromBody]Author author)
        {
            try
            {
                if(author.FirstName != null && author.LastName != null)
                {
                    _service.AddAuthor(author);
                    return Ok(author);
                }
                return BadRequest("Author was not added");
            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Read all Authors
        [HttpGet("[action]")]
        public IActionResult GetAuthors()
        {
            var allAuthors = _service.GetAllAuthors();
            return Ok(allAuthors);
        }

        //Update an existing Author
        [HttpPut("UpdateAuthor/{id}")]
        public IActionResult UpdateAuthor(int id, [FromBody]Author author)
        {
            _service.UpdateAuthor(id, author);
            return Ok(author);
        }

        //Delete a Author
        [HttpDelete("DeleteAuthor/{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            _service.DeleteAuthor(id);
            return Ok();
        }

        //Get a single Author by id
        [HttpGet("SingleAuthor/{id}")]
        public IActionResult GetAuthorById(int id)
        {
            var author = _service.GetAuthorById(id);
            return Ok(author);
        }
    }
}