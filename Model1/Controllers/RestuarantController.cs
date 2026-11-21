using Microsoft.AspNetCore.Mvc;
using Model1.Models;

namespace Model1.Controllers
{
	[ApiController]
	public class RestuarantController(MapDbContext db) : ControllerBase
	{
		[HttpGet("system/api/restuarant/list")]
		public ApiResult List(int pageNum = 1, int pageSize = 10, string? restuarantName = null, string? restuarantType = null)
		{
			var q = db.Restuarant.AsQueryable();

			if (!string.IsNullOrEmpty(restuarantName))
			{
				q = q.Where(x => x.RestaurantName.Contains(restuarantName));
			}
			return ApiResult.Ok();
		}
	}
}
