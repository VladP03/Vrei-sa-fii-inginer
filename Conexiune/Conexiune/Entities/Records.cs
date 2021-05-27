/* * * * * * * * * * * * * * * * * * * * * * * * *
 *          Owner: Paraschiv Vlad                *
 * * * * * * * * * * * * * * * * * * * * * * * * */

namespace DataBase.Entities
{
    public class Records
    {
        #region Fields
        private int _id;
        private string _name;
        private int _points;
        #endregion

        #region Constructor
        public Records(int id, string name, int points)
        {
            _id = id;
            _name = name;
            _points = points;
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

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Points
        {
            get
            {
                return _points;
            }
        }
        #endregion
    }
}
