using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationSystem.Entities.Entities
{
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public virtual ICollection<Pearson_Score> Pearson_Score { get; set; }
        public virtual ICollection<Pearson_Score> Pearson_Score1 { get; set; }
        public virtual User_Rating_Average User_Rating_Average { get; set; }
       
    }
}
