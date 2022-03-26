using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace encryptdata2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var id = Request.Query["id"].ToString();

        var security = new CriptQuery.SecureQueryString(id);

        Response.WriteAsync($"Email: {security["email"].ToString()}");
        Response.WriteAsync($"<br/> Nome: {security["nome"].ToString()}");
        Response.WriteAsync($"<br/> Site: {security["site"].ToString()}");
    }
}