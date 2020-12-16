using BlazorServerGridTestApp6.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerGridTestApp6.Components
{
    public partial class MyGridView
    {
        Employee[] employees;

        [Parameter] public Employee[] DataSource { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }

        protected override Task OnParametersSetAsync()
        {
            employees = DataSource;

            return base.OnParametersSetAsync();
        }
    }
}
