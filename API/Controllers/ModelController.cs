using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using API.Models;
using Newtonsoft.Json;

namespace API.Controllers
{
    [RoutePrefix("api/model")]
    public class ModelController : ApiController
    {
        private SCMSEntities db = new SCMSEntities();
        [HttpGet]
        [Route("getname")]
        public HttpResponseMessage Get()
        {
            try
            {
                var obj = db.Proc_FindAll_CM_Model().ToList();
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(obj));
                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        // GET: api/Model
        public IQueryable<CM_Model> GetCM_Model()
        {
            return db.CM_Model;
        }

        // GET: api/Model/5
        [ResponseType(typeof(CM_Model))]
        public async Task<IHttpActionResult> GetCM_Model(int id)
        {
            CM_Model cM_Model = await db.CM_Model.FindAsync(id);
            if (cM_Model == null)
            {
                return NotFound();
            }

            return Ok(cM_Model);
        }

        // PUT: api/Model/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCM_Model(int id, CM_Model cM_Model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cM_Model.id)
            {
                return BadRequest();
            }

            db.Entry(cM_Model).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CM_ModelExists(id))
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

        // POST: api/Model
        [ResponseType(typeof(CM_Model))]
        public async Task<IHttpActionResult> PostCM_Model(CM_Model cM_Model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CM_Model.Add(cM_Model);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cM_Model.id }, cM_Model);
        }

        // DELETE: api/Model/5
        [ResponseType(typeof(CM_Model))]
        public async Task<IHttpActionResult> DeleteCM_Model(int id)
        {
            CM_Model cM_Model = await db.CM_Model.FindAsync(id);
            if (cM_Model == null)
            {
                return NotFound();
            }

            db.CM_Model.Remove(cM_Model);
            await db.SaveChangesAsync();

            return Ok(cM_Model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CM_ModelExists(int id)
        {
            return db.CM_Model.Count(e => e.id == id) > 0;
        }
    }
}