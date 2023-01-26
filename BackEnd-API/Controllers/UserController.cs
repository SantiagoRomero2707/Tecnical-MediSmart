using BackEnd_API.Context;
using BackEnd_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_API.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class UserController : ControllerBase
        {
            private readonly MyDBContext _context;
            public UserController(MyDBContext context)
            {
                _context = context;
            }
            [HttpGet(Name = "GetProducto")]
            public ActionResult<IEnumerable<User>> GetAll()
            {
                return _context.User.ToList();
            }

            [HttpGet("{id}")]
            public ActionResult<User> GetById(int id)
            {
                var user = _context.User.Find(id);
                if (user == null)
                {
                    return NotFound();
                }
                return user;
            }

            [HttpPost]
            public ActionResult<User> Create(User user)
            {
                _context.User.Add(user);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetById), new { id = user.id_user }, user);
            }

            [HttpPut("{id}")]
            public ActionResult Update(int id, User user)
        {
            if (id != user.id_user)
            {
                return BadRequest();
            }
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
       
        }
        [HttpDelete("{id}")]
            public ActionResult<User> Delete(int id)
            {
                var user = _context.User.Find(id);
                if (user == null)
                {
                    return NotFound();
                }
                _context.User.Remove(user);
                _context.SaveChanges();
                return user;
            }
        }
    }
