using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixON
{
    class Picture
    {
        public string hash;
        public string path;

        // TODO: 提供一个title属性

        public bool loaded;
            public int index;

        public Picture(string hash)
        {
            this.hash = hash;
        }
    }
}
