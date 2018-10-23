using Microsoft.AspNetCore.Razor.TagHelpers;
using System;


namespace TagHelperHW
{
    [HtmlTargetElement("input")]
    public class AutoCompleteMine : TagHelper
    {
        [HtmlAttributeName("my-auto-complete")]
        public string AutoComp { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (AutoComp == "disabled" || AutoComp == "off" || AutoComp == "false")
            {
                output.Attributes.SetAttribute("autocomplete", "off");
            }
            else if (AutoComp == "enabled" || AutoComp == "on" || AutoComp == "true")
            {
                output.Attributes.SetAttribute("autocomplete", "on");
            }
        }
        
    }
}
