/* * * * * * * * * * * * * * * * * * * * * * * * *
 *          Owner: Paraschiv Vlad                *
 * * * * * * * * * * * * * * * * * * * * * * * * */

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
