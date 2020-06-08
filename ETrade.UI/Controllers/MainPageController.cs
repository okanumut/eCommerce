using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.Entity.Concrete;
using ETrade.Repository.UnitOfWork;
using ETrade.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class MainPageController : Controller
    {
        public static UnitOfWork _unitOfWork = new UnitOfWork(); 

        public List<tbl_Products> ListProduct = _unitOfWork.Products.GetList().ToList();
        public List<ProductModel> ProductModelList = new List<ProductModel>();

        public MainPageController()
        {
            if (ProductModelList.Count() == 0)
            {
                for (int i = 0; i < ListProduct.Count(); i++)
                {
                    ProductModelList.AddRange(new ProductModel[]
                    {
                        new ProductModel()
                        {
                            _id = ListProduct[i]._id,
                            BookAuthor = ListProduct[i].BookAuthor,
                            BookCategory = ListProduct[i].BookCategory,
                            BookName = ListProduct[i].BookName,
                            BookPrice = ListProduct[i].BookPrice,
                        }
                    });

                }
            }

        }


        public IActionResult Index()
        {
            return View(ProductModelList);
        }
    }
}