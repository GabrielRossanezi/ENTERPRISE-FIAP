using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.TagHelpers
{
    public class BotaoTagHelper : TagHelper
    {
        public string Texto { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";
            output.Attributes.SetAttribute("class", "btn btn-primary");
            output.Attributes.SetAttribute("type", "submit");
            output.Attributes.SetAttribute("value", Texto);
        }
    }
}
