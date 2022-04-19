using CSharpOOP.BlogSample;
namespace NewsPortal
{
    public class AdminUser : BaseModel
    {
        string _EMail;
        public string EMail { get => _EMail; set => _EMail = value.ToLower(); }
        string _Password;
        public string Password { get => _Password; set => _Password = BlogHelper.CreateMD5(value); }

    }
}