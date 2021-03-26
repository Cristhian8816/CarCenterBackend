using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebAngularAPI.Models;
using System.Web.Http.Cors;

namespace WebAngularAPI.Controllers
{    
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ClientsController : ApiController
    {
        //Method GET for CLients Information
        public IEnumerable<Client> GetAllClients()
        {
            UsersContext db = new UsersContext();
            var clients = db.Client;            
            return clients;       
        }    

        public IHttpActionResult GetProduct(int id)
        {
            UsersContext db = new UsersContext();
            var products = db.Client;
            var product = products.FirstOrDefault((p) => p.Clients_key == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public IHttpActionResult PostProduct(Client product)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            //using (UsersContext db = new UsersContext())
            //{
            //    db.Add(new Product()
            //    {
            //        id = product.id,
            //        title = product.title,
            //        price = product.price,
            //        description = product.description,
            //        image = product.image
            //    });

            //    db.SaveChanges();
            //}
            return Ok();
        }

        public IHttpActionResult PutProduct(int id, Client product)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (UsersContext db = new UsersContext())
            {
                //var existingProduct = db.Product.Where(p => p.id == id)
                //                                       .FirstOrDefault<Product>();

                //if (existingProduct != null)
                //{
                //    existingProduct.id = id;
                //    existingProduct.title = product.title;
                //    existingProduct.price = product.price;
                //    existingProduct.description = product.description;
                //    existingProduct.image = product.image;

                //    db.SaveChanges();
                //}
                //else
                //{
                //    return NotFound();
                //}
            }

            return Ok();
        }

        public IHttpActionResult DeleteProduct(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");

            //using (UsersContext db = new UsersContext())
            //{
            //    var Product = db.Product
            //        .Where(p => p.id == id)
            //        .FirstOrDefault();

            //    db.Product.Remove(Product);
            //    db.SaveChanges();
            //}

            return Ok();
        }
    }
}
