using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netas.Data
{
    public interface IProducts
    {
        List<Products> GetProducts();
        Products GetProducts(int id);
        void AddProducts(Products pp);
        Products UpdateProducts(int id,Products mp);
        bool DeleteProducts(int id);

    }
}
