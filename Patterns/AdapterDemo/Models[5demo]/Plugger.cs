using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo.Models_5demo_
{
    class Plugger : IConvertor
    {
        private IConvertor convertor;

        public Plugger(IConvertor convertor)
        {
            this.convertor = convertor;
        }

        public void CatchAndDisplay()
        {
            this.convertor.CatchAndDisplay();
        }
    }
}
