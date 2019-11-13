using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataApi.DbConn;
using DataApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
	    private MongoCRUD _db;
	    private string table = "Users";
	    public UsersController(MongoCRUD db)
	    {
		    _db = db;
	    }

		[HttpGet]
		public async Task<User[]> GetAll() {
			return (await _db.LoadRecords<User>(table)).ToArray();
		}
    }
}