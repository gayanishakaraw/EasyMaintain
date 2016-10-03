﻿using EasyMaintain.Business;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using EasyMaintain.DTO;

namespace EasyMaintain.MaintenanceWebAPI.Controllers
{
    public class MaintenanceController : ApiController
    {

        private MaintenanceLogic maintenanceLogic;

        public IBusiness EngineRepo { get; set; }

        public MaintenanceController(IBusiness _repo)
        {
            EngineRepo = _repo;

        }
        public MaintenanceController()
        {

        }

        // GET api/values 
        public IEnumerable<Maintenance> Get()
        {
            return (IEnumerable<Maintenance>)maintenanceLogic.GetData();
        }

        // GET api/values/5 
        public IHttpActionResult Get(int id)
        {
            var item = maintenanceLogic.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // POST api/values 
        public IHttpActionResult Post([FromBody]Maintenance maintenance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            EngineRepo.UpdateOne(maintenance);
            return CreatedAtRoute("DefaultApi", new { id = maintenance.WorkID }, maintenance);
        }

        // PUT api/values/5 
        public IHttpActionResult Put(Maintenance workID, [FromBody]Maintenance maintenance)
        {
            if (workID == null || workID.Equals(0))
            {
                return BadRequest();
            }

            else if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            maintenanceLogic.Insert(maintenance);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
            maintenanceLogic.DeleteOne(id);
        }
    }
}