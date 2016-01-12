using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisV0.Framework.Core
{
    abstract class ArgBag
    {
        protected string typeName;
        
        // 禁止
        private ArgBag()
        {
        }

        public ArgBag(string typeName)
        {
            this.typeName = typeName;
        }

        public bool isNotType(string typeName)
        {
            if(this.typeName == typeName)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
