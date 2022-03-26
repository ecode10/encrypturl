using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace encryptdata2.Pages;

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

    public void OnPost()
    {
        //preparing data
        var security = new CriptQuery.SecureQueryString();
        security["email"] = "eu@mauriciojunior.net";
        security["nome"] = "Mauricio Junior";
        security["site"] = "https://mauriciojunior.net";
        
        //send to page 2
        Response.Redirect("Privacy?id=" + security.ToString());
    }
}