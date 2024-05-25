using Nexo.UI.Models.Education;
using Nexo.UI.Util;

namespace Nexo.UI.Pages;
public partial class Education
{
    private Titles[]? _titles;
    private Certs[]? _certs;

    protected override async Task OnInitializedAsync()
    {
        _titles = await Http.FetchDataAsync<Titles[]>("request/titles.json");
        _certs = await Http.FetchDataAsync<Certs[]>("request/certs.json");
    }
}