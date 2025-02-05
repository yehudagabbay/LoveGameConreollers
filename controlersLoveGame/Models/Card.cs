using System.ComponentModel.DataAnnotations;

namespace controlersLoveGame.Models
{
    public class Card
    {
        [Key]
        public int CardID { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public int LevelID { get; set; }

        [Required]
        public string CardDescription { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
