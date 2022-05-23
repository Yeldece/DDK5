namespace NewsPortal
{
    public class AdminUser : BaseModel
    {
        string _EMail;
        public string EMail { get => _EMail; set => _EMail = value.Trim().ToLower(); }
        string _Password;
        public string Password { get => _Password; set => _Password = NewsHelper.CreateMD5(value); }

    }
}