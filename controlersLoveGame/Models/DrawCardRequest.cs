using System.ComponentModel.DataAnnotations;

namespace controlersLoveGame.Models
{
    public class DrawCardRequest
    {
        [Required]
        public List<CategoryLevelSelection> Selections { get; set; } // רשימת הבחירות

        public class CategoryLevelSelection
        {
            public int CategoryID { get; set; } // מזהה הקטגוריה (סגנון)
            public int LevelID { get; set; } // מזהה רמת הקושי
            public int NumberOfCards { get; set; } // כמות הכרטיסים לבחירה
        }

    }
}
