﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyMaintain.CoreWebMVC.Models;
namespace EasyMaintain.CoreWebMVC.Utility
{
    public static class SessionUtility
    {
        public static string SparePartsModel = "SparePartsModel";
        public static string ComponentWorkModel = "ComponentWorkModel";
        public static string Frame_1 = "#frame_1";
        public static string Frame_2 = "#frame_2";
        public static string Frame_3 = "#frame_3";
        public static string Frame_4 = "#frame_4";
        public static string Frame_5 = "#frame_5";
        public static ComponentWorkModel utilityComponentWorkModel = new ComponentWorkModel();
        public static MaintenanceViewModel utilityMaintenanceViewModel = new MaintenanceViewModel();
        public static InventoryViewModel utilityInventoryViewModel = new InventoryViewModel();

        public static int CurrentMaintenanceID { get; set; }
    }
}