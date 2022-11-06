using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.UnitOfWorks.User;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        RegWork workR;
        AutWork workA;
        ChpWork workC;
        public ProductController()
        {
            workR = new RegWork();
            workA = new AutWork();
            workC = new ChpWork();
        }
        [HttpGet]
        public IEnumerable<object> GetAll() => workR.RegRepo.GetAll();
        [HttpGet("Registration")]
        public object GetById(int id,string Name,int Password) => workR.RegRepo.Get(id,Name,Password);

        [HttpGet]
        public IEnumerable<object> GetAllA() => workA.AdminRepo.GetAllA();
        [HttpGet("Authorization")]
        public object GetByIdA(int id, string Name, int Password) => workA.AdminRepo.Get(id, Name, Password);

        [HttpGet]
        public IEnumerable<object> GetAllC() => workC.ChpRepo.GetAllC();
        [HttpGet("Authorization")]
        public object GetByIdC(int id, int Password1, int Password2) => workC.ChpRepo.Get(id, Password1, Password2);
    }
}
