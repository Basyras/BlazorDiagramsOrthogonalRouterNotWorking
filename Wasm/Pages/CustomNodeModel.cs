using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace Wasm.Pages
{
    public class CustomNodeModel : NodeModel
    {
        public CustomNodeModel(Point position, bool showsTitle) : base(position)
        {
            ShowsTitle = showsTitle;
        }

        public bool ShowsTitle { get; set; }
    }
}
