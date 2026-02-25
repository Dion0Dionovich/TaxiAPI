using System.ComponentModel.DataAnnotations;

namespace TaxiAPI;


public class Product
{
    public int Id { get; set; }  // id заказа

    [Required]
    public string Name { get; set; } = string.Empty;  // Название заказа

    public string? Description { get; set; }  // описание заказа

    [Required]
    public decimal Price { get; set; }  // цена заказа

    public string? ImageUrl { get; set; }  // адрес картинки заказа
}