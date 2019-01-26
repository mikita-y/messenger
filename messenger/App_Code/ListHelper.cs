using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace messenger.App_Code
{
    public static class ListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, string items)
        {
            string result = "<ul>";
            foreach (char item in items)
            {
                result += $"<li>{item}</li>";
            }
            result += "</ul>";
            return new HtmlString(result);
        }

    }
}
