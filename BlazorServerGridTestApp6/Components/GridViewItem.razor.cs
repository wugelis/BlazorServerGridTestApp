using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerGridTestApp6.Components
{
    public partial class GridViewItem
    {
        [Parameter] public string ColumnName { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
