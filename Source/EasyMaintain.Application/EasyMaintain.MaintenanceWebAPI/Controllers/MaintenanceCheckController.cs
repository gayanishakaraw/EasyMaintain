﻿using EasyMaintain.Business;
using EasyMaintain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace EasyMaintain.MaintenanceWebAPI.Controllers
{
   public class MaintenanceCheckController: ApiController
    {

        MaintenanceChecksLogic maintenanceChecksLogic = new MaintenanceChecksLogic();

        public MaintenanceCheckController()
        {

        }

        // GET api/MaintenanceCheck
        [HttpGet]
        public IEnumerable<MaintenanceChecks> Get()
        {
            return (IEnumerable<MaintenanceChecks>)maintenanceChecksLogic.GetData();
        }


        // GET api/MaintenanceChecks/5 
        //public IHttpActionResult GetID(int id)
        //{
        //    var item = maintenanceChecksLogic.Find(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(item);
        //}

        // POST api/MaintenanceCheck
        [HttpPost]
        public IHttpActionResult Post(MaintenanceChecks maintenanceChecks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            maintenanceChecksLogic.Insert(maintenanceChecks);

            return CreatedAtRoute("DefaultApi", new { id = maintenanceChecks.MaintenanceCheckID }, maintenanceChecks);
        }

        // PUT api/MaintenanceCheck/5 
        [HttpPut]
        public IHttpActionResult Put(MaintenanceChecks mainteneceCheckID, [FromBody]MaintenanceChecks maintenanceCheck)
        {
            if (mainteneceCheckID == null || mainteneceCheckID.Equals(0))
            {
                return BadRequest();
            }

            else if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            maintenanceChecksLogic.UpdateOne(maintenanceCheck);
            return StatusCode(HttpStatusCode.NoContent);
        }
        // DELETE api/MaintenanceCheck/5 
        [HttpDelete]
        public void Delete(int id)
        {
            maintenanceChecksLogic.DeleteOne(id);
        }




    }
}
