using Nexo.UI.Models.Common;

namespace Nexo.UI.Models.Education;

public class CertsVM : BaseModel
{
    public string? EndDate { get; set; }
    public string? Institution { get; set; }
    public string? Instructor { get; set; }
    public string? Link { get; set; }
}
