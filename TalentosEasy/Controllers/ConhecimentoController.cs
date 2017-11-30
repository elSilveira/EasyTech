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
using TalentosEasy;
using TalentosEasy.Models;

namespace TalentosEasy.Controllers
{
    public class ConhecimentoController : ApiController
    {
        private ModelDados db = new ModelDados();

        // GET: api/Conhecimento
        public IQueryable<Conhecimento> GetConhecimento()
        {
            return db.Conhecimento;
        }

        // GET: api/Conhecimento/5
        [ResponseType(typeof(Conhecimento))]
        public IHttpActionResult GetConhecimento(int id)
        {
            Conhecimento conhecimento = db.Conhecimento.Find(id);
            if (conhecimento == null)
            {
                return NotFound();
            }

            return Ok(conhecimento);
        }

        // PUT: api/Conhecimento/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutConhecimento(int id, Conhecimento conhecimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != conhecimento.IdConhecimento)
            {
                return BadRequest();
            }

            db.Entry(conhecimento).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConhecimentoExists(id))
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

        // POST: api/Conhecimento
        [ResponseType(typeof(Conhecimento))]
        public IHttpActionResult PostConhecimento(Conhecimento conhecimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Conhecimento.Add(conhecimento);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = conhecimento.IdConhecimento }, conhecimento);
        }

        // DELETE: api/Conhecimento/5
        [ResponseType(typeof(Conhecimento))]
        public IHttpActionResult DeleteConhecimento(int id)
        {
            Conhecimento conhecimento = db.Conhecimento.Find(id);
            if (conhecimento == null)
            {
                return NotFound();
            }

            db.Conhecimento.Remove(conhecimento);
            db.SaveChanges();

            return Ok(conhecimento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ConhecimentoExists(int id)
        {
            return db.Conhecimento.Count(e => e.IdConhecimento == id) > 0;
        }
    }
}