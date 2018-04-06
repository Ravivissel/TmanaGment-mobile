using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using Employees.Models;

namespace ActualTasks.Models
{

    [Table("actual_tasks")]
    public class ActualTask
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("description")] public string Description { get; set; }
        [Column("title")] public string Title { get; set; }
        [Column("start_date")] public System.DateTime Start_date { get; set; }
        [Column("start_date")] public System.DateTime End_date { get; set; }
        [ForeignKey("employees")] public int Created_by { get; set; }
        [ForeignKey("employees")] public int Assign_to { get; set; }
    }
}