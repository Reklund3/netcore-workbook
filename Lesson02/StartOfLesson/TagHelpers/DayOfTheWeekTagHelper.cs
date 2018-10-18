﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Linq;

namespace TagHelpers
{
    [HtmlTargetElement("*" , Attributes = "day-of-week")]
    public class DayOfTheWeekTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var value = For.Model as DateTime?;
            var now = DateTime.Now;
            if (value.HasValue)
            {
                if (value > now && value < now.AddDays(7))
                {
                    output.Attributes.Add(new TagHelperAttribute("aria-valuetext,", value.Value.ToString("D")));
                    output.Content.SetContent(value.Value.DayOfWeek.ToString());
                }
                else
                {
                    output.Content.SetContent(value.Value.ToString("MM/dd/yyyy"));
                }
                var day = output.Attributes.FirstOrDefault(x => x.Name == "day-of-week");
                output.Attributes.Remove(day);
            }
        }
    }
}
