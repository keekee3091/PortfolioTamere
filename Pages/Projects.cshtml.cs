using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PortfolioTamere.Models;
using PortfolioTamere.Services;

namespace PortfolioTamere.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly ILogger<ProjectsModel> _logger;
        private readonly ProjectService _projectService;

        public IEnumerable<Project> Projects { get; set; }

        public ProjectsModel(ILogger<ProjectsModel> logger, ProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }

        public void OnGet()
        {
            Projects = _projectService.GetAll();
        }
    }
}
