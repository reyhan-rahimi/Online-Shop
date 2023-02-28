using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Models
{
    public class Mobile
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "برند*")]
        public string Brand { get; set; }
        [Display(Name = "نقد و بررسی")]
        public string Review { get; set; }
        [Display(Name = "گارانتی")]
        public string Garanty { get; set; }
        [Display(Name = "توضیحات")]
        public string Discribtor { get; set; }
        [Display(Name = "قیمت تخفیفی")]
        public string Sale { get; set; }
        [Required]
        [Display(Name = "قیمت*")]
        public Double Price { get; set; }
        [Required]
        [Display(Name = "عکس*")]
        public string Picture { get; set; }
        [Required]
        [Display(Name = "*رنگ")]
        public string Colors { get; set; }
        [Required]
        [Display(Name = "ابعاد*")]
        public string Dimensions { get; set; }
        [Required]
        [Display(Name = "تاریخ ایجاد*")]
        public DateTime DateCreate { get; set; }
        [Required]
        [Display(Name = "*وزن")]
        public string Weight { get; set; }
        [Display(Name = "سایز سیم کارت")]
        public string SIMcardsDescription { get; set; }
        [Display(Name = "ویژگی های خاص")]
        public string SpecialFeatures { get; set; }
        [Display(Name = "تعداد سیم کارت")]
        public string NumberOfSimCards { get; set; }
        [Required]
        [Display(Name = "مدل*")]
        public string Model { get; set; }
        [Display(Name = "تراشه")]
        public string Chip { get; set; }
        [Display(Name = "پردازنده مرکزی")]
        public string CPU { get; set; }
        [Display(Name = "نوع پردازنده مرکزی")]
        public string ProcessorType { get; set; }
        [Display(Name = "فرکانس پردازنده مرکزی")]
        public string CPUFrequency { get; set; }
        [Display(Name = "پردازنده گرافیکی")]
        public string GraphiteProcessore { get; set; }
        [Required]
        [Display(Name = "حافطه داخلی*")]
        public string InternalMemory { get; set; }
        [Required]
        [Display(Name = "سایز* RAM")]
        public string Ramsize { get; set; }
        [Required]
        [Display(Name = "نوع کارت حافظه*")]
        public string MemoryCardSupport { get; set; }
        [Display(Name = "فناوری صفحه نمایش")]
        public string ScreenTechnology { get; set; }
        [Required]
        [Display(Name = "اندازه*")]
        public string size { get; set; }
        [Required]
        [Display(Name = "رزولوشن*")]
        public string Resulotion { get; set; }
        [Display(Name = "تراکم پیکسلی")]
        public string PixelDensity { get; set; }
        [Display(Name = "نسبت صفحه نمایش به بدنه")]
        public string ScreenToBodyRatio { get; set; }
        [Required]
        [Display(Name = "*شبکه های ارتباطی")]
        public string CommunicationNetworks { get; set; }
        [Display(Name = "2G")]
        public string TwoG { get; set; }
        [Display(Name = "3G")]
        public string ThreeG { get; set; }
        [Display(Name = "4G")]
        public string FourG { get; set; }
        [Display(Name = "فناوری ارتباطی")]
        public string CommunicationTechnology { get; set; }
        [Display(Name = "درگاه های ارتباطی")]
        public string CommunicationPortals { get; set; }
        [Display(Name = "نسخه Bluetooth")]
        public string BluetoothVersion { get; set; }
        [Display(Name = "دوربین های پشت")]
        public string BackCamera { get; set; }
        [Display(Name = "رزولوشن عکس")]
        public string PictureResolution { get; set; }
        [Display(Name = "قابلیت های دوربین")]
        public string CameraAbility { get; set; }
        [Display(Name = "فیلمبرداری")]
        public string Film { get; set; }
        [Required]
        [Display(Name = "دوربین سلفی*")]
        public string SelfiCamera { get; set; }
        [Required]
        [Display(Name = "سیستم عامل*")]
        public string OperatingSystem { get; set; }
        [Display(Name = "حسگرها")]
        public string Sensor { get; set; }
        [Display(Name = "مشخصات باتری")]
        public string BattreySpecifications { get; set; }
        public int ViewNumber { get; set; }
    }
}
