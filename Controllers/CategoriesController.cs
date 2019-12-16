using System;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Data;

namespace MyLibrary.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController:Controller
    {
        private ICategoryService _service;
        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        //Create/Add a new Category
        [HttpPost("AddCategory")]
        public IActionResult AddCategory([FromBody]Category category)
        {
            try
            {
                if(category.Name != null && category.Description != null)
                {
                    _service.AddCategory(category);
                    return Ok(category);
                }
                return BadRequest("Category was not added");
            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Read all categories
        [HttpGet("[action]")]
        public IActionResult GetCategories()
        {
            var allCategories = _service.GetAllCategories();
            return Ok(allCategories);
        }

        //Update an existing category
        [HttpPut("UpdateCategory/{id}")]
        public IActionResult UpdateCategory(int id, [FromBody]Category category)
        {
            _service.UpdateCategory(id, category);
            return Ok(category);
        }

        //Delete a Category
        [HttpDelete("DeleteCategory/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _service.DeleteCategory(id);
            return Ok();
        }

        //Get a single category by id
        [HttpGet("SingleCategory/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _service.GetCategoryById(id);
            return Ok(category);
        }
    }
}