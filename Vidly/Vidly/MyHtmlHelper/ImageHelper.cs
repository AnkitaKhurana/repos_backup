using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Vidly.MyHtmlHelper
{
    public static class ImageHelper
    {
        public static MvcHtmlString MyHtmlImageHelper(this HtmlHelper helper, string src, string altText, string sides)
        {
            var myTag = new TagBuilder("img");
            myTag.MergeAttribute("src", src);
            myTag.MergeAttribute("alt", altText);
            myTag.MergeAttribute("height", sides);
            myTag.MergeAttribute("width", sides);       
            return MvcHtmlString.Create(myTag.ToString(TagRenderMode.SelfClosing));
        }
    }
}