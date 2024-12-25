using System.ComponentModel.DataAnnotations;



//  --VİEWMODEL--
//veritabanından gelecek olan dataları view e uygun modelleyerek göndermeyi sağlar.
//tek seferde birden fazla nesneye ulaşmayı sağlar.
//Vievs-Homework altındaki tüm cshtml dosyalarında @model HomeworkModel şeklinde değiştirildi.

namespace Internet_1.ViewModels
{
    public class HomeworkModel : BaseModel
    {
        public int Id { get; set; }

        [Display(Name = "Öğrenci Adı ve Ödevi")]
        [Required(ErrorMessage = "Öğrenci Adı ve Ödevi Giriniz!")]
        public string Name { get; set; }



        [Display(Name = "Ödev ")]
        [Required(ErrorMessage = " Ödev Giriniz!")]
        public string LessonName { get; set; }


        [Display(Name = "Ödev Açıklama")]
        [Required(ErrorMessage = "Ödev Açıklama Giriniz!")]
        public string Description { get; set; }





        [Display(Name = "Öğrenci Numarası")]
        [Required(ErrorMessage = "Öğrenci Numarası Giriniz")]
        public long StudentNumber { get; set; }


        [Display(Name = "Ödev Verildi")]
        public bool IsActive { get; set; }

        [Display(Name = "Ödev")]
        [Required(ErrorMessage = "Ödev Giriniz!")]
        public int CategoryId { get; set; }


    }
}

