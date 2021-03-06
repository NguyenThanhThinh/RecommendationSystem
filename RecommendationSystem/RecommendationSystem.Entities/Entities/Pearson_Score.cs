﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationSystem.Entities.Entities
{
    public partial class Pearson_Score
    {
        [Key]
        [Column(Order = 0)]
        public int user_Id_1 { get; set; }
        [Key]
        [Column(Order = 1)]
        public int user_Id_2 { get; set; }
        public double? Sim_Pearson_Score { get; set; }
     
        public virtual User User { get; set; }
     
        public virtual User User_1 { get; set; }

     




    }
}
