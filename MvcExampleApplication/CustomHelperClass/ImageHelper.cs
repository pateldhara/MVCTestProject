using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExampleApplication.CustomHelperClass
{
    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string source , string altText)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src ", source);
            builder.MergeAttribute("alt", altText);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}