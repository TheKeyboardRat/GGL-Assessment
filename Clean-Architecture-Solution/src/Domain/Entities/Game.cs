using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Game
    {
        [Key]
        public int id { get; set; }
        public string? game_title { get; set; }
        public string? genre { get; set; }
        public string? platform { get; set; }
        public string? release_date { get; set; }
        public double rating { get; set; }
        public double price { get; set; }
        public string? image_url { get; set; }
        public string? description { get; set; }
        public string? studio_name { get; set; }
    }
}
