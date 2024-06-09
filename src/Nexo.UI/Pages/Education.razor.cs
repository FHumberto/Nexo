using Nexo.UI.Models.Education;
using Nexo.UI.Util;

namespace Nexo.UI.Pages;

public partial class Education
{
    private TitlesVM[]? _titles;
    private CertsVM[]? _certs;

    protected override async Task OnInitializedAsync()
    {
        _titles = await Http.FetchDataAsync<TitlesVM[]>(
            "https://raw.githubusercontent.com/FHumberto/FHumberto/main/src/data/education/titles.json");
        _certs = await Http.FetchDataAsync<CertsVM[]>(
            "https://raw.githubusercontent.com/FHumberto/FHumberto/main/src/data/education/certs.json");
    }
}