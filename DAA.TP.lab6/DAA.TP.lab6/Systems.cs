namespace DAA.TP.lab6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public delegate void SystemEventHandler(double x);

    class Systems
    {
        public event SystemEventHandler CountSystem;

        public void CountingSystem(double x)
        {
            if (CountSystem != null)
            {
                CountSystem(x);
            }
        }
    }
}
