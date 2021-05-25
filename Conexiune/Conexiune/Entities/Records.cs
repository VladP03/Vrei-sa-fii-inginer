

namespace BazeDeDate.Entities
{
    public class Records
    {
        private int _id;
        private string _name;
        private string _email;
        private int _points;
        private object _date_finish;

        public Records(int id, string name, string email, int points, object date_finish)
        {
            _id = id;
            _name = name;
            _email = email;
            _points = points;
            _date_finish = date_finish;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
        }

        public int Points
        {
            get
            {
                return _points;
            }
        }

        public object Date_finish
        {
            get
            {
                return _date_finish;
            }
        }
    }
}
