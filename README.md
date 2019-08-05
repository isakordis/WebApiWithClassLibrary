# WebApiWithClassLibrary
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using expClass;

namespace Example.Controllers
{
    public class ListController : ApiController
    {
        private List newList { get; set; }


        public ListController()
        {
            newList = new List();
        }


        [Route("api/list")]
        public List<myProduct> GetmyProduct()
        {

            return newList.GetmyProduct();

        }
        [Route("api/list/{id:int}")]
        public myProduct GetmyProduct(int id)
        {

            return newList.GetmyProduct(id);
        }
        //[Route("api/list/update/{mp:myProduct}")]
        public myProduct UpdatePro(myProduct mp)
        {

            return newList.UpdatemyProduct(mp);
        }
        //[Route("api/list/add/{mp:myProduct}")]
        public myProduct AddPro(myProduct mp)
        {

            return newList.AddmyProduct(mp);
        }
        [Route("api/list/del/{id:int}")]
        public myProduct DelPro(int id)
        {

            return newList.DeletemyProduct(id);
        }
    }
}
