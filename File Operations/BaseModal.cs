using System;
namespace FileOperations
{
    public class BaseModal
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public DateTime AddDate { get; set; } = DateTime.Now;
        public string Name { get; set; }
    }
}