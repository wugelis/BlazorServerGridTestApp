using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerGridTestApp6.Components
{
    public class MyButton: ComponentBase
    {
        [Parameter] public string ButtonText { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, $"<button class=\"btn btn-primary\">{ButtonText}</button>");
        }
    }
}
