using Nexo.UI.Models;
using Nexo.UI.Models.Summary;
using Nexo.UI.Util;

namespace Nexo.UI.Pages;

public partial class Home
{
    private Summary[]? _summary;
    private Service[]? _services;

    protected override async Task OnInitializedAsync()
    {
        _summary = await Http.FetchDataAsync<Summary[]>("request/summaries.json");
        _services = await Http.FetchDataAsync<Service[]>("request/services.json");
    }
}
