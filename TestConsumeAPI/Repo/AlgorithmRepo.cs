using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsumeAPI.IRepo;

namespace TestConsumeAPI.Repo
{
    public class AlgorithmRepo : IAlgorithmRepo
    {
        public int integerToRomanAsync(string romanNumber)
        {
            try
            {
                char[] romanArray = romanNumber.ToUpper().ToCharArray();

                IDictionary<string, int> dic = new Dictionary<string, int>();
                dic.Add("I", 1);
                dic.Add("V", 5);
                dic.Add("X", 10);
                dic.Add("L", 50);
                dic.Add("C", 100);
                dic.Add("D", 500);
                dic.Add("M", 1000);

                IDictionary<string, int> dicBf = new Dictionary<string, int>();
                dicBf.Add("IV", 4);
                dicBf.Add("IX", 9);
                dicBf.Add("XL", 40);
                dicBf.Add("XC", 90);
                dicBf.Add("CD", 400);
                dicBf.Add("CM", 900);

                int length = romanArray.Length;

                int numberRep = 0;
                int doubleRomanNumRep = 0;
                int singleRomanNumRep = 0;
                string newRoman = string.Empty;
                IList<string> doubleRomanList = new List<string>();

                //Input: s = "MCMXCIV"
                //Output: 1994
                //Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

                if (length >= 1 && length <= 15)
                {
                    foreach (var dd in dicBf)
                    {
                        if (romanNumber.Contains(dd.Key))
                        {
                            doubleRomanNumRep += dd.Value;
                            newRoman = romanNumber.Replace(dd.Key, "");
                            romanNumber = newRoman;

                            if (!string.IsNullOrEmpty(dd.Key))
                            {
                                doubleRomanList.Add(dd.Key);
                            }
                        }
                        else
                        {
                            newRoman = romanNumber;
                        }
                    }

                    char[] newRomanArray = newRoman.ToUpper().ToCharArray();

                    for (int i = 0; i < newRomanArray.Length; i++)
                    {
                        if (dic.ContainsKey(newRoman[i].ToString()))
                        {
                            singleRomanNumRep += dic.FirstOrDefault(x => x.Key == newRoman[i].ToString()).Value;
                        }
                    }

                    numberRep = singleRomanNumRep + doubleRomanNumRep;

                }

                return numberRep;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string randomNumberAsync(int lenght)
        {
            try
            {
                Random rnd = new Random();
                StringBuilder str = new StringBuilder();

                for (int i = 0; i < lenght; i++)
                {
                    str.Append(rnd.Next(0, 10).ToString());
                }

                return str.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string wordReversalAsync(string word)
        {
            try
            {
                int count = word.Length;
                string reversedWord = string.Empty;

                StringBuilder str = new StringBuilder();
                if (string.IsNullOrEmpty(word))
                    word = "DEFAULT";

                for (int i = 1; i <= count; i++)
                {
                    str.Append(word[count - i]);
                }

                reversedWord = str.ToString();

                return reversedWord;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string palindromicAsync(string word)
        {
            try
            {
                int count = word.Length;
                string statement = string.Empty;

                StringBuilder str = new StringBuilder();
                if (string.IsNullOrEmpty(word))
                    word = "";

                for (int i = 1; i <= count; i++)
                {
                    str.Append(word[count - i]);
                }

                if (str.Equals(word))
                    statement = "This Word is a palindromic Word!";
                else
                    statement = "This Word is not a palindromic Word!";

                return statement;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<int> sumIndicesAsync(int[] nums, int target)
        {
            try
            {
                int sum = 0;
                int count = 1;

                IList<int> indicesList = new List<int>();
                IList<int> tempList = new List<int>();

                int[] arr = {};

                for (int i = 0; i < nums.Length; i++)
                {
                    sum = nums[i] + nums[count];

                    

                    if (sum == target)
                    {
                        var index1 = Array.IndexOf(nums, nums[i]);
                        //var index2 = Array.IndexOf(nums, nums[count]);

                        tempList.Add(index1);
                        tempList.Add(count);

                        break;
                    }
                      
                    count++;
                }

                return tempList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int indexOfStringAsync(string haystack, string needle)
        {
            try
            {
                int returnValue = 0;

                if (haystack.Length == 0 && needle.Length == 0) 
                    returnValue = 0;
                else if (needle.Length > haystack.Length)
                    returnValue = -1;
                else if (needle.Length == 0)
                    returnValue = 0;
                else if (haystack.Length == 0)
                    returnValue = -1;
                else
                {
                    int index = haystack.IndexOf(needle);
                    returnValue = index;
                }

                return returnValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int searchInsertPositionAsync(int[] nums, int target)
        {
            try
            {
                int index = 0;
                int indexOfTarget = Array.IndexOf(nums, target);

                if (indexOfTarget == -1)
                {
                    int[] newIntArray = nums.Append(target).ToArray();
                    int[] sortedNums = newIntArray.OrderBy(i=>i).ToArray();
                    
                    index = Array.IndexOf(sortedNums, target);
                }
                else
                {
                    index = indexOfTarget;
                }

                return index;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<char> letterCombinationsAsync(string digits)
        {
            Dictionary<int, string> combinations = new Dictionary<int, string>()
            {
                {2, "abc"},
                {3, "def"},
                {4, "ghi"},
                {5, "jkl"},
                {6, "mno"},
                {7, "pqrs"},
                {8, "tuv"},
                {9, "wxyz"},
            };

            char[] arr = { };

            string[] comb = { };

            //char[] digArr = digits.ToCharArray();
            IList<char> srr = new List<char>();
            

            for (int i = 0; i < digits.Length; i++)
            {
                int number = Convert.ToInt32(digits[i].ToString());
                string letter = combinations.Where(x => x.Key == number).FirstOrDefault().Value;
                char[] charArr = letter.ToCharArray();

                for (int k = 0; k < charArr.Length; k++)
                {
                    comb.(letter[i]);





                }
            }

            //var srtArr = 

            return arr;
        }
    }
}
