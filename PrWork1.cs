using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork1
    {
        static List<List<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            List<List<int>> result = new List<List<int>>();
            Backtrack(result, new List<int>(), candidates, target, 0);
            return result;
        }

        static void Backtrack(List<List<int>> result, List<int> combination, int[] candidates, int target, int index)
        {
            if (target == 0)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = index; i < candidates.Length && target >= candidates[i]; i++)
            {
                if (i > index && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                combination.Add(candidates[i]);
                Backtrack(result, combination, candidates, target - candidates[i], i + 1);
                combination.RemoveAt(combination.Count - 1);
            }
        }

        static void Main()
        {
            /*Задание 1*/

            /*string J = Console.ReadLine();
            string S = Console.ReadLine();

            var jArray = J.ToCharArray();
            var sArray = S.ToCharArray();

            int count = 0;
            
            for (int i = 0; i < jArray.Length; ++i)
            {
                for (int j = 0; j < sArray.Length; ++j)
                {
                    if (jArray[i] == sArray[j])
                    {
                        ++count;
                    }
                }
            }
            
            Console.WriteLine(count);*/

            /*Задание 2*/

            /*int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
            int target = 9;
            List<List<int>> result = CombinationSum(candidates, target);
            foreach (List<int> combination in result)
            {
                Console.WriteLine(string.Join(", ", combination));
            }*/
            
            /*Задание 3*/

                /*List<int> nums = new List<int>() { 1, 4, 10, 2 };
                bool isSame = false;
                for (int i = 0; i < nums.Count; ++i)
                {
                    for (int j = 0; j < nums.Count; ++j)
                    {
                        if (i != j)
                        {
                            if (nums[i] == nums[j])
                            {
                                isSame = true;
                            }
                        }
                    }
                }
                Console.WriteLine(isSame);*/
            }
        }
    }
