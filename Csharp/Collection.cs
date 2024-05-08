using System;
using System.Collections.Generic; // Dictionary 사용 시 추가

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*********************** [ List ] ************************/
            List<int> numbers = new List<int>();   // 빈 리스트 생성
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Remove(2);

            for (int i = 0; i<numbers.Count; i++)   // Count 대문자로 써야함
            {
                Console.WriteLine(numbers[i]);              
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            /*********************** [ Dictionary ] ************************/

            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores.Add("Alice", 100);
            scores.Add("Bob", 80);
            scores.Add("Charlie", 90);
            scores.Remove("Bob");

            foreach (KeyValuePair<string, int> pair in scores)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }
    }
}