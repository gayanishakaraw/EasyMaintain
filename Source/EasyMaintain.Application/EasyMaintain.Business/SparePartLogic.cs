﻿using EasyMaintain.DataAccess;
using EasyMaintain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMaintain.DTO;

namespace EasyMaintain.Business
{
   public class SparePartLogic
    {
        SparePart mSparePart;
        public SparePartLogic()
        {


        }

        /// <summary>
        /// Get data
        /// </summary>
        /// <returns></returns>
        public object GetData()
        {
            List<SparePart> result = new List<SparePart>();
            DataProvidor dp = new DataProvidor();

            foreach (DTO.SparePart sparePart in dp.GetSparePartsData())
            {
                SparePart _sparePart = new SparePart();

                _sparePart.SparePartID = sparePart.SparePartID;
                _sparePart.Category = new Category() { CategoryID = (int)sparePart.Category.CategoryID, AdditionalData = sparePart.Category.AdditionalData };
                _sparePart.SparePartName = sparePart.SparePartName;
                _sparePart.Description = sparePart.Description;
                _sparePart.ImagePath = sparePart.ImagePath;
                _sparePart.AdditionalData = sparePart.AdditionalData;

                result.Add(_sparePart);
            }

            return result;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="sparePart"></param>
        /// <returns></returns>
        public int Save(object sparePart)
        {
            //TODO
            this.mSparePart = sparePart as SparePart;
            return -1;
        }

        /// <summary>
        /// Add new record
        /// </summary>
        /// <param name="sparePart"></param>
        /// <returns></returns>
        public int Insert(object sparePart)
        {
            this.mSparePart = sparePart as SparePart;
            DataProvidor dp = new DataProvidor();
            return dp.AddSparePart(mSparePart.SparePartName, mSparePart.Description, mSparePart.AdditionalData, mSparePart.Category, mSparePart.ImagePath);
        }

        /// <summary>
        /// Delete one record
        /// </summary>
        /// <param name="sparePart"></param>
        public void DeleteOne(object sparePart)
        {
            this.mSparePart = sparePart as SparePart;
            DataProvidor dp = new DataProvidor();
            dp.DeleteSparePart(mSparePart.SparePartID);
        }
        public SparePart Find(object sparePartID)
        {
            List<SparePart> result = new List<SparePart>();
            return result
                .Where(e => e.SparePartID.Equals(sparePartID))
                .SingleOrDefault();
        }

        /// <summary>
        /// Update one record
        /// </summary>
        /// <param name="sparePart"></param>
        /// <returns></returns>
        public bool UpdateOne(object sparePart)
        {
            this.mSparePart = sparePart as SparePart;
            DataProvidor dp = new DataProvidor();
            return dp.UpdateSparePart(mSparePart.SparePartID, mSparePart.SparePartName, mSparePart.Description, mSparePart.AdditionalData, mSparePart.Category, mSparePart.ImagePath);
        }


    }
}
