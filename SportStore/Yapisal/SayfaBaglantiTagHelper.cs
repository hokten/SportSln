using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportStore.Models.ViewModels;


namespace SportStore.Yapisal
{
    [HtmlTargetElement("div", Attributes = "sayfa-model")]

    public class SayfaBaglantiTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public SayfaBaglantiTagHelper(IUrlHelperFactory urlFact)
        {
            urlHelperFactory = urlFact;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        public SayfalamaBilgi SayfaModel { get; set; }
        public string SayfaEylemi { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(viewContext);
            TagBuilder result = new TagBuilder("div");
            for(int i=1; i<= SayfaModel.ToplamSayfaSayisi; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(SayfaEylemi, new { urunSayfasi = i });
                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);
            }
            output.Content.AppendHtml(result.InnerHtml);
        }



    }
}
