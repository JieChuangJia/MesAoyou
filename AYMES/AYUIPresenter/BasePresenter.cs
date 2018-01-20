
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AYUIPresenter
{
    public class BasePresenter<IView>
    {
        public IView View { get; set; }
        public BasePresenter(IView ivew)
        {
            this.View = ivew;
        }
    }
}
