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
using Passion.Models;

namespace Passion.Controllers
{
    public class PetDtoController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/PetDto
        public IQueryable<PetDto> GetPetDtoes()
        {
            return db.PetDtoes;
        }

        // GET: api/PetDto/5
        [ResponseType(typeof(PetDto))]
        public IHttpActionResult GetPetDto(int id)
        {
            PetDto petDto = db.PetDtoes.Find(id);
            if (petDto == null)
            {
                return NotFound();
            }

            return Ok(petDto);
        }

        // PUT: api/PetDto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPetDto(int id, PetDto petDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != petDto.PetID)
            {
                return BadRequest();
            }

            db.Entry(petDto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetDtoExists(id))
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

        // POST: api/PetDto
        [ResponseType(typeof(PetDto))]
        public IHttpActionResult PostPetDto(PetDto petDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PetDtoes.Add(petDto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = petDto.PetID }, petDto);
        }

        // DELETE: api/PetDto/5
        [ResponseType(typeof(PetDto))]
        public IHttpActionResult DeletePetDto(int id)
        {
            PetDto petDto = db.PetDtoes.Find(id);
            if (petDto == null)
            {
                return NotFound();
            }

            db.PetDtoes.Remove(petDto);
            db.SaveChanges();

            return Ok(petDto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PetDtoExists(int id)
        {
            return db.PetDtoes.Count(e => e.PetID == id) > 0;
        }
    }
}