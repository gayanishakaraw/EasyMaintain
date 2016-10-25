﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyMaintain.CoreWebMVC.DataEntities;
using EasyMaintain.CoreWebMVC.Utility;
using Newtonsoft.Json;
using System.Net;
using System.IO;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyMaintain.CoreWebMVC.Models
{
    public class RolesController : Controller
    {
        RoleViewModel RolesViewModel = SessionUtility.utilityRoleModel;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(RolesViewModel);
        }

        [HttpPost, Route("/Role/createNewMember")]
        public PartialViewResult createNewMember([FromBody]Role Model)
        {
            int finalIndex = (RolesViewModel.Roles.Count) - 1;
            Model.RoleID = RolesViewModel.Roles[finalIndex].RoleID + 1;
            // CrewViewModel.CrewList.Add(Model);
            try
            {

                string crewData = JsonConvert.SerializeObject(Model);

                this.PostAsync("http://localhost:8961/api/Crew/", crewData);
                RolesViewModel.Roles.Add(Model);
            }
            catch (AggregateException e)
            {
            }

            return PartialView("_RoleModel", RolesViewModel);

        }


        public void PostAsync(string uri, string data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            //model.PostData = "Test";
            request.ContentType = "application/json";

            using (var sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(data);
                sw.Flush();
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }

        [HttpPost, Route("/Role/saveEditedMember")]
        public PartialViewResult saveEditedMember([FromBody]Role Model)
        {
            Model.RoleID = RolesViewModel.RoleID;
            RolesViewModel.Roles[RolesViewModel.currentIndex] = Model;
            ClearSession();
            return PartialView("_RoleModel", RolesViewModel);

        }

        [HttpPost, Route("/Role/deleteMember")]
        public PartialViewResult deleteMember()
        {

            for (int x = RolesViewModel.currentIndex; x <= RolesViewModel.Roles.Count - 2; x++)
            {
                int nextIndex = x + 1;
                RolesViewModel.Roles[x] = RolesViewModel.Roles[nextIndex];
            }

            int finalIndex = RolesViewModel.Roles.Count - 1;
            RolesViewModel.Roles.RemoveAt(finalIndex);

            ClearSession();

            return PartialView("_RoleModel", RolesViewModel);

        }

        [HttpPost, Route("/Role/EditMember")]
        public PartialViewResult EditMember([FromBody]Role ID)
        {

            Role item = RolesViewModel.Roles.Single(r => r.RoleID == ID.RoleID);
            RolesViewModel.currentIndex = RolesViewModel.Roles.FindIndex(r => r.RoleID == ID.RoleID);
            RolesViewModel.RoleID = item.RoleID;
            RolesViewModel.Name = item.Name;

            return PartialView("_RoleModel", RolesViewModel);

        }

        [HttpPost, Route("/Role/cancel")]
        public PartialViewResult cancel()
        {
            ClearSession();

            return PartialView("_RoleModel", RolesViewModel);

        }

        public void ClearSession()
        {
            RolesViewModel.RoleID = 0;
            RolesViewModel.Name = null;
        }
    }
}