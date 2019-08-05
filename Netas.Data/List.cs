using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netas.Data
{
   public class List
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
        public List<Products> GetProducts(int id)
        {
            var finded = db.Products.Where(sa => sa.p_id == id);
            return finded.ToList();
            
        }
        public Products AddProducts(Products pp)
        {
            try
            {
                
                var finded=db.Products.Add(pp);
                
                db.SaveChanges();
                return finded;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Products UpdateProducts(int id,Products mp)
        {
            try
            {
                var finded = db.Products.FirstOrDefault(sa => sa.p_id == id);

                finded.p_name = mp.p_name;
                finded.p_category = mp.p_category;
                finded.p_price = mp.p_price;
                db.SaveChanges();
                return finded;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        public Products DeleteProducts(int id)
        {
            try
            {
                var finded = db.Products.Find(id);
                db.Products.Remove(finded);
                db.SaveChanges();
                return finded;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }


    }
}
