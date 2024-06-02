using Nexo.UI.Models.Common;

namespace Nexo.UI.Models.Home;

public class SummaryVM : BaseModel
{
    public List<Tool>? Tools { get; set; }
    public List<string>? Points { get; set; }
}
