using Nexo.UI.Models.Home;
using Nexo.UI.Util;

namespace Nexo.UI.Pages;

public partial class Home
{
    private SummaryVM[]? _summary;
    private ServiceVM[]? _services;

    protected override async Task OnInitializedAsync()
    {
        _summary = await Http.FetchDataAsync<SummaryVM[]>("request/summaries.json");
        _services = await Http.FetchDataAsync<ServiceVM[]>("request/services.json");
    }
}
