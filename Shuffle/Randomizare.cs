/**************************************************************************
 *                                                                        *
 *  File:        Randomizare.cs                                           *
 *  Copyright:   (c) 2021, Butnaru Silviu                                 *
 *  E-mail:      silviu.butnaru@student.tuiasi.ro                         *
 *  Description: Shuffle function for questions and answers               *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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

        /// <summary>
        /// Shuffle list of questions
        /// </summary>
        /// <param name="list"> list of questions </param>
        /// </summary>
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

        /// <summary>
        /// Shuffle list of answers
        /// </summary>
        /// <param name="list"> list of answers </param>
        /// </summary>
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
