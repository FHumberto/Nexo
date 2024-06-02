using Nexo.UI.Models.Education;
using Nexo.UI.Util;

namespace Nexo.UI.Pages;
public partial class Education
{
    private TitlesVM[]? _titles;
    private CertsVM[]? _certs;

    protected override async Task OnInitializedAsync()
    {
        _titles = await Http.FetchDataAsync<TitlesVM[]>("request/titles.json");
        _certs = await Http.FetchDataAsync<CertsVM[]>("request/certs.json");
    }
}