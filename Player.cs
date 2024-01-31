using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        public string name= "sourab";
        public int health=49;
        //public void setHealth(int h)
        //{
        //    health = h;
        //}

        public int getHealth()
        {
            return health;
        }
        private void setHealth(int h)
        {
            health = h;
        }
    }
}
