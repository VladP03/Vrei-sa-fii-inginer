/**************************************************************************
 *                                                                        *
 *  File:        Questions.cs                                             *
 *  Copyright:   (c) 2021, Buliga Diana-Marinela                          *
 *  E-mail:      diana-marinela.buliga@student.tuiasi.ro                  *
 *  Description: Entity object who refer at questions table in database   *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

namespace DataBase.Entities
{
    public class Questions
    {
        #region Fields
        private int _id;
        private string _course;
        private string _title;
        private string _right_answer;
        private string _wrong_answer1;
        private string _wrong_answer2;
        private string _wrong_answer3;
        private string _wrong_answer4;
        private string _wrong_answer5;
        private string _wrong_answer6;
        #endregion

        #region Constructor
        /// <summary>
        /// Public constructor for entity questions 
        /// </summary>
        /// <param name="id"> for a better manipulation with dates </param>
        /// <param name="course"> question course name </param>
        /// <param name="title"> the statement of the question </param>
        /// <param name="right_answer"> right answer </param>
        /// <param name="wrong_aswer1"> first wrong answer </param>
        /// <param name="wrong_aswer2"> second wrong answer</param>
        /// <param name="wrong_aswer3"> third wrong answer </param>
        /// <param name="wrong_aswer4"> fourth wrong answer </param>
        /// <param name="wrong_aswer5"> fifth wrong answer </param>
        /// <param name="wrong_aswer6"> sixth wrong answer </param>
        public Questions(int id, string course, string title, string right_answer, string wrong_aswer1, string wrong_aswer2, string wrong_aswer3, string wrong_aswer4, string wrong_aswer5, string wrong_aswer6)
        {
            _id = id;
            _course = course;
            _title = title;
            _right_answer = right_answer;
            _wrong_answer1 = wrong_aswer1;
            _wrong_answer2 = wrong_aswer2;
            _wrong_answer3 = wrong_aswer3;
            _wrong_answer4 = wrong_aswer4;
            _wrong_answer5 = wrong_aswer5;
            _wrong_answer6 = wrong_aswer6;
        }
        #endregion

        #region Getters
        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Course
        {
            get
            {
                return _course;
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
        }
        public string Right_answer
        {
            get
            {
                return _right_answer;
            }
        }
        public string Wrong_answer1
        {
            get
            {
                return _wrong_answer1;
            }
        }
        public string Wrong_answer2
        {
            get
            {
                return _wrong_answer2;
            }
        }
        public string Wrong_answer3
        {
            get
            {
                return _wrong_answer3;
            }
        }
        public string Wrong_answer4
        {
            get
            {
                return _wrong_answer4;
            }
        }
        public string Wrong_answer5
        {
            get
            {
                return _wrong_answer5;
            }
        }
        public string Wrong_answer6
        {
            get
            {
                return _wrong_answer6;
            }
        }
        #endregion
    }
}
