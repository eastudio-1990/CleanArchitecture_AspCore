using Clean.Architecture.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NikanHotel.Models
{
    [Table("Passenger")]
    public class PassengerModel:BaseEntity
    {
        public Guid PassengerId { get; set; }
        /// <summary>
        /// نام مسافر
        /// </summary>
        [Required(ErrorMessage ="نام مسافر را وارد کنید")]
        [MaxLength(30)]
        public string FirstName { get; set; }
        /// <summary>
        /// نام خانوادگی مسافر
        /// </summary>
        [Required(ErrorMessage = "نام خانوادگی مسافر را وارد کنید")]
        [MaxLength(30)]
        public string LastName { get; set; }
        /// <summary>
        /// شماره هویتی مسافر
        /// </summary>
        [Required(ErrorMessage = "شماره هویتی مدرک مسافر را وارد کنید")]
        [MaxLength(50)]
        public string IdentityCode { get; set; }
        /// <summary>
        /// همراه مسافر
        /// </summary>
        [Required(ErrorMessage = "شماره همراه مسافر را وارد کنید")]
        [MaxLength(30)]
        public string Mobile { get; set; }
        /// <summary>
        /// تلفن ثابت مسافر
        /// </summary>        
        [MaxLength(30)]
        public string Tell { get; set; }
        /// <summary>
        /// آدرس مسافر
        /// </summary>
        [Required(ErrorMessage = "آدرس مسافر را وارد کنید")]
        [MaxLength(30)]
        public string Address { get; set; }
        /// <summary>
        /// نوع مدرک هویتی مسافر
        /// </summary>
        [Required(ErrorMessage = "نوع مدرک ارائه شده توسط مسافر را انتخاب کنید")]
        [MaxLength(30)]
        public string IdentityPaperType { get; set; }
        /// <summary>
        /// تاریخ شروع اقامت
        /// </summary>
        [Required(ErrorMessage = "تاریخ ورود مسافر را وارد کنید")]
        [MaxLength(30)]
        public string StartOfResidence { get; set; }
        /// <summary>
        /// تاریخ پایان اقامت
        /// </summary>
        [Required(ErrorMessage = "تاریخ خروج مسافر را وارد کنید")]
        [MaxLength(30)]
        public string EndOfResidence{ get; set; }
        /// <summary>
        /// ملیت مسافر
        /// </summary>
        [Required(ErrorMessage = "ملیت خروج مسافر را وارد کنید")]
        [MaxLength(30)]
        public string NationalityPassenger { get; set; }

    }
}
