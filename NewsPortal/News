using System;
using CSharpOOP.BlogSample;
namespace NewsPortal
{
    public class News : BaseModel
    {
        public string Content { get; set; }
        public readonly string SubContent;
        public AdminUser Admin = new AdminUser();
        string _Title;
        public string Title { get { return _Title; } set { _Title = BlogHelper.TitleCapitalize(value); } }

    }
}