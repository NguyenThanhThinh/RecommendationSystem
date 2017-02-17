using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationSystem.Entities.Entities
{
    class User_Item_Rating
    {
        [Key]
        [Column(Order = 0)]
        public int user_Id { get; set; }
        [Key]
        [Column(Order = 1)]
        public int item_Id { get; set; }
        public double? Rating { get; set; }
        public virtual Item Item { get; set; }
        public virtual User User { get; set; }
    }
}
