using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        //[Route("{id:int:max(10)}")]
        [Route("{id:int:min(10):max(100)}")]
        public string getById(int id)
        {
            return "int id is: " + id;
        }
        //[Route("{id}")]
        [Route("{id:minlength(5)}")]
        //maxlength
        //range(2,5)
        //lenth(5)
        //minlength(5)  for alpha chara 
        //required
        //id:minlength(5):regex(a(b|c))
        public string getByName(string id)
        {
            return "int id is: " + id;
        }
    }
}
