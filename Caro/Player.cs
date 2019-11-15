using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    class Player
    {
        public string playerName
        {
            get;
            set;
        }
        public Image image
        {
            get;
            set;
        }
        public Image avatar
        {
            get;
            set;
        }
        public Player(string str, Image img, Image ava)
        {
            playerName = str;
            image = img;
            avatar = ava;
        }
    }
}
