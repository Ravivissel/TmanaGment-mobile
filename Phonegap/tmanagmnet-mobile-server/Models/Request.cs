using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Employees.Models;
/// <summary>
/// Summary description for Request
/// </summary>

namespace Requests.Models
{
    [Table("requests")]
    public class Request
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("title")] public string Title { get; set; }
        [Column("description")] public string Description { get; set; }
        [Column("contact_name")] public string Contact_name { get; set; }
        [Column("contact_phone")] public int Contact_phone { get; set; }
        [Column("created_at")] public DateTime Created_at { get; set; }
        [ForeignKey("employees")] int created_by { get; set; }
        [ForeignKey("employees")] int assign_to { get; set; }
        //public virtual Employee Created_by { get; set; }
        //public virtual Employee Assign_to { get; set; }

    }
}

