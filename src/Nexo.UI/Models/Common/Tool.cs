using System.Diagnostics;

namespace Nexo.UI.Models.Common;

[DebuggerDisplay("Name = {Name}, Icon = {Icon}")]
public class Tool
{
    public string? Icon { get; set; }
    public string? Name { get; set; }
}