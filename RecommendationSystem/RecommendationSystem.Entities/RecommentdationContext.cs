using RecommendationSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationSystem.Entities
{
    class RecommentdationContext : DbContext
    {
        public RecommentdationContext() : base("Recommentdation")
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User_Item_Rating> User_item_Ratings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Rating_Average> User_Rating_Averages { get; set; }
        public DbSet<Pearson_Score> Pearson_Score { get; set; }
    }
}
