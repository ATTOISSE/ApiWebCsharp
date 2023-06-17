using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiStock.Models;

namespace WebApiStock.Controllers
{
    public class ProduitsController : ApiController
    {
        private BDStockEntities db = new BDStockEntities();

        // GET: api/Produits
        public IQueryable<Produit> GetProduit()
        {
            return db.Produit;
        }

        // GET: api/Produits/5
        [ResponseType(typeof(Produit))]
        public IHttpActionResult GetProduit(int id)
        {
            Produit produit = db.Produit.Find(id);
            if (produit == null)
            {
                return NotFound();
            }

            return Ok(produit);
        }

        // PUT: api/Produits/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduit(int id, Produit produit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != produit.id)
            {
                return BadRequest();
            }

            db.Entry(produit).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProduitExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Produits
        [ResponseType(typeof(Produit))]
        public IHttpActionResult PostProduit(Produit produit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Produit.Add(produit);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = produit.id }, produit);
        }

        // DELETE: api/Produits/5
        [ResponseType(typeof(Produit))]
        public IHttpActionResult DeleteProduit(int id)
        {
            Produit produit = db.Produit.Find(id);
            if (produit == null)
            {
                return NotFound();
            }

            db.Produit.Remove(produit);
            db.SaveChanges();

            return Ok(produit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProduitExists(int id)
        {
            return db.Produit.Count(e => e.id == id) > 0;
        }
    }
}