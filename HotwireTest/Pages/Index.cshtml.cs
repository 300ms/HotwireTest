using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotwireTest.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}

		public PartialViewResult OnGetSectionOne()
		{
			return Partial("IndexPages/_Section1", this);
		}

		public PartialViewResult OnGetSectionTwo()
		{
			return Partial("IndexPages/_Section2", this);
		}

		public PartialViewResult OnGetSectionThree()
		{
			return Partial("IndexPages/_Section3", this);
		}

		public PartialViewResult OnGetSectionFour()
		{
			return Partial("IndexPages/_Section4", this);
		}
	}
}