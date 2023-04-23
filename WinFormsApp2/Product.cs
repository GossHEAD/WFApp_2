using System.ComponentModel;
namespace WinFormsApp2;

public class Product
{
    [DisplayName("ID")]
    public int ProductId { get; internal set; }

    [DisplayName("Название")]
    public string? Name { get; internal set; }
    [DisplayName("Количество")]
    public int Count { get; internal set; }
    [DisplayName("Категория")]
    public string? Category { get; internal set; }
}

