using Clean.Architecture.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NikanHotel.Models
{
    [Table("Room")]
    public class RoomModel:BaseEntity
    {
        ////<summery>
        ///شناسه اتاق
        ///<summery>
        public Guid RoomId { get; set; }
        /// <summary>
        /// تعداد تخت
        /// </summary>
        [Required(ErrorMessage = "تعداد تخت های اتاق را انتخاب کنید")]
        public int RoomBeds { get; set; }
        /// <summary>
        /// شماره اتاق
        /// </summary>
        [Required(ErrorMessage ="شماره اتاق را وارد کنید")]
        [MaxLength(10)]
        public string RoomNumber { get; set; }
        /// <summary>
        /// سرویس های روی اتاق
        /// </summary>
        [Required(ErrorMessage = "سرویس اتاق را انتخاب کنید")]
        public string Servicec { get; set; }
        /// <summary>
        /// نمای اتاق
        /// </summary>
        [Required(ErrorMessage = "نمای اتاق را انتخاب کنید")]
        [MaxLength(10)]
        public string RoomView { get; set; }
        /// <summary>
        /// طبقه اتاق
        /// </summary>
        [Required(ErrorMessage = "طبقه اتاق را وارد کنید")]
        [MaxLength(10)]
        public string RoomFloor { get; set; }
        /// <summary>
        /// موقعیت اتاق
        /// </summary>
        [Required(ErrorMessage = "موقعیت اتاق را انتخاب کنید")]
        [MaxLength(10)]
        public string RoomLocation { get; set; }
        /// <summary>
        /// مساحت اتاق
        /// </summary>
        [Required(ErrorMessage = "مساحت اتاق را وارد کنید")]
        public int RoomArea { get; set; }
        /// <summary>
        /// تعداد پنجره های اتاق
        /// </summary>
        public int RoomWindows { get; set; }
        /// <summary>
        ///  بالکن اتاق
        /// </summary>
        [Required(ErrorMessage = "دارا بود بالکن را برای اتاق مشخص کنید")]
        public bool RoomBalcony { get; set; }
        /// <summary>
        /// نوع سرویس بهداشتی
        /// </summary>
        [Required(ErrorMessage = "نوع سرویس های بهداشتی اتاق را انتخاب کنید")]
        public string WCType { get; set; }
        /// <summary>
        /// نوع اتاق
        /// </summary>
        [Required(ErrorMessage = "نوع اتاق را انتخاب کنید")]
        public string RoomType { get; set; }
        /// <summary>
        /// شناسه هتل 
        /// </summary>
        [Required(ErrorMessage = "هتل را انتخاب کنید")]
        public int HotelId { get; set; }
        /// <summary>
        /// وضعیت رزرو اتاق
        /// </summary>
        [Required(ErrorMessage = "وضعیت رزرو اتاق را انتخاب کنید")]
        public bool Reservation { get; set; }
        /// <summary>
        /// وضعیت پر بودن یا خالی بود اتاق
        /// </summary>
        [Required(ErrorMessage = "وضعیت پر بودن یا خالی بود اتاق اتاق را انتخاب کنید")]
        public bool EmptyOrNot { get; set; }
        /// <summary>
        /// شناسه مسافر
        /// </summary>
        public Guid PassengerId { get; set; }

    }
}
