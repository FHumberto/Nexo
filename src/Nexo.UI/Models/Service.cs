using System.Diagnostics;

namespace Nexo.UI.Models;

[DebuggerDisplay("Title = {Title}, Icon = {Icon}, Body = {Body}")]
public class Service
{
    public string? Title { get; set; }
    public string? Icon { get; set; }
    public string? Body { get; set; }
}
