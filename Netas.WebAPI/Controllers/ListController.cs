using Netas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Netas.WebAPI.Controllers
{
    public class ListController : ApiController
    {
        
        public ListController()
        {
           

        }
        public List<Products> GetProducts()
        {
            Data.List newList = new List();
           return newList.GetProducts();
            
        }
        public List<Products> GetProducts(int id)
        {
            List ll = new List();
            return ll.GetProducts(id);
        }

        public Products UpdatePro(int id,Products mp)
        {
            List ul = new List();
            return ul.UpdateProducts(id, mp);
        }
        public Products AddPro(Products mp)
        {
            List ad = new List();
            return ad.AddProducts(mp);
        }
        public Products DelPro(int id)
        {
            List del = new List();
            return del.DeleteProducts(id);
        }

       
    }
}
