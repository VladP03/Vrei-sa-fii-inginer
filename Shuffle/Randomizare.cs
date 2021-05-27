using DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    public class Randomizare
    {
        private static Random _random = new Random();

        public static void Shuffle(List<Questions> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                Questions value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void ShuffleAnswers(List<string> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
