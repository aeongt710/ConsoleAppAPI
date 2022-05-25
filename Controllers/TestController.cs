using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {
        [Route(nameof(Get))]
        //[Route("[controller]/[action]")]
        public string Get()
        {
            return "Hello from test/Get";
        }
        [Route("~/get2")]
        //[Route("[controller]/[action]")]
        public string Get2()
        {
            return "Hello from test/Get2";
        }
        [Route("getbyid/{id}")]
        public string getbyidName(int id)
        {
            return "The id is: "+id;
        }

        [Route("book/{id}/author/{id2}")]
        public string getbydoubleid(int id,int id2)
        {
            return "Book id is: " + id +"  & author id is: "+id2;
        }
        [Route("search")]
        //search?name=asd&age=123&id=3
        public string seraching(int id, string name, string address,int age)
        {
            return "this is search result ";
        }
    }
}
