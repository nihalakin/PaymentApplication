using Microsoft.AspNetCore.Mvc;
using PaymentApp.Data;
using PaymentApp.Models;
using System.Linq;
using PaymentApp.Models;


public class PaymentsController : Controller
{
    private readonly AppDbContext _context;

    public PaymentsController(AppDbContext context)
    {
        _context = context;
    }

    // Ödeme Talebi Sayfası
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreatePayment(Payment payment)
    {
        _context.Payments.Add(payment); 
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    // Ödemeleri Listeleme Sayfası
    public IActionResult Index()
    {
        var payments = _context.Payments.ToList(); 
        return View(payments);
    }

    // Ödeme Durumu Güncelleme
    [HttpPost]
    public IActionResult UpdatePaymentStatus(int id, string status)
    {
        var payment = _context.Payments.Find(id); 
        if (payment != null)
        {
            if (Enum.TryParse<PaymentStatus>(status, out var parsedStatus))
            {
                payment.Durum = parsedStatus;
                _context.SaveChanges(); 
            }
        }
        return RedirectToAction("Index");
    }
}
