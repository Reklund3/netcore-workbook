using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using TagHelpers.Tests.Infrastructure;
using Xunit;

namespace TagHelpers.Test
{
    public class DayOfTheWeekTagHelperTests : BaseTagHelperTest
    {
        [Fact]
        public void TagHelper_ShouldDisplayMMddyyyyForDates7DaysOrFurtherInTheFuture()
        {
            //Assemble
            var value = DateTime.Now.AddDays(7);
            var tagHelper = new DayOfTheWeekTagHelper();
            tagHelper.For = GetModelExpression(value);
            
            TagHelperAttributeList attributes = new TagHelperAttributeList
            {
                new TagHelperAttribute("asp-for", value),
                new TagHelperAttribute("day-of-week")
            };
            TagHelperContext context = null;
            TagHelperOutput output = new TagHelperOutput("span", attributes, BlankContent);
            // Act
            tagHelper.Process(context, output);
            //assert
            Assert.Equal(value.ToString("MM/dd/yyyy"), output.Content.GetContent());
        }
    }
}
