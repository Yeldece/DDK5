using System;
namespace NewsPortal
{
    public class News : BaseModel
    {
        public string Content { get; set; }

        string _SubContent;
        public string SubContent { get; init; }

        public AdminUser Admin = new AdminUser();

        string _Title;
        public string Title { get { return _Title; } set { _Title = NewsHelper.TitleCapitalize(value); } }


        public News(string title, string content)
        {
            Title = title;
            Content = content;
            if (content?.Length < 100)
            {
                SubContent = content;
            }
            else
            {
                SubContent = content[0..100];
            }

        }
    }
}