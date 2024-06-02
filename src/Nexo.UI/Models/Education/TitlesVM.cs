using Nexo.UI.Models.Common;

namespace Nexo.UI.Models.Education;

public class TitlesVM : BaseModel
{
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }
    public string? Acronym { get; set; }
    public string? Institution { get; set; }
    public string? Description { get; set; }
    public string? Link { get; set; }
}
