using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace ActualProjectsTasks.Models
{
    [Table("actual_project_task")]
    public class ActualProjectTask

    {
        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       [ Column("project_id")] public int Project { get; set; }
       [ Column("actual_tasks_id")] public int Actual_task { get; set; }
       
    }
    
}
