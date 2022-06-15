using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYT645.Data.DAL;
using RYT645.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RYT645.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
    [HttpGet]
    public List<Product> Get()
        {
            List<Category> categories = _context.Categories.Where(c => c.IsDeleted == false).ToList();         
        }


        [HttpGet("{id}")]
        public List<Product> Get(int id)
        {
            Category category = _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefault(p=>p.Id==id);
            if (category == null) return NotFound();
            
            return StatusCode(200, category);
        }

        [HttpPost("")]
        public List<Product> Create(Category category)
        {
            bool isExistName=_context.Categories.Any(c=> c.Name==category.Name);    

            if (isExistName)
            {
                return BadRequest("Already exist");
            }

            Category newCategory=new Category();
            newCategory.Name = category.Name;
            newCategory.Desc=category.Desc;
            _context.Add(newCategory);
            _context.SaveChanges();
        }
    }
}
