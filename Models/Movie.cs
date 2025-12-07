using System.ComponentModel.DataAnnotations;

namespace MoviesBlazor.Models
{
    public class Movies
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Назва фільму обов'язкова")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Назва повинна містити від 1 до 100 символів")]
        [Display(Name = "Назва фільму")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Режисер обов'язковий")]
        [StringLength(50, ErrorMessage = "Ім'я режисера не повинно перевищувати 50 символів")]
        [Display(Name = "Режисер")]
        public string Director { get; set; } = string.Empty;

        [Required(ErrorMessage = "Рік випуску обов'язковий")]
        [Display(Name = "Рік випуску")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Рейтинг обов'язковий")]
        [Range(1, 10, ErrorMessage = "Рейтинг повинен бути від 1 до 10")]
        [Display(Name = "Рейтинг")]
        public int? Rating { get; set; }

        [StringLength(500, ErrorMessage = "Опис не повинен перевищувати 500 символів")]
        [Display(Name = "Опис")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Жанр обов'язковий")]
        [StringLength(50, ErrorMessage = "Жанр не повинен перевищувати 50 символів")]
        [Display(Name = "Жанр")]
        public string Genre { get; set; } = string.Empty;

        [Url(ErrorMessage = "Вкажіть коректний URL постера")]
        [Display(Name = "URL постера")]
        public string? PosterUrl { get; set; }

        [Range(1, 500, ErrorMessage = "Тривалість повинна бути від 1 до 500 хвилин")]
        [Display(Name = "Тривалість (хв)")]
        public int? Duration { get; set; }
    }
}