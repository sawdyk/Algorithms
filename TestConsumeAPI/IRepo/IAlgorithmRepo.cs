using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsumeAPI.IRepo
{
    public interface IAlgorithmRepo
    {
        string wordReversalAsync(string word);
        string randomNumberAsync(int lenght);
        int integerToRomanAsync(string romanNumber);
        string palindromicAsync(string word);
        IList<int> sumIndicesAsync(int[] nums, int target);
        int indexOfStringAsync(string haystack, string needle);
        int searchInsertPositionAsync(int[] nums, int target);
        IList<char> letterCombinationsAsync(string digits);
    }
}
