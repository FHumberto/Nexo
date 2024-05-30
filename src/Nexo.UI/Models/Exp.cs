using Nexo.UI.Models.Summary;

namespace Nexo.UI.Models;

public class Exp
{
    public string? Title { get; set; }
    public string? Cover { get; set; }
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }
    public List<Tool>? Tools { get; set; }
    public List<string>? Points { get; set; }
}
