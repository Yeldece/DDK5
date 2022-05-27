using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlWithEFCore.Models;
public abstract class BaseModel
{
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; } = DateTime.Now;
}