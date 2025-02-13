using System.ComponentModel.DataAnnotations.Schema; // Bunu ekle

namespace PaymentApp.Models;

public enum PaymentStatus
{
    Beklemede,
    Tamamlandi,
    IptalEdildi
}

public class Payment
{
    public int Id { get; set; }
    public string AdSoyad { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefon { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")] // Decimal veri tipi için precision belirleme
    public decimal Tutar { get; set; }

    public PaymentStatus Durum { get; set; } = PaymentStatus.Beklemede;  // Varsayılan Beklemede
}
