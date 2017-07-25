using System;
using System.Linq;
using System.Web.Http;
using Portal.Models;

namespace Portal.Controllers.Api
{
    public class JudgeController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public JudgeController()
        {   
            _context = new ApplicationDbContext();
        }

        /// <summary>
        /// http://localhost:5920/api/segment/Add?satoriid=17dc5578-d483-f628-3fb1-5a6297a0a6c3&type=City
        /// </summary>
        /// <param name="satoriId">17dc5578-d483-f628-3fb1-5a6297a0a6c3</param>
        /// <param name="type">City, Organization, State</param>
        /// <returns>200 if okay and 400 if something is wrong</returns>
        [HttpPost]
        public IHttpActionResult Add([FromUri] string satoriId, string type)
        {
            var exists = _context.Judges.Any(s => s.SatoriId == satoriId);
            if (exists)
            {
                return BadRequest("The Judge already exists.");
            }

            Guid newSatoriId;
            if (!Guid.TryParse(satoriId, out newSatoriId))
            {
                return BadRequest("Satori ID is in incorrect format.");
            }


            Judge Judge = new Judge
            {
                SatoriId = satoriId,
                LastUpdated = DateTime.UtcNow,
            };

            _context.Judges.Add(Judge);
            _context.SaveChanges();
            return Ok();
        }

        /// <summary>
        /// http://localhost:5920/api/segment/Delete?satoriid=17dc5578-d483-f628-3fb1-5a6297a0a6c3
        /// </summary>
        /// <param name="satoriId">17dc5578-d483-f628-3fb1-5a6297a0a6c3</param>
        /// <returns>200 if successful</returns>
        [HttpDelete]
        public IHttpActionResult Delete([FromUri] string satoriId)
        {
            var segment = _context.Judges.Single(s => s.SatoriId == satoriId);
            if (segment == null)
            {
                return BadRequest("The segment does not exist.");
            }

            Guid newSatoriId;
            if (!Guid.TryParse(satoriId, out newSatoriId))
            {
                return BadRequest("Satori ID is in incorrect format.");
            }

            _context.Judges.Remove(segment);
            _context.SaveChanges();
            return Ok();
        }
    }
}
