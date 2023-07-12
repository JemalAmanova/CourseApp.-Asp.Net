using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//modeller metodlardan sayfalara paket halinde bilgi taşımamıza imkan sağlar. örneğin bu bir kurs modeli ve içinde kursun İd, başlık, açıklama ve resim bilgileri mevcut.

namespace Basics.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}