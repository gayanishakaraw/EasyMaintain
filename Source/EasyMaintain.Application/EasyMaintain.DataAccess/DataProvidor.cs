﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EasyMaintain.DTO;
using System.Data.Entity;

//using EasyMaintain.Business;

namespace EasyMaintain.DataAccess
{
    public class DataProvidor
    {
        /// <summary>
        /// Get Supplier Data
        /// </summary>
        /// <returns></returns>
        ///           
        public List<Supplier> GetSupplierData()
        {
            List<Supplier> supplierList = new List<Supplier>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.Suppliers
                            orderby b.Name
                            select b;

                foreach (var item in query)
                {
                    supplierList.Add(item as Supplier);
                }
            }

            return supplierList;
        }

        /// <summary>
        /// Get Component Data
        /// </summary>
        /// <returns></returns>
        ///           
        public List<Component> GetComponentData()
        {
            List<Component> componentList = new List<Component>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.Components
                            orderby b.ComponentName
                            select b;

                foreach (var item in query)
                {
                    componentList.Add(item as Component);
                }
            }

            return componentList;
        }

        /// <summary>
        /// Get Supplier Data
        /// </summary>
        /// <returns></returns>
        ///           
        public List<Workshop> GetWorkshopData()
        {
            List<Workshop> workshopList = new List<Workshop>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.Workshops
                            orderby b.Name
                            select b;

                foreach (var item in query)
                {
                    workshopList.Add(item as Workshop);
                }
            }

            return workshopList;
        }

        /// <summary>
        /// Get Component Work data
        /// </summary>
        /// <returns></returns>
        ///          

        public List<ComponentWork> GetComponentWorkData()
        {
            List<ComponentWork> ComponentWork = new List<ComponentWork>();

            using (var db = new EasyMaintainDBContext())
            {

                var componentworks = db.ComponentWorks
                                       .Include(b => b.Deliverydetails);


                foreach (var item in componentworks)
                {

                    ComponentWork.Add(item as ComponentWork);
                }

            }


            return ComponentWork;
        }


        /// <summary>
        /// Get Maintenance check data
        /// </summary>
        /// <returns></returns>
        ///          
        public List<MaintenanceChecks> GetMaintenanceCheckData()
        {
            List<MaintenanceChecks> MaintenanceCheckList = new List<MaintenanceChecks>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.MaintenanceChecks
                            orderby b.Description
                            select b;

                foreach (var item in query)
                {
                    MaintenanceCheckList.Add(item as MaintenanceChecks);
                }
            }

            return MaintenanceCheckList;
        }

        /// <summary>
        /// Get Delivery details
        /// </summary>
        /// <returns></returns>
        ///          
        public List<DeliveryDetails> GetdeliveryDetailsData()
        {
            List<DeliveryDetails> DeliveryDetailsList = new List<DeliveryDetails>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.Deliveries
                            orderby b.DeliveryDate
                            select b;

                foreach (var item in query)
                {
                    DeliveryDetailsList.Add(item as DeliveryDetails);
                }
            }

            return DeliveryDetailsList;
        }

        /// <summary>
        /// Get Spare Parts Data
        /// </summary>
        /// <returns></returns>
        public List<SparePart> GetSparePartsData()
        {
            List<SparePart> sparePartsList = new List<SparePart>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.SpareParts
                            orderby b.SparePartName
                            select b;

                foreach (var item in query)
                {
                    sparePartsList.Add(item as SparePart);
                }
            }

            return sparePartsList;
        }

        /// <summary>
        /// Get Manufacturer Data
        /// </summary>
        /// <returns></returns>
        public List<Manufacturer> GetManufacturerData()
        {
            List<Manufacturer> manufacturer = new List<Manufacturer>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.Manufactureres
                            orderby b.Name
                            select b;

                foreach (var item in query)
                {
                    manufacturer.Add(item as Manufacturer);
                }
            }

            return manufacturer;
        }
        /// <summary>
        /// Get Crew Data
        /// </summary>
        /// <returns></returns>
        public List<Crew> GetCrewData()
        {
            List<Crew> crew = new List<Crew>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.Crews
                            orderby b.Name
                            select b;

                foreach (var item in query)
                {
                    crew.Add(item as Crew);
                }
            }

            return crew;
        }

        /// <summary>
        /// Get Aircraft Model Data
        /// </summary>
        /// <returns></returns>
        public List<AircraftModel> GetAircraftModelData()
        {
            List<AircraftModel> aircraftModel = new List<AircraftModel>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.AircraftModels
                            orderby b.ModelName
                            select b;

                foreach (var item in query)
                {
                    aircraftModel.Add(item as AircraftModel);
                }
            }

            return aircraftModel;
        }

        /// <summary>
        /// Get Category Data
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategoryData()
        {
            List<Category> category = new List<Category>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.Categories
                            orderby b.CategoryName
                            select b;

                foreach (var item in query)
                {
                    category.Add(item as Category);
                }
            }

            return category;
        }

        /// <summary>
        /// Get Maintenance Data
        /// </summary>
        /// <returns></returns>
        public List<Maintenance> GetMaintenanceData()
        {
            List<Maintenance> engineType = new List<Maintenance>();

            using (var db = new EasyMaintainDBContext())
            {
                var query = from b in db.Maintenances
                            orderby b.FlightModel
                            select b;

                foreach (var item in query)
                {
                    engineType.Add(item as Maintenance);
                }
            }

            object var = engineType;
            return engineType;
        }



        /// <summary>
        /// Get Inventory Data
        /// </summary>
        /// <returns></returns>
        public List<Inventory> GetInventoryData()
        {
            List<Inventory> inventory = new List<Inventory>();

            using (var db = new EasyMaintainDBContext())
            {

                var inventoryDetails = db.Inventories
                                       .Include(b => b.Deliverydetails);


                foreach (var item in inventoryDetails)
                {

                    inventory.Add(item as Inventory);
                }

            }
            return inventory;
        }

        /// <summary>
        /// Get Inventory Data
        /// </summary>
        /// <returns></returns>
        //public List<Inventory> GetInventoryData()
        //{
        //    List<Inventory> inventory = new List<Inventory>();

        //    using (var db = new EasyMaintainDBContext())
        //    {
        //        //var query = from b in db.Inventories
        //        //            orderby b.InventoryID
        //        //            select b;

        //        //foreach (var item in query)
        //        //{
        //        //    inventory.Add(item as Inventory);
        //        //}
        //    }

        //    return inventory;
        //}


        //--- Insert Data

        /// <summary>
        /// Add Supplier
        /// </summary>
        /// <param name="supplierName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="address"></param>
        /// <param name="contact"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>
        public int AddSupplier(string supplierName, string emailAddress, string address, string contact, string description, string additionalData)
        {
            int recordId = -1;
            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var supplier = db.Set<Supplier>();
                    supplier.Add(new Supplier { Name = supplierName, EmailAddress = emailAddress, Address = address, ContactDetails = contact, Description = description, AdditionalData = additionalData });

                    db.SaveChanges();

                    recordId = db.Set<Supplier>().LastOrDefault().SupplierID;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }



        /// <summary>
        /// Add component
        /// </summary>
        /// <param name="componentID"></param>
        /// <param name="Category"></param>
        /// <param name="ComponentName"></param>
        /// <param name="Manufacturer"></param>
        /// <param name="Description"></param>
        /// <param name="ImagePath"></param>
        /// <param name="AdditionalData"></param>
        /// <returns></returns>
        public int AddComponent(int componentID, string category, string componentName, string manufacturer, string description, string imagePath, string additionalData)
        {
            int recordId = -1;
            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var supplier = db.Set<Component>();
                    supplier.Add(new Component { ComponentID = componentID, Category = category, ComponentName = componentName, Manufacturer = manufacturer, Description = description, ImagePath = imagePath, AdditionalData = additionalData });

                    db.SaveChanges();

                    //recordId = db.Set<Supplier>().LastOrDefault().SupplierID;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }


        /// <summary>
        /// Add Manufacturer
        /// </summary>
        /// <param name="manufacturerName"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>
        public int AddManufacturer(string manufacturerName, string description, string additionalData)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var manufacturer = db.Set<Manufacturer>();
                    manufacturer.Add(new Manufacturer { Name = manufacturerName, Description = description, AdditionalData = additionalData });

                    db.SaveChanges();

                    recordId = Int32.Parse(db.Set<Manufacturer>().LastOrDefault().ManufacturerID);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }

        /// <summary>
        /// Add Workshop
        /// </summary>
        /// <param name="workshopID"></param>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="address"></param>
        /// <returns></returns>

        public int AddWorkshop(int workshopID, string name, string location, string address)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var workshop = db.Set<Workshop>();
                    workshop.Add(new Workshop { WorkshopID = workshopID, Name = name, Location = location, Address = address });

                    db.SaveChanges();

                    //recordId = Int32.Parse(db.Set<Manufacturer>().LastOrDefault().ManufacturerID);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }


        /// <summary>
        /// Add Manufacturer
        /// </summary>
        /// <param name="DeliveryDetailsId"></param>
        /// <param name="DeliveryDate"></param>
        /// <param name="DeliveryMethod"></param>
        /// <param name="PersonInCharge"></param>
        /// <param name="AddressLine1"></param>
        /// <param name="AddressLine2"></param>
        /// <param name="City"></param>
        /// <param name="State"></param>
        /// <param name="AddtionalNotes"></param>
        /// <returns></returns>
        public int AddDeliveryDetails(string deliveryDetailsId, string deliveryDate, string deliveryMethod, string personInCharge, string addressLine1, string addressLine2, string city, string state, string addtionalNotes)
        {


            // insert
            using (var db = new EasyMaintainDBContext())
            {
                var delivery = db.Set<DeliveryDetails>();
                try
                {

                    delivery.Add(new DeliveryDetails { DeliveryDetailsId = Int32.Parse(deliveryDetailsId), DeliveryDate = deliveryDate, DeliveryMethod = deliveryMethod, PersonInCharge = personInCharge, AddressLine1 = addressLine1, AddressLine2 = addressLine2, City = city, State = state, AddtionalNotes = addtionalNotes });

                    db.SaveChanges();


                }
                catch (SqlException ex)
                {
                    throw ex;
                }

                return 1;
            }
        }


        /// <summary>
        /// Add Component Work
        /// </summary>
        /// <param name="WorkID"></param>
        /// <param name="Component"></param>
        /// <param name="SerialNumber"></param>
        /// <param name="FlightNumber"></param>
        /// <param name="Description"></param>
        /// <param name="Deliverydetails"></param>
        /// <param name="CreatedDate"></param>
        /// <param name="Location"></param>
        /// <returns></returns>
        public int AddComponentWork(int workID, string component, string serialNumber, string flightNumber, string description, DeliveryDetails deliveryDetails, string createdDate, string location)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var componentwork = db.Set<ComponentWork>();
                    componentwork.Add(new ComponentWork { WorkID = workID, Component = component, SerialNumber = serialNumber, FlightNumber = flightNumber, Description = description, Deliverydetails = deliveryDetails, CreatedDate = createdDate, Location = location });

                    db.SaveChanges();

                    // recordId = (db.Set<ComponentWork>().LastOrDefault().WorkID);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }


        /// <summary>
        /// Add Inventory
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <param name="CustomerName"></param>
        /// <param name="CompanyName"></param>
        /// <param name="AdditionalNotes"></param>
        /// <param name="PartsList"></param>
        /// <param name="InvoiceNumber"></param>
        /// <param name="PaymentMethod"></param>
        /// <param name="PaymentNotes"></param>
        /// <param name="BillingAddress"></param>
        /// <param name="BillingName"></param>
        /// <param name="OrderType"></param>
        /// <param name="Deliverydetails"></param>
        /// <returns></returns>
        public int AddInventory(int customerID, string customerName, string companyName, string additionalNotes, List<string> partsList, int invoiceNumber, string paymentMethod, string paymentNotes, string billingAddress, string billingName, bool orderType, DeliveryDetails deliveryDetails)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var inventory = db.Set<Inventory>();
                    inventory.Add(new Inventory { CustomerID = customerID, CustomerName = customerName, CompanyName = companyName, AdditionalNotes = additionalNotes, PartsList = partsList, InvoiceNumber = invoiceNumber, PaymentMethod = paymentMethod, PaymentNotes = paymentNotes, BillingAddress = billingAddress, BillingName = billingName, OrderType = orderType, Deliverydetails = deliveryDetails });

                    db.SaveChanges();

                    // recordId = (db.Set<ComponentWork>().LastOrDefault().WorkID);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }


        /// <summary>
        /// Add MaintenanceChecks
        /// </summary>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public int AddMaintenanceChecks(string description, bool status)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var maintenanceChecks = db.Set<MaintenanceChecks>();
                    maintenanceChecks.Add(new MaintenanceChecks { Description = description, status = status });

                    db.SaveChanges();

                    // recordId = Int32.Parse(db.Set<MaintenanceChecks>().LastOrDefault().Description);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }


        public int AddCrew(string name, string designation)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var crew = db.Set<Crew>();
                    crew.Add(new Crew { Name = name, Designation = designation });

                    db.SaveChanges();

                    // recordId = Int32.Parse(db.Set<Crew>().LastOrDefault().Name);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }

        /// <summary>
        /// Add Category
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>
        public int AddCategory(string categoryName, string additionalData)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var category = db.Set<Category>();
                    category.Add(new Category { CategoryName = categoryName, AdditionalData = additionalData });

                    db.SaveChanges();

                    recordId = db.Set<Category>().LastOrDefault().CategoryID;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }

        /// <summary>
        /// Add Maintenance
        /// </summary>
        /// <param name="engineTypeName"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>
        public int AddMaintenance(int workID, string flightModel, string flightNumber, string description, string startDate, string completionDate, string location)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var maintenance = db.Set<Maintenance>();
                    int record = maintenance.Add(new Maintenance { WorkID = workID, FlightModel = flightModel, FlightNumber = flightNumber, Description = description, StartDate = startDate, CompletionDate = completionDate, Location = location }).WorkID;

                    db.SaveChanges();

                    //recordId = db.Set<EngineType>().LastOrDefault().WorkID;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }

        /// <summary>
        /// Add Aircraft Model
        /// </summary>
        /// <param name="aircraftModelname"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <param name="categoryID"></param>
        /// <param name="engineTypeId"></param>
        /// <param name="manufacturerId"></param>
        /// <param name="imagepath"></param>
        /// <returns></returns>
        public int AddAircraftModel(string aircraftModelname,string manufacturer, string description, string additionalData, string category, string engineType, string imagepath)
        {
            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var aircraftModel = db.Set<AircraftModel>();
                    aircraftModel.Add(new AircraftModel { ModelName = aircraftModelname, Manufacturer= manufacturer, Category = category, EngineType = engineType, ImagePath = imagepath, Description = description, AdditionalData = additionalData });

                    db.SaveChanges();

                    //recordId = db.Set<AircraftModel>().LastOrDefault().AircraftModelID;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }

        /// <summary>
        /// Add Spare Part
        /// </summary>
        /// <param name="sparePartName"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <param name="categoryID"></param>
        /// <param name="imagepath"></param>
        /// <returns></returns>
        public int AddSparePart(string sparePartName, string description, string additionalData, Category category, string imagepath)
        {

            int recordId = -1;

            // insert
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var sparePart = db.Set<SparePart>();
                    sparePart.Add(new SparePart { SparePartName = sparePartName, Category = category, ImagePath = imagepath, Description = description, AdditionalData = additionalData });

                    db.SaveChanges();

                    //recordId = db.Set<SparePart>().LastOrDefault().SparePartID;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return recordId;
        }

        //---- Update Data

        /// <summary>
        /// Update Supplier
        /// </summary>
        /// <param name="supplierId"></param>
        /// <param name="supplierName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="address"></param>
        /// <param name="contact"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>
        public bool UpdateSupplier(int supplierId, string supplierName, string emailAddress, string address, string contact, string description, string additionalData)
        {
            bool result = false;
            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var supplier = db.Suppliers.SingleOrDefault(s => s.SupplierID == supplierId);

                    if (supplier != null)
                    {
                        supplier.Name = supplierName;
                        supplier.EmailAddress = emailAddress;
                        supplier.Address = address;
                        supplier.ContactDetails = contact;
                        supplier.Description = description;
                        supplier.AdditionalData = additionalData;
                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        /// <summary>
        /// Update Component
        /// </summary>
        /// <param name="ComponentID"></param>
        /// <param name="Category"></param>
        /// <param name="ComponentName"></param>
        /// <param name="Manufacturer"></param>
        /// <param name="Description"></param>
        /// <param name="ImagePath"></param>
        /// <param name="AdditionalData"></param>
        /// <returns></returns>
        public bool UpdateComponent(int componentID, string category, string componentName, string manufacturer, string description, string imagePath, string additionalData)
        {
            bool result = false;
            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var component = db.Components.SingleOrDefault(s => s.ComponentID == componentID);

                    if (component != null)
                    {
                        component.ComponentID = componentID;
                        component.Category = category;
                        component.ComponentName = componentName;
                        component.Manufacturer = manufacturer;
                        component.Description = description;
                        component.ImagePath = imagePath;
                        component.AdditionalData = additionalData;


                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }



        /// <summary>
        /// Update Manufacturer
        /// </summary>
        /// <param name="manufacturerId"></param>
        /// <param name="manufacturerName"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>
        public bool UpdateManufacturer(int manufacturerId, string manufacturerName, string description, string additionalData)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var manufacturer = db.Manufactureres.SingleOrDefault(s => s.ManufacturerID.Equals(manufacturerId));

                    if (manufacturer != null)
                    {
                        manufacturer.Name = manufacturerName;
                        manufacturer.Description = description;
                        manufacturer.AdditionalData = additionalData;
                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        /// <summary>
        /// Update Manufacturer
        /// </summary>
        /// <param name="DeliveryDetailsId"></param>
        /// <param name="DeliveryDate"></param>
        /// <param name="DeliveryMethod"></param>
        /// <param name="PersonInCharge"></param>
        /// <param name="AddressLine1"></param>
        /// <param name="AddressLine2"></param>
        /// <param name="City"></param>
        /// <param name="State"></param>
        /// <param name="AddtionalNotes"></param>
        /// <returns></returns>
        public bool UpdateDeliveryDetails(string deliveryDetailsId, string deliveryDate, string deliveryMethod, string personInCharge, string addressLine1, string addressLine2, string city, string state, string addtionalNotes)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var delivery = db.Deliveries.SingleOrDefault(s => s.DeliveryDetailsId.Equals(deliveryDetailsId));

                    if (delivery != null)
                    {
                        delivery.DeliveryDetailsId = Int32.Parse(deliveryDetailsId);
                        delivery.DeliveryDate = deliveryDate;
                        delivery.DeliveryMethod = deliveryMethod;
                        delivery.PersonInCharge = personInCharge;
                        delivery.AddressLine1 = addressLine1;
                        delivery.AddressLine2 = addressLine2;
                        delivery.City = city;
                        delivery.State = state;
                        delivery.AddtionalNotes = addtionalNotes;
                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }




        /// <summary>
        /// Update Maintenance Checks
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="status"></param>

        /// <returns></returns>

        public bool UpdateMaintenanceChecks(int maintenanceCheckID, string description, bool status)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var maintenanceCheck = db.MaintenanceChecks.SingleOrDefault(s => s.MaintenanceCheckID.Equals(maintenanceCheckID));

                    if (maintenanceCheck != null)
                    {
                        maintenanceCheck.Description = description;
                        maintenanceCheck.status = status;

                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }


        /// <summary>
        /// Update Manufacturer
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Designation"></param>
        /// <returns></returns>

        public bool UpdateCrew(int ID,string name, string designation)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var crew = db.Crews.SingleOrDefault(s => s.CrewID.Equals(ID));

                    if (crew != null)
                    {
                        crew.Name = name;
                        crew.Designation = designation;
                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        /// <summary>
        /// Update Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="categoryName"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>
        public bool UpdateCategory(int categoryId, string categoryName, string additionalData)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var category = db.Categories.SingleOrDefault(s => s.CategoryID == categoryId);

                    if (category != null)
                    {
                        category.CategoryName = categoryName;
                        category.AdditionalData = additionalData;
                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
            return result;
        }

        /// <summary>
        /// Update Engine Type
        /// </summary>
        /// <param name="engineTypeId"></param>
        /// <param name="engineTypeName"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>
        public bool UpdateMaintenance(int workID, string FlightModel, string FlightNumber, string additionalData, string StartDate, string CompletionDate, string Location)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var engineType = db.Maintenances.SingleOrDefault(s => s.WorkID.Equals(workID));

                    if (engineType != null)
                    {
                        engineType.FlightModel = FlightModel;
                        engineType.FlightNumber = FlightNumber;
                        engineType.Description = additionalData;
                        engineType.StartDate = StartDate;
                        engineType.CompletionDate = CompletionDate;
                        engineType.Location = Location;
                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        /// <summary>
        /// Update Engine Type
        /// </summary>
        /// <param name="engineTypeId"></param>
        /// <param name="engineTypeName"></param>
        /// <param name="additionalData"></param>
        /// <returns></returns>

        public bool UpdateWorkshop(int workshopID, string name, string location, string address)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var workshop = db.Workshops.SingleOrDefault(s => s.WorkshopID.Equals(workshopID));

                    if (workshop != null)
                    {
                        workshop.WorkshopID = workshopID;
                        workshop.Name = name;
                        workshop.Location = location;
                        workshop.Address = address;
                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }


        /// <summary>
        /// Update inventory
        /// </summary>
        /// <param name = "CustomerID" ></ param >
        /// <param name="CustomerName"></param>
        /// <param name="CompanyName"></param>
        /// <param name="AdditionalNotes"></param>
        /// <param name="PartsList"></param>
        /// <param name="InvoiceNumber"></param>
        /// <param name="PaymentMethod"></param>
        /// <param name="PaymentNotes"></param>
        /// <param name="BillingAddress"></param>
        /// <param name="BillingName"></param>
        /// <param name="OrderType"></param>
        /// <param name="Deliverydetails"></param>
        /// <returns></returns>
        public bool UpdateInventory(int customerID, string customerName, string companyName, string additionalNotes, List<string> partsList, int invoiceNumber, string paymentMethod, string paymentNotes, string billingAddress, string billingName, bool orderType, DeliveryDetails deliveryDetails)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var inventory = db.Inventories.SingleOrDefault(s => s.CustomerID.Equals(customerID));

                    if (inventory != null)
                    {
                        inventory.CustomerID = customerID;
                        inventory.CustomerName = customerName;
                        inventory.CompanyName = companyName;
                        inventory.AdditionalNotes = additionalNotes;
                        inventory.PartsList = partsList;
                        inventory.InvoiceNumber = invoiceNumber;
                        inventory.PaymentMethod = paymentMethod;
                        inventory.PaymentNotes = paymentNotes;
                        inventory.BillingAddress = billingAddress;
                        inventory.BillingName = billingName;
                        inventory.OrderType = orderType;
                        inventory.Deliverydetails = deliveryDetails;

                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }


        /// <summary>
        /// Update Aircraft Model 
        /// </summary>
        /// <param name="aircraftModleId"></param>
        /// <param name="aircraftModelname"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <param name="categoryID"></param>
        /// <param name="engineTypeId"></param>
        /// <param name="manufacturerId"></param>
        /// <param name="imagepath"></param>
        /// <returns></returns>
        public bool UpdateAircraftModel(int aircraftModleId, string aircraftModelname, string description, string additionalData, string category, string engineType, string manufacturer, string imagepath)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var aircraftModel = db.AircraftModels.SingleOrDefault(s => s.AircraftModelID == aircraftModleId);

                    if (aircraftModel != null)
                    {
                        aircraftModel.ModelName = aircraftModelname;
                        aircraftModel.Category = category;
                        aircraftModel.EngineType = engineType;
                        aircraftModel.Manufacturer = manufacturer;
                        aircraftModel.ImagePath = imagepath;
                        aircraftModel.Description = description;
                        aircraftModel.AdditionalData = additionalData;
                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }

            }

            return result;
        }

        /// <summary>
        /// Update Component Work 
        /// </summary>
        /// <param name="aircraftModleId"></param>
        /// <param name="aircraftModelname"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <param name="categoryID"></param>
        /// <param name="engineTypeId"></param>
        /// <param name="manufacturerId"></param>
        /// <param name="imagepath"></param>
        /// <returns></returns>
        public bool UpdateComponentWork(int workID, string component, string serialNumber, string flightNumber, string description, string createdDate, string location)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var componentWork = db.ComponentWorks.SingleOrDefault(s => s.WorkID == workID);

                    if (componentWork != null)
                    {
                        componentWork.Component = component;
                        componentWork.SerialNumber = serialNumber;
                        componentWork.FlightNumber = flightNumber;
                        componentWork.Description = description;
                        componentWork.CreatedDate = createdDate;
                        componentWork.Location = location;

                    }
                    db.SaveChanges();
                    result = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        /// <summary>
        /// Update Spare Part
        /// </summary>
        /// <param name="sparePartId"></param>
        /// <param name="sparePartName"></param>
        /// <param name="description"></param>
        /// <param name="additionalData"></param>
        /// <param name="categoryID"></param>
        /// <param name="imagepath"></param>
        /// <returns></returns>
        public bool UpdateSparePart(int sparePartId, string sparePartName, string description, string additionalData, Category category, string imagepath)
        {
            bool result = false;

            // update
            using (var db = new EasyMaintainDBContext())
            {
                try
                {
                    var sparePart = db.SpareParts.SingleOrDefault(s => s.SparePartID == sparePartId);

                    if (sparePart != null)
                    {
                        sparePart.SparePartName = sparePartName;
                        sparePart.Category = category;
                        sparePart.ImagePath = imagepath;
                        sparePart.Description = description;
                        sparePart.AdditionalData = additionalData;
                    }
                    db.SaveChanges();
                    result = true;

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        //--- Delete Data

        /// <summary>
        /// Delete Supplier
        /// </summary>
        /// <param name="supplierId"></param>
        public void DeleteSupplier(int supplierId)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var supplier = db.Suppliers.SingleOrDefault(s => s.SupplierID == supplierId);
                db.Suppliers.Attach(supplier);
                db.Suppliers.Remove(supplier);
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Delete Maintenance checks
        /// </summary>
        /// <param name="componentId"></param>
        public void DeleteMaintenanceChecks(int maintenanceCheckID)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var maintenanceChecks = db.MaintenanceChecks.SingleOrDefault(s => s.MaintenanceCheckID.Equals(maintenanceCheckID));
                db.MaintenanceChecks.Attach(maintenanceChecks);
                db.MaintenanceChecks.Remove(maintenanceChecks);
                db.SaveChanges();
            }
        }





        /// <summary>
        /// Delete Component
        /// </summary>
        /// <param name="componentId"></param>
        public void DeleteComponent(int componentId)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var component = db.Components.SingleOrDefault(s => s.ComponentID.Equals(componentId));
                db.Components.Attach(component);
                db.Components.Remove(component);
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Delete Manufacturer 
        /// </summary>
        /// <param name="manufacturerId"></param>
        public void DeleteManufacturer(int manufacturerId)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var manufacturer = db.Manufactureres.SingleOrDefault(s => s.ManufacturerID.Equals(manufacturerId));
                db.Manufactureres.Attach(manufacturer);
                db.Manufactureres.Remove(manufacturer);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete Component Work 
        /// </summary>
        /// <param name="WorkID"></param>
        public void DeleteComponentWork(int workId)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var component = db.ComponentWorks.SingleOrDefault(s => s.WorkID.Equals(workId));
                db.ComponentWorks.Attach(component);
                db.ComponentWorks.Remove(component);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Delete Manufacturer 
        /// </summary>
        /// <param name="Name"></param>
        public void DeleteCrew(String name)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var crew = db.Crews.SingleOrDefault(s => s.Name.Equals(name));
                db.Crews.Attach(crew);
                db.Crews.Remove(crew);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete delivery details
        /// </summary>
        /// <param name="Name"></param>
        public void DeleteDeliveryDetails(String id)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var delivery = db.Deliveries.SingleOrDefault(s => s.DeliveryDetailsId.Equals(id));
                db.Deliveries.Attach(delivery);
                db.Deliveries.Remove(delivery);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <param name="categoryId"></param>
        public void DeleteCategory(int categoryId)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var category = db.Categories.SingleOrDefault(s => s.CategoryID == categoryId);
                db.Categories.Attach(category);
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete Maintenance
        /// </summary>
        /// <param name="workId"></param>
        public void DeleteMaintenance(int workID)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var engineType = db.Maintenances.SingleOrDefault(s => s.WorkID.Equals(workID));
                db.Maintenances.Attach(engineType);
                db.Maintenances.Remove(engineType);
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Delete Maintenance
        /// </summary>
        /// <param name="workshopID"></param>

        public void DeleteWorkshop(int workshopID)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var workshop = db.Workshops.SingleOrDefault(s => s.WorkshopID.Equals(workshopID));
                db.Workshops.Attach(workshop);
                db.Workshops.Remove(workshop);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete Inventory
        /// </summary>
        /// <param name="customerId"></param>
        public void DeleteInventory(int customerId)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var inventory = db.Inventories.SingleOrDefault(s => s.CustomerID.Equals(customerId));
                db.Inventories.Attach(inventory);
                db.Inventories.Remove(inventory);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete Aircraft Model 
        /// </summary>
        /// <param name="aircraftModleId"></param>
        public void DeleteAircraftModel(int aircraftModleId)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var aircraftModel = db.AircraftModels.SingleOrDefault(s => s.AircraftModelID == aircraftModleId);
                db.AircraftModels.Attach(aircraftModel);
                db.AircraftModels.Remove(aircraftModel);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete Spare Part
        /// </summary>
        /// <param name="sparePartId"></param>
        public void DeleteSparePart(int sparePartId)
        {
            // Delete
            using (var db = new EasyMaintainDBContext())
            {
                var sparePart = db.SpareParts.SingleOrDefault(s => s.SparePartID == sparePartId);
                db.SpareParts.Attach(sparePart);
                db.SpareParts.Remove(sparePart);
                db.SaveChanges();
            }
        }
    }
}
