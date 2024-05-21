using System.Diagnostics;

namespace Nexo.UI.Models.Summary;

[DebuggerDisplay("Title = {Title}, Cover = {Cover}, Tools = {Tools.Count} tools, Points = {Points.Count} points")]
public class Summary
{
    public string? Title { get; set; }
    public string? Cover { get; set; }
    public List<Tool>? Tools { get; set; }
    public List<string>? Points { get; set; }
}
