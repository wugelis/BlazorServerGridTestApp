using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerGridTestApp6.Components
{
    public class MyButton2: ComponentBase
    {
        [Parameter] public string ButtonText { get; set; }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            //builder.AddAttribute(7, "onclick", OnClickCallback);
            builder.AddAttribute(7, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, Button_Click));
            builder.AddContent(8, ButtonText);
            builder.CloseElement();
        }

        int current = 0;
        private string _buttonText;

        private void Button_Click()
        {
            current++;

            ButtonText = "";

            string buttonText = _buttonText;

            ButtonText = $"{buttonText} {current}";
        }

        protected override Task OnParametersSetAsync()
        {
            _buttonText = ButtonText;

            return base.OnParametersSetAsync();
        }
    }
}
