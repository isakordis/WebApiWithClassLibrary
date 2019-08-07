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
        


        //[Route("api/list")]
        [HttpGet]
        public List<Products> GetProducts()
        {
            newList = new List();
            return newList.GetProducts();

        }

        //[Route("api/list/{id:int}")]
        [HttpGet]
        public Products GetProducts(int id)
        {
            newList = new List();
            return newList.GetProducts(id);
        }
        //[Route("api/list/update/{mp:Products}")]
        [HttpPut]
        public Products UpdatePro(int id,Products mp)
        {
            newList = new List();
            return newList.UpdateProducts(id,mp);
        }

        //[Route("api/list/add/{mp:Products}")]
        [HttpPost]
        public Products AddPro(Products mp)
        {
            newList = new List();
            newList.AddProducts(mp);
            return newList.GetProducts(mp.p_id);
        }

        //[Route("api/list/del/{id:int}")]
        [HttpDelete]
        public bool DelPro(int id)
        {
                  newList = new List();
            newList.DeleteProducts(id);
            return true;
        }


    }
}
