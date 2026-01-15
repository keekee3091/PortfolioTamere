using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioTamere.Services;
using PortfolioTamere.Models;

namespace PortfolioTamere.Pages.Projects
{
    public class DetailsModel : PageModel
    {
        private readonly ProjectService _projectService;

        public Project Project { get; set; }

        public DetailsModel(ProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult OnGet(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            Project = _projectService.GetById(id);

            if (Project == null)
                return NotFound();

            return Page();
        }
    }
}
