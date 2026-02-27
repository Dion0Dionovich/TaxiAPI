using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxiAPI.Models
{
    [Table("Заказы")]
    public class Заказы
    {
        [Key]
        [Column("заказ_id")]
        public int заказ_id { get; set; }

        [Required]
        [Column("пользователи_id")]
        public int пользователи_id { get; set; }

        [Column("автомобиль_id")]
        public int? автомобиль_id { get; set; }

        [Required]
        [Column("адрес_отправления_id")]
        public int адрес_отправления_id { get; set; }

        [Required]
        [Column("адрес_назначения_id")]
        public int адрес_назначения_id { get; set; }

        [Required]
        [Column("дата_заказа")]
        public DateTime дата_заказа { get; set; }

        [Required]
        [Column("способ_оплаты")]
        [StringLength(20)]
        public string способ_оплаты { get; set; }

        [Required]
        [Column("статус_заказа")]
        [StringLength(20)]
        public string статус_заказа { get; set; }

        [Required]
        [Column("итоговая_цена")]
        public decimal итоговая_цена { get; set; }

        // Навигационные свойства
        [ForeignKey("пользователи_id")]
        public Пользователи Пользователь { get; set; }

        [ForeignKey("автомобиль_id")]
        public Автомобили? Автомобиль { get; set; }

        [ForeignKey("адрес_отправления_id")]
        public Адреса АдресОтправления { get; set; }

        [ForeignKey("адрес_назначения_id")]
        public Адреса АдресНазначения { get; set; }

        public ICollection<Получение_скидки> ПолученныеСкидки { get; set; }
        public ICollection<Услуги_в_заказе> УслугиВЗаказе { get; set; }
        public ICollection<Уведомления> Уведомления { get; set; }
    }
}
