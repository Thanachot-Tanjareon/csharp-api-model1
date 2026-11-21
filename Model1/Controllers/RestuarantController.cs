using Microsoft.AspNetCore.Mvc;
using Model1.Models;

namespace Model1.Controllers
{
	[ApiController]
	public class RestuarantController(MapDbContext db) : ControllerBase
	{
		[HttpGet("system/api/restuarant/list")]
		public ApiResult List()
		{

		}
	}
}
