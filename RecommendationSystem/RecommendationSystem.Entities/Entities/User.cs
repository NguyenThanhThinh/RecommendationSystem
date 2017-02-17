using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationSystem.Entities.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int user_Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public virtual ICollection<Pearson_Score> Pearson_Score_1 { get; set; }
        public virtual ICollection<Pearson_Score> Pearson_Score_2 { get; set; }
        public virtual User_Rating_Average User_Rating_Average { get; set; }
    }
}
