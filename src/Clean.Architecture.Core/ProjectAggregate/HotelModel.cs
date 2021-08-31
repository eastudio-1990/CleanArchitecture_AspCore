using Clean.Architecture.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NikanHotel.Models
{
    [Table("Hotel")]
    public class HotelModel:BaseEntity
    {
        /// <summary>
        /// شناسه هتل
        /// </summary>
        public int HotelId { get; set; }
        /// <summary>
        /// نام هتل
        /// </summary>
        [Required(ErrorMessage ="نام هتل را وارد کنید")]
        [MaxLength(30)]
        public string HotelName { get; set; }
        /// <summary>
        /// تعداد اتاق ها
        /// </summary>
        [Required(ErrorMessage = "تعداد اتاق را وارد کنید")]
        public int SumOfRooms { get; set; }
        /// <summary>
        /// ستاره هتل
        /// </summary>
        [Required(ErrorMessage = "تعداد ستاره های هتل را وارد کنید")]
        public int Star { get; set; }
        /// <summary>
        /// کشور
        /// </summary>
        [Required(ErrorMessage = "نام کشور هتل را وارد کنید")]
        [MaxLength(30)]
        public string Country { get; set; }
        /// <summary>
        /// استان
        /// </summary>
        [Required(ErrorMessage = "نام استان هتل را وارد کنید")]
        [MaxLength(30)]
        public string State { get; set; }
        /// <summary>
        /// شهر
        /// </summary>
        [Required(ErrorMessage = "نام شهر هتل را وارد کنید")]
        [MaxLength(30)]
        public string City { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        [Required(ErrorMessage = "آدرس هتل را وارد کنید")]
        [MaxLength(30)]
        public string Address { get; set; }
        /// <summary>
        /// تلفن
        /// </summary>
        [Required(ErrorMessage = "تلفن هتل را وارد کنید")]
        [MaxLength(30)]
        public string Tell { get; set; }
        /// <summary>
        /// فاکس
        /// </summary>
        [Required(ErrorMessage = "فاکس هتل را وارد کنید")]
        [MaxLength(30)]
        public string Fax { get; set; }
        /// <summary>
        /// درجه
        /// </summary>
        [Required(ErrorMessage = "درجه کیفی هتل را وارد کنید")]
        [MaxLength(30)]
        public string Rank { get; set; }
        
    }
}
