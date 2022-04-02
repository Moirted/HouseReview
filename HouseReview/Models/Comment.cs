using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace HouseReview.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        [Display(Name = "Адрес")]
        [Required]
        public string Adress { get; set; }

        [Display(Name = "Комментарий")]
        [Required]
        public string Text { get; set; }


        [Display(Name = "Дата создания")]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        [Display(Name = "Оценка")]
        [Range(1,5, ErrorMessage = "Оценка от 1 до 5")]
        public int Grade { get; set; }

        public Comment()
        {

        }

    }
}
