using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.Entity.Concrete;
using ETrade.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ETrade.Client;
using ETrade.UI.Models;
using Newtonsoft.Json;

namespace ETrade.UI.Controllers
{
    public class BasketController : Controller
    {
        public static UnitOfWork _unitOfWork = new UnitOfWork();

        public List<tbl_Products> ListProduct = _unitOfWork.Products.GetList().ToList();


        public List<tbl_Basket> ListBasket = _unitOfWork.Baskets.GetList().ToList();
        public List<BasketModel> BasketModelList = new List<BasketModel>();

        public BasketController()
        {
            
            if (BasketModelList.Count() == 0)
            {
                for (int i = 0; i < ListBasket.Count(); i++)
                {
                    BasketModelList.AddRange(new BasketModel[]
                    {
                        new BasketModel()
                        {
                            _id = ListBasket[i]._id,
                            BookAuthor = ListBasket[i].BookAuthor,
                            BookCategory = ListBasket[i].BookCategory,
                            BookName = ListBasket[i].BookName,
                            BookPrice = ListBasket[i].BookPrice,
                        }
                    });

                }
            }
        }

        public IActionResult Index()
        { 
            return View(BasketModelList);
        }

        public IActionResult AddBasket(string ID)
        {
             
            try
            {
                var tempProduct = ListProduct.Find(x => x._id == ID);

                tbl_Basket _basket = new tbl_Basket
                {
                    _id = tempProduct._id,
                    BookAuthor = tempProduct.BookAuthor,
                    BookCategory = tempProduct.BookCategory,
                    BookName = tempProduct.BookName,
                    BookPrice = tempProduct.BookPrice

                };


                _unitOfWork.Baskets.Insert(_basket);
                _unitOfWork.Save();

                var status = new { operation = "Success" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            catch (Exception e)
            {

                throw;
            }





            return View();
        }
    }
}