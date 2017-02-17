using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationSystem.Entities.Entities
{
    public class User_Rating_Average
    {
        [Key, ForeignKey("User")]
        public int user_Id { get; set; }
        public double? Average { get; set; }
        public virtual User User { get; set; }
    }
}
