﻿using Newtonsoft.Json.Linq;
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
    public class CarsController : ApiController
    {
        //Method GET for CLients Information
        public IEnumerable<Car> GetAllCars()
        {
            UsersContext db = new UsersContext();
            var cars = db.Car;            
            return cars;       
        }    

        public IHttpActionResult GetCar(int id)
        {
            UsersContext db = new UsersContext();
            var cars = db.Car;
            var car = cars.FirstOrDefault((c) => c.Clients_key == id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        public IHttpActionResult PostCar(Car car)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (UsersContext db = new UsersContext())
            {
                db.Add(new Car()
                {
                     Clients_key = car.Clients_key,
                     Marca = car.Marca                 
                });

                db.SaveChanges();
            }
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
