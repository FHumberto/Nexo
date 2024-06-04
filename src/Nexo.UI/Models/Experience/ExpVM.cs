using Nexo.UI.Models.Common;

namespace Nexo.UI.Models.Experience;

public class ExpVM : BaseModel
{
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }
    public string? Institution { get; set; }
    public List<Tool>? Tools { get; set; }
    public List<string>? Points { get; set; }
}
