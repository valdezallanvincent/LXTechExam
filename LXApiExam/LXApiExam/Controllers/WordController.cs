using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LXApiExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        [HttpGet("/reversed-words", Name = "GetReversedWord")]
        public IActionResult GetReversedWord(string words="")
        {
            try { 
                string resultMsg = "";
                for (int x = words.Length - 1; x >= 0; x--)
                {
                    resultMsg += words[x].ToString();
                }
                return Ok(resultMsg);
            }catch(Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("/sort-words", Name = "GetSortedWord")]
        public IActionResult GetSortedWord(string words = "")
        {
            try
            {
                var wordList = words.Split(' ').ToList();
                wordList = wordList.OrderBy(str => str).ToList(); ;
                string resultMsg = string.Join(" ", wordList).Trim(' ');
                return Ok(resultMsg);
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
   
        }
    }
}