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

namespace API.Controllers
{
    public class AccountController : ApiController
    {
        private SCMSEntities db = new SCMSEntities();

        public string Login(LoginModel login)
        {
            return null;
        }

        // GET: api/Account
        public IEnumerable<CM_Account> GetCM_Account()
        {
            return db.CM_Account;
        }

        // GET: api/Account/5
        [ResponseType(typeof(CM_Account))]
        public async Task<IHttpActionResult> GetCM_Account(Guid id)
        {
            CM_Account cM_Account = await db.CM_Account.FindAsync(id);
            if (cM_Account == null)
            {
                return NotFound();
            }

            return Ok(cM_Account);
        }

        // PUT: api/Account/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCM_Account(Guid id, CM_Account cM_Account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cM_Account.Id)
            {
                return BadRequest();
            }

            db.Entry(cM_Account).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CM_AccountExists(id))
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

        // POST: api/Account
        [ResponseType(typeof(CM_Account))]
        public async Task<IHttpActionResult> PostCM_Account(CM_Account cM_Account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CM_Account.Add(cM_Account);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CM_AccountExists(cM_Account.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cM_Account.Id }, cM_Account);
        }

        // DELETE: api/Account/5
        [ResponseType(typeof(CM_Account))]
        public async Task<IHttpActionResult> DeleteCM_Account(Guid id)
        {
            CM_Account cM_Account = await db.CM_Account.FindAsync(id);
            if (cM_Account == null)
            {
                return NotFound();
            }

            db.CM_Account.Remove(cM_Account);
            await db.SaveChangesAsync();

            return Ok(cM_Account);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CM_AccountExists(Guid id)
        {
            return db.CM_Account.Count(e => e.Id == id) > 0;
        }
    }
}