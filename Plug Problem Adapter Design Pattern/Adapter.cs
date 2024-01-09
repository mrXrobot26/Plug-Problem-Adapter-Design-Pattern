using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plug_Problem_Adapter_Design_Pattern
{
    internal class Adapter : ITarget
    {
        private Adptee _adptee;
        public Adapter(Adptee adptee)
        {
            _adptee = adptee;
        }
        public void NormalPlug()
        {
            this._adptee.UniqePlug();
        }
    }
}
