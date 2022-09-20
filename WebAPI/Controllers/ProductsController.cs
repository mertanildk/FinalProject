using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {  //Loosely coupled //gevşek bağlılık.
        //naming convention

        //IoC Container =inversion of control 
        private IProductService _productService;//field

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //IActionResult =
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);
            //dependency chain--bağımlılık var
            //Swagger dökümantasyon    
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);//sadece mesajı yazdırmak istersen böyle 
            //postman status = 400 badrequest yazdı.
            //BadRequest ile 400ü yazdırmış olduk.
            //ok ile olumlu badrequest ile olumsuz diyebiliriz
        }

        [HttpGet("getbyid")]//isimlerle alyans veriyoruz
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategory")]//isimlerle alyans veriyoruz
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")] //güncelleme silme ekleme post ile yapılabilir.
        //güncelleme için Put,silme için delete kullanabilirsin ama genelde post

        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

      

    }
}
// attri //bir controller'ın controller olabilmesi için controllerBaseden inherit edilmesi ve ApiController
//bu olaya biz c#da ATTRIBUTE denir. Javada ANNOTATION denir.
//attribute bir class ile ilgili bilgi verme ,onu imzalama 
//burada biz diyoruz ki bu class bir controller'dır. diyoruz.
//route ise bize nasıl istekte bulunacağını söylüyor


