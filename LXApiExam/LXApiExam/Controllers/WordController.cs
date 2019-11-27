using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LXApiExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        IWordBLL wordBLL;
        public WordController(IWordBLL wordBLL)
        {
            this.wordBLL = wordBLL;
        }
        [HttpGet("/reversed-words", Name = "GetReversedWord")]
        public IActionResult GetReversedWord(string words="")
        {
            try 
            {
                string resultMsg = wordBLL.GetReversedWord(words);
               
                return Ok(resultMsg);

            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("/sort-words", Name = "GetSortedWord")]
        public IActionResult GetSortedWord(string words = "")
        {
            try
            {

                string resultMsg = wordBLL.GetSortedWord(words);
                return Ok(resultMsg);
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}