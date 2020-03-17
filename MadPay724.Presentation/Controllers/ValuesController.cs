using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MadPay724.Data.DatabaseContext;
using MadPay724.Data.Infrastructure;
using MadPay724.Data.Models;

namespace MadPay724.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork<MadpayDbContext> _db;
        public ValuesController(IUnitOfWork<MadpayDbContext> dbcontext)
        {
            _db = dbcontext;
        }  
        
        
        // GET: api/Values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            //var user = new User()
            //{
            //    Address="",
            //    City="",
            //    DateofBirth="",
            //    Gender="",
            //    IsActive=true,
            //    Name="",

            //    PasswordHash=new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 },
            //    PasswordSalt= new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 },

            //    PhoneNumber="",
            //    Status=true,
            //    UserName=""
            //};
            //await _db.UserRepository.InsertAsync(user);
            //await _db.SaveAsync();
            //var model = await _db.UserRepository.GetAllAsync();
            return Ok("ok");
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        [HttpPost]
        public async Task<string> Post([FromBody] string value)
        {
            return null;
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public async Task<string> Put(int id, [FromBody] string value)
        {
            return null;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return null;
        }
    }
}
