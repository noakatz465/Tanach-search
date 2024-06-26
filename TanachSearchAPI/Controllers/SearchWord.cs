using Bll;
using DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TanachSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchWord : ControllerBase
    {
        //GET api/<SearchControllers>/5
        [HttpGet("{word}")]
        public List<SearchResult> GetWord(string word)
        {
            ClassBll searchWord = new ClassBll();
            return searchWord.TanachSearchWord(word);
        }
    }
}
