using Nexo.UI.Models.Common;

namespace Nexo.UI.Models;

public class ProjectVM : BaseModel
{
    public string? Type { get; set; }
    public string? Description { get; set; }
    public List<Tool>? Tools { get; set; }
    public string? Source { get; set; }
    public string? Demo { get; set; }
}
