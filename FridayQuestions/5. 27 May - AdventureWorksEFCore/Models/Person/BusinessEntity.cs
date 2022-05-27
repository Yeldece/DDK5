using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlWithEFCore.Models.Person;
public class BusinessEntity : SqlWithEFCore.Models.BaseModel
{
    [Key]
    public int BusinessEntityID { get; set; }
    [Column(TypeName = "uniqueidentifier")]
    public string rowguid { get; set; }
    {
        get; set;
    }
}