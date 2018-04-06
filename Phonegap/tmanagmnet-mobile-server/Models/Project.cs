using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Text;
using Employees.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Project
/// </summary>

namespace Projects.Models
{
    [Table("projects")]
    public class Project
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        private int id;
        [Column("title")] private string title;
        [Column("description")] private string description;
        [Column("priority_key")] private string priority_key; //TODO: change if necessary
        [ForeignKey("requests")] private int request_id;
        [ForeignKey("employees")] private int project_manager;
        [Column("start_date")] private DateTime start_date;
        [Column("end_date")] private DateTime end_date;
        [Column("contact_name")] private string contact_name;
        [Column("contact_phone")] private int contact_phone;
        [Column("modified_at")] private DateTime modified_at;
        [Column("created_at")] private DateTime created_at;
        [ForeignKey("employees")] private int created_by;

        public Project()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public Project(int id, string title, int project_manager, DateTime start_date, DateTime end_date, string contact_name, string priority_key)
        {
            this.id = id;
            this.Title = title;
            this.Project_manager = project_manager;
            this.Start_date = start_date;
            this.End_date = end_date;
            this.Contact_name = contact_name;
            this.Priority_key = priority_key;
        }

        public Project(int id, string title, string description, string priority_key, int request_id, int project_manager, DateTime start_date, DateTime end_date, string contact_name, int contact_phone, DateTime modified_at, DateTime created_at, int created_by)
        {
            Id = id;
            Title = title;
            Description = description;
            Priority_key = priority_key;
            Request_id = request_id;
            Project_manager = project_manager;
            Start_date = start_date;
            End_date = end_date;
            Contact_name = contact_name;
            Contact_phone = contact_phone;
            Modified_at = modified_at;
            Created_at = created_at;
            Created_by = created_by;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Priority_key { get => priority_key; set => priority_key = value; }
        public int Request_id { get => request_id; set => request_id = value; }
        public int Project_manager { get => project_manager; set => project_manager = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
        public string Contact_name { get => contact_name; set => contact_name = value; }
        public int Contact_phone { get => contact_phone; set => contact_phone = value; }
        public DateTime Modified_at { get => modified_at; set => modified_at = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Created_by { get => created_by; set => created_by = value; }
    }
}