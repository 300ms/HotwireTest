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

        public PartialViewResult SectionOne()
        {
	        return Partial("_SectionOne", this);
        }

        public PartialViewResult SectionTwo()
        {
	        return Partial("_SectionTwo", this);
        }

        public PartialViewResult SectionThree()
        {
	        return Partial("_SectionThree", this);
        }

        public PartialViewResult SectionFour()
        {
	        return Partial("_SectionFour", this);
        }
	}
}