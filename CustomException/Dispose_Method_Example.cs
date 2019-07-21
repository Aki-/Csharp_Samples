using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Dispose_Method_Example : IDisposable
    {
        // Flag: Has Dispose already been called?
        bool disposed = false;


        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.

                // if disposing is true, then the method 
                // is being called as part of a managed disposal
                // this means it should be safe to dispose of managed 
                // resources (.Net classes such as System.IO.Stream )
            }

            // If disposing is false, the Dispose method was called 
            // from the finaliser, so you're in the last chance saloon 
            // as far as tidying stuff up is concerned.
            // Only unmanaged resources (and the objects that wrap them)
            // should be tidied up in this scenario



            disposed = true;




        }

    }
}
