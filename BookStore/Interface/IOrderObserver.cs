using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Interface
{
    public interface IOrderObserver
    {
        void Update(string message);
    }
}
