using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Text;
using WebApplication4.Entities;

namespace WebApplication4.TagHelpers
{
    [HtmlTargetElement("product-list")]

    public class ProductListTagHelper:TagHelper
    {
        public List<Product> Products { get; set; } = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name= "Asus",
                Description= "Computer",
                Price=2900,
                Discount=10,
                ImagePath="https://5.imimg.com/data5/SELLER/Default/2022/1/VH/FF/PH/8118327/asus-rog-strix-g15-2021-g513qc-hn093t-gaming-laptop.png"
            },

            new Product
            { Id = 2,
                Name= "Hp",
                Description= "Computer",
                Price=1200,
                Discount=20,
                ImagePath="https://in-media.apjonlinecdn.com/catalog/product/5/3/533U4PA-1_T1680435823.png"
            },

            new Product
            {
                Id = 3,
                Name= "MacbookPro",
                Description= "Computer",
                Price=3000,
                Discount=10,
                ImagePath="https://www.aptronixindia.com/pub/media/catalog/product/m/b/mbp14-spacegray-select-202110-removebg-preview_2__1.png"
            },

            new Product
            {
                Id = 4,
                Name= "Lenovo",
                Description= "Computer",
                Price=1200,
                Discount=0,
                ImagePath="https://news.lenovo.com/wp-content/uploads/2021/01/Lenovo-Yoga-Slim-7i-Pro-OLED_Front_Facing_Left-e1609862029211.png"
            },

        };

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName= "section";
            var query = Products;

            StringBuilder sb = new StringBuilder();

            foreach (var product in query)
            {
                sb.AppendFormat("<h2><a href='/product/home/{0}'>{1}</a></h2>",product.Id,product.Name);

            }

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
