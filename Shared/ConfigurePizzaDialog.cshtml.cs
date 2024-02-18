using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazzingPizza.Shared
{
    public class ConfigurePizzaDialog : PageModel
    {
        private readonly ILogger<ConfigurePizzaDialog> _logger;

        public ConfigurePizzaDialog(ILogger<ConfigurePizzaDialog> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}