using Nexo.UI.Models.Summary;

namespace Nexo.UI.Models;

public class ProjectVM
{
    public string? Type { get; set; }
    public string? Cover { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Tool>? Tools { get; set; }
    public string? Source { get; set; }
    public string? Demo { get; set; }
}
