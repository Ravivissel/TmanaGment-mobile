using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Requests.Models;

/// <summary>
/// Summary description for Employee
/// </summary>
///
namespace Employees.Models
{
    [ComplexType]
    [Table("employees")]
    public class Employee
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        private int id;
        [Column("first_name")] private string first_name;
        [Column("last_name")] private string last_name;
        [Column("phone_num")] private int phone_num;
        [Column("title")] private string title;
        [Column("user_name")] private string user_name;
        [Column("password")] private string password;
        [Column("user_type")] private string user_type;

        public int Id { get => id; set => id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public int Phone_num { get => phone_num; set => phone_num = value; }
        public string Title { get => title; set => title = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Password { get => password; set => password = value; }
        public string User_type { get => user_type; set => user_type = value; }
       // public ICollection<Request> Request { get; set; }

    }
}