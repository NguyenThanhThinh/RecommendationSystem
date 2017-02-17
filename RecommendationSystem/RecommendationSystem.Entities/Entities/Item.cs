using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationSystem.Entities.Entities
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int item_Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
    }
}
