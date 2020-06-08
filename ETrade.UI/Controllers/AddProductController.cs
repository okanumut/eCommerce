using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.Entity.Concrete;
using ETrade.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ETrade.UI.Controllers
{
    public class AddProductController : Controller
    {
        public static UnitOfWork _unitOfWork = new UnitOfWork();

        public List<tbl_Products> ListProduct = _unitOfWork.Products.GetList().ToList();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct(string BookName,string BookAuthor, string BookPrice, string BookCategory)
        {
            try
            {
                tbl_Products _book = new tbl_Products
                {
                    BookName = BookName,
                    BookAuthor = BookAuthor,
                    BookCategory = BookCategory,
                    BookPrice = BookPrice,
                };

                _unitOfWork.Products.Insert(_book);
                _unitOfWork.Save();

                var status = new { operation = "Success" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            catch (Exception)
            {
                var status = new { operation = "Wrong" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            

            return View();
        }

        public IActionResult DeleteProduct(string ID)
        {
            try
            {
                var t = _unitOfWork.Products.Find(x => x._id == ID);

                tbl_Products del = new tbl_Products
                {
                    _id = t._id,
                    BookAuthor = t.BookAuthor,
                    BookCategory = t.BookCategory,
                    BookName = t.BookName,
                    BookPrice = t.BookPrice,
                };

                tbl_Basket dell = new tbl_Basket
                {
                    _id = t._id,
                    BookAuthor = t.BookAuthor,
                    BookCategory = t.BookCategory,
                    BookName = t.BookName,
                    BookPrice = t.BookPrice,
                };

                _unitOfWork.Products.Delete(del);
                _unitOfWork.Baskets.Delete(dell);
                _unitOfWork.Save();

                var status = new { operation = "Success" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            catch (Exception)
            {
                var status = new { operation = "Wrong" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }

            

             
            return View();
        }
    }
}