﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace Netas.Data
{
    public class List:IProducts
    {
        public productEntities db { get; set; }
        public List()
        {
            db = new productEntities();
        }



        public List<Products> GetProducts()
        {
            return db.Products.ToList();
        }
        public Products GetProducts(int id)
        {
            var finded = db.Products.Where(sa => sa.p_id == id).FirstOrDefault();
            return finded;

        }
        public void AddProducts(Products pp)
        {
            try
            {

                //var finded =db.Products.Add(pp);
                db.Entry(pp).State = EntityState.Added;
                db.SaveChanges();



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Products UpdateProducts(Products mp)
        {
            try
            {
               // var finded = db.Products.FirstOrDefault(sa => sa.p_id == id);
                //finded.p_id = mp.p_id;
                //finded.p_name = mp.p_name;
                //finded.p_category = mp.p_category;
                //finded.p_price = mp.p_price;
                db.Entry(mp).State = EntityState.Modified;
                db.SaveChanges();
                return mp;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public bool DeleteProducts(int id)
        {
            try
            {
                var finded = db.Products.Find(id);
                
                db.Products.Remove(finded);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }


    }
}
