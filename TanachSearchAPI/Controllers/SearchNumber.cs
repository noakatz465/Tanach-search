using Bll;
using Microsoft.AspNetCore.Mvc;


namespace TanachSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchNumber : ControllerBase
    {
        //GET api/<SearchControllers>/5

        [HttpGet("{number}")]
        public List<string> GetNumber(int number)
        {
            ClassBll searchNum = new ClassBll();
            return searchNum.SesrchNumber(number);
        }




    }
}
