using System;
namespace NewsPortal
{
    public abstract class BaseModel
    {
        static int counter = 0;
        public readonly int ID;
        public readonly DateTime PublishDate;
    }
}