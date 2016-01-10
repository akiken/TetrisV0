using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisV0.Framework
{
    class ViewBase : ActionResult
    {
        protected ModelBase model;

        public ViewBase()
        {

        }

        public void configure(ModelBase model)
        {
            this.model = model;
        }
    }
}
