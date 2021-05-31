/**************************************************************************
 *                                                                        *
 *  File:        Records.cs                                               *
 *  Copyright:   (c) 2021, Paraschiv Florin-Vladut                        *
 *  E-mail:      florin-vladut.paraschiv@student.tuiasi.ro                *
 *  Description: Entity object who refer at records table in database     *
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
    public class Records
    {
        #region Fields
        private int _id;
        private string _name;
        private int _points;
        #endregion

        #region Constructor
        /// <summary>
        /// Public constructor for entity records
        /// </summary>
        /// <param name="id">  for a better manipulation with dates </param>
        /// <param name="name"> name of the player </param>
        /// <param name="points"> total points he get right </param>
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
