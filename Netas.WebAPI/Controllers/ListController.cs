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
        List newList { get; set; }
        public ListController()
        {
            newList = new List();

        }


        [Route("api/list")]
        public List<Products> GetProducts()
        {
            newList = new List();
            return newList.GetProducts();

        }

        [Route("api/list/{id:int}")]
        public Products GetProducts(int id)
        {
            newList = new List();
            return newList.GetProducts(id);
        }
        [Route("api/list/update/{mp:Products}")]
        public Products UpdatePro(Products mp)
        {
            newList = new List();
            return newList.UpdateProducts(mp);
        }

        [Route("api/list/add/{mp:Products}")]
        public void AddPro(Products mp)
        {
            newList = new List();

        }

        [Route("api/list/del/{id:int}")]
        public Products DelPro(int id)
        {
            newList = new List();
            return newList.DeleteProducts(id);
        }


    }
}
