using Nexo.UI.Models;
using Nexo.UI.Util;

namespace Nexo.UI.Pages;
public partial class Experience
{
    private Exp[]? _summary;

    protected override async Task OnInitializedAsync()
    {
        _summary = await Http.FetchDataAsync<Exp[]>("request/experiences.json");
    }
}