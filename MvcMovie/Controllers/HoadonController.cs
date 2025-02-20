using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HoadonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string productName, string quantity, string unitPrice)
        {
            var hoadon = new Hoadon();
            hoadon.ProductName = productName;
            hoadon.Quantity = quantity;
            hoadon.UnitPrice = unitPrice;

            decimal quantityValue = Convert.ToDecimal(hoadon.Quantity);
            decimal unitPriceValue = Convert.ToDecimal(hoadon.UnitPrice);
            hoadon.TotalAmount = (quantityValue * unitPriceValue).ToString("F2");

            ViewBag.Message = $"Số lượng: {hoadon.Quantity} Đơn giá: {hoadon.UnitPrice} Tổng tiền: {hoadon.TotalAmount}";
            return View();
        }
    }
}