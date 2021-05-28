using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestConsumeAPI.IRepo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestConsumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmController : ControllerBase
    {
        private readonly IAlgorithmRepo algorithmRepo;
        public AlgorithmController(IAlgorithmRepo algorithmRepo)
        {
            this.algorithmRepo = algorithmRepo;
        }

        [HttpGet("integerToRoman")]
        public int integerToRomanAsync(string romanNumber)
        {
            var result = algorithmRepo.integerToRomanAsync(romanNumber);

            return result;
        }

        [HttpGet("randomNumber")]
        public string randomNumberAsync(int lenght)
        {
            var result = algorithmRepo.randomNumberAsync(lenght);

            return result;
        }

        [HttpGet("wordReversal")]
        public string wordReversalAsync(string word)
        {
            var result = algorithmRepo.wordReversalAsync(word);

            return result;
        }

        [HttpGet("palindromic")]
        public string palindromicAsync(string word)
        {
            var result = algorithmRepo.palindromicAsync(word);

            return result;
        }

        [HttpPost("sumIndices")]
        public IList<int> sumIndicesAsync(int[] nums, int target)
        {
            var result = algorithmRepo.sumIndicesAsync(nums, target);

            return result;
        }

        [HttpPost("indexOfString")]
        public int indexOfStringAsync(string haystack, string needle)
        {
            var result = algorithmRepo.indexOfStringAsync(haystack, needle);

            return result;
        }

        [HttpPost("searchInsertPosition")]
        public int searchInsertPositionAsync(int[] nums, int target)
        {
            var result = algorithmRepo.searchInsertPositionAsync(nums, target);

            return result;
        }

        [HttpGet("letterCombinations")]
        public IList<char> letterCombinationsAsync(string digits)
        {
            var result = algorithmRepo.letterCombinationsAsync(digits);

            return result;
        }
    }
}
