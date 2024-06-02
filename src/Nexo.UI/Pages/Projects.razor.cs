using Nexo.UI.Models;
using Nexo.UI.Util;

namespace Nexo.UI.Pages;
public partial class Projects
{
    private ProjectVM[]? _projectsVMs = [];
    private ProjectVM[]? _projectsVMsToShow = [];

    protected override async Task OnInitializedAsync()
    {
        _projectsVMs = await Http.FetchDataAsync<ProjectVM[]>("request/projects.json");
        _projectsVMsToShow = _projectsVMs;
    }

    private void ShowAllProjects()
    {
        _projectsVMsToShow = _projectsVMs;
    }

    private void ShowWebProjects()
    {
        _projectsVMsToShow = (_projectsVMs?.Where(p => p.Type == "Web").ToArray()) ?? [];
    }

    private void ShowDesktopProjects()
    {
        _projectsVMsToShow = (_projectsVMs?.Where(p => p.Type == "Desktop").ToArray()) ?? [];
    }


    private void ShowGameDevProjects()
    {
        _projectsVMsToShow = (_projectsVMs?.Where(p => p.Type == "GameDev").ToArray()) ?? [];
    }

    private void ShowInfraProjects()
    {
        _projectsVMsToShow = (_projectsVMs?.Where(p => p.Type == "Infra").ToArray()) ?? [];
    }
}