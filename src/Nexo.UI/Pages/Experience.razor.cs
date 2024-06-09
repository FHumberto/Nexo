using Nexo.UI.Models.Experience;
using Nexo.UI.Util;

namespace Nexo.UI.Pages;

public partial class Experience
{
    private ExpVM[]? _summary;

    protected override async Task OnInitializedAsync() => _summary =
        await Http.FetchDataAsync<ExpVM[]>(
            "https://raw.githubusercontent.com/FHumberto/FHumberto/main/src/data/experience/pro.json");
}