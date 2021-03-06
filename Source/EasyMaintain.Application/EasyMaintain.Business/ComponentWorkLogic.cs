﻿using EasyMaintain.DataAccess;
using EasyMaintain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMaintain.Business
{
   public class ComponentWorkLogic
    {


        public ComponentWorkLogic()
        {

        }

        ComponentWork mComponentWork = new ComponentWork();

        /// <summary>
        /// Get data
        /// </summary>
        /// <returns></returns>
        public object GetData()
        {
            List<ComponentWork> result = new List<ComponentWork>();
            DataProvidor dp = new DataProvidor();

            foreach (DTO.ComponentWork componentWork in dp.GetComponentWorkData())
            {
                ComponentWork _componentWork = new ComponentWork();
                _componentWork.WorkID = componentWork.WorkID;
                _componentWork.Component = componentWork.Component;
                _componentWork.SerialNumber = componentWork.SerialNumber;
                _componentWork.FlightNumber = componentWork.FlightNumber;
                _componentWork.Description = componentWork.Description;
                _componentWork.CreatedDate = componentWork.CreatedDate;
                _componentWork.Location = componentWork.Location;
                 _componentWork.Deliverydetails = (componentWork.Deliverydetails);//todo

                result.Add(_componentWork);
            }

            return result;
        }

        public int Save(object record)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add new record
        /// </summary>
        /// <param name="componentWork"></param>
        /// <returns></returns>

        public int Insert(object componentWork)
        {
            this.mComponentWork = componentWork as ComponentWork;
            DataProvidor dp = new DataProvidor();
            return dp.AddComponentWork(mComponentWork.WorkID, mComponentWork.Component, mComponentWork.SerialNumber, mComponentWork.FlightNumber, mComponentWork.Description,mComponentWork.Deliverydetails ,mComponentWork.CreatedDate, mComponentWork.Location);

        }
        /// <summary>
        /// Delete one record
        /// </summary>
        /// <param name="componentWork"></param>
        public void DeleteOne(object componentWork)
        {
            this.mComponentWork = componentWork as ComponentWork;

            DataProvidor dp = new DataProvidor();
            dp.DeleteComponentWork(mComponentWork.WorkID);
        }
        /// <summary>
        /// Update one record
        /// </summary>
        /// <param name="componentWork"></param>
        /// <returns></returns>
        public bool UpdateOne(object componentWork)
        {
            this.mComponentWork = componentWork as ComponentWork;
            DataProvidor dp = new DataProvidor();
            return dp.UpdateComponentWork(mComponentWork.WorkID, mComponentWork.Component, mComponentWork.SerialNumber, mComponentWork.FlightNumber, mComponentWork.Description, mComponentWork.CreatedDate, mComponentWork.Location);
        }

        public ComponentWork Find(object WorkID)
        {
            List<ComponentWork> result = new List<ComponentWork>();
            return result
                .Where(e => e.WorkID.Equals(WorkID))
                .SingleOrDefault();
        }


    }
}
