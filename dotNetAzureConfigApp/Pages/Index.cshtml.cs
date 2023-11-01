using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace dotNetAzureConfigApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        IConfiguration _configuration;
        public Settings Settings { get; }

        public IndexModel(ILogger<IndexModel> logger,IConfiguration configuration, IOptionsSnapshot<Settings> options)
        {
            _logger = logger;
            _configuration = configuration;
            string configvalue = _configuration["config1"];
            Settings = options.Value;

        }

        public void OnGet()
        {

        }
    }
}