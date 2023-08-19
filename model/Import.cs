using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebShipping.Models
{
    public class Import
    {
        private static string Config = @"Data Source=SAMY;Initial Catalog=ForwarderDB;Integrated Security=True;Connection Timeout=30;";

        [Display(Name = "Shipper")]
        public int shipperId { get; set; }

        [Display(Name = "ShipperName")]
        public string shipperName { get; set; }


        [Display(Name = "Number")]
        public int Number { get; set; }

        [Display(Name = "Date")]
        public string Date { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Transport Type")]
        public string TransportType { get; set; }

        [Display(Name = "MAWB/MBL")]
        public string Mawb { get; set; }

        [Display(Name = "HAWB/HBL")]
        public string HAWB { get; set; }

        [Display(Name = "Shipper")]
        public string Shipper { get; set; }

        [Display(Name = "Consignee")]
        public string Consignee { get; set; }
        
        [Display(Name = "Refer")]
        public string Refer { get; set; }

        [Display(Name = "ETD")]
        public string ETD { get; set; }

        [Display(Name = "POL/APL")]
        public string POL { get; set; }

        [Display(Name = "POD/APD")]
        public string POD { get; set; }

        [Display(Name = "Incoterm")]
        public string Incoterm { get; set; }

        [Display(Name = "Flight/VesselNumber")]
        public string FlightNumber { get; set; }

        [Display(Name = "VesselName")]
        public string VesselName { get; set; }

        [Display(Name = "ETA")]
        public string ETA { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        [Display(Name = "Pkgs")]
        public Int16 Pkgs { get; set; }

        [Display(Name = "Kgs")]
        public decimal Kgs { get; set; }

        [Display(Name = "Cbm")]
        public decimal Cbm { get; set; }        

        public List<Import> LoadShipment()
        {
            SqlConnection db = new SqlConnection(Config);
            string query = "select sh.shipment_num as [Num],"+
		                   "convert(varchar(11),sh.creation_date,106)as [Date],"+
		                   "sh.shipment_state as [State],"+
	                       "(select transport_type_name from dbo.transport_type where transport_type_id=shipment_transport)as [Type],"+
	                       "(case when sh.shipment_transport=2 then tr.MAWB else tr.OBL end)as [Mawb/MBL],sh.shipment_HAWB as [HAWB/HBL],"+
                           "(select contact_name from dbo.contact where contact_id=sh.shimpent_shipper)as [Shipper],"+
                           "(select contact_name from dbo.contact where contact_id=sh.shimpent_consignee)as [Consignee],"+
                           "sh.order_reference as [Refer],"+
                           "convert(varchar(11),tr.start_date,106)as [ETD],"+
                           "(select port_name from dbo.port where port_id=tr.portoflading)as [POL/APL],"+
                           "(select port_name from dbo.port where port_id=tr.portofdestination)as [POD/APD],"+
                           "sh.shipment_incoterm as [Incoterm],"+
                           "tr.fligh_ship_num as [Flight/Vessel Number],"+
                           "tr.ship_name as [Vessel Name],"+
                           "(case when tr.travel_transport=2 then convert(varchar(11),tr.real_arrival_date,106)"+ 
		                   "when tr.travel_transport=3 then convert(varchar(11),tr.expected_arrival_date,106) end)as ETA,"+
                           "(select contact_name from dbo.contact where contact_id=tr.company)as Company,"+
                           "sh.shipment_no_of_packages as [Pkgs],"+
                           "sh.shipment_weight as [Kgs],"+
                           "sh.shipment_volume as [Cbm]"+       
                           "from dbo.shipment sh,dbo.travel tr where tr.travel_id=sh.travel_id";

            SqlCommand cmd = new SqlCommand(query, db);

            //cmd.Parameters.Add(new SqlParameter("@u", SqlDbType.VarChar)).Value = userId;

            db.Open();

            List<Import> list = new List<Import>();
            using (IDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Import obj = new Import();
                    if (dataReader["State"] != DBNull.Value)
                    {
                        if (dataReader["Num"] != DBNull.Value)
                        {
                            obj.Number = (int)dataReader["Num"];
                        }
                        if (dataReader["Date"] != DBNull.Value)
                        {
                            obj.Date = (string)dataReader["Date"];
                        }
                        if (dataReader["State"] != DBNull.Value)
                        {
                            obj.State = (string)dataReader["State"];
                        }
                        if (dataReader["Type"] != DBNull.Value)
                        {
                            obj.TransportType = (string)dataReader["Type"];
                        }
                        if (dataReader["Mawb/MBL"] != DBNull.Value)
                        {
                            obj.Mawb = (string)dataReader["Mawb/MBL"];
                        }
                        if (dataReader["HAWB/HBL"] != DBNull.Value)
                        {
                            obj.HAWB = (string)dataReader["HAWB/HBL"];
                        }
                        if (dataReader["Shipper"] != DBNull.Value)
                        {
                            obj.Shipper = (string)dataReader["Shipper"];
                        }
                        if (dataReader["Consignee"] != DBNull.Value)
                        {
                            obj.Consignee = (string)dataReader["Consignee"];
                        }
                        if (dataReader["Refer"] != DBNull.Value)
                        {
                            obj.Refer = (string)dataReader["Refer"];
                        }
                        if (dataReader["ETD"] != DBNull.Value)
                        {
                            obj.ETD = (string)dataReader["ETD"];
                        }
                        if (dataReader["POL/APL"] != DBNull.Value)
                        {
                            obj.POL = (string)dataReader["POL/APL"];
                        }
                        if (dataReader["POD/APD"] != DBNull.Value)
                        {
                            obj.POD = (string)dataReader["POD/APD"];
                        }
                        if (dataReader["Incoterm"] != DBNull.Value)
                        {
                            obj.Incoterm = (string)dataReader["Incoterm"];
                        }
                        if (dataReader["Flight/Vessel Number"] != DBNull.Value)
                        {
                            obj.FlightNumber = (string)dataReader["Flight/Vessel Number"];
                        }
                        if (dataReader["Vessel Name"] != DBNull.Value)
                        {
                            obj.VesselName = (string)dataReader["Vessel Name"];
                        }
                        if (dataReader["ETA"] != DBNull.Value)
                        {
                            obj.ETA = (string)dataReader["ETA"];
                        }
                        if (dataReader["Company"] != DBNull.Value)
                        {
                            obj.Company = (string)dataReader["Company"];
                        }
                        if (dataReader["Pkgs"] != DBNull.Value)
                        {
                            obj.Pkgs = (Int16)dataReader["Pkgs"];
                        }
                        if (dataReader["Kgs"] != DBNull.Value)
                        {
                            obj.Kgs = (decimal)dataReader["Kgs"];
                        }
                        if (dataReader["Cbm"] != DBNull.Value)
                        {
                            obj.Cbm = (decimal)dataReader["Cbm"];
                        }
                        list.Add(obj);
                    }
                }
                return list;
            }
        }

        public List<Import> LoadShipper()
        {
            SqlConnection db = new SqlConnection(Config);
            string query = "select dbo.contact.contact_id,dbo.contact.contact_name from dbo.contact,dbo.role_contact,dbo.role "+ 
                           "where dbo.role_contact.contact_id=dbo.contact.contact_id and dbo.role.role_id=dbo.role_contact.role_id "+ 
                           "and dbo.role.role_id=6";

            SqlCommand cmd = new SqlCommand(query, db);

            //cmd.Parameters.Add(new SqlParameter("@u", SqlDbType.VarChar)).Value = userId;

            db.Open();

            List<Import> list = new List<Import>();
            using (IDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Import obj = new Import();
                    if (dataReader["contact_id"] != DBNull.Value)
                    {
                        if (dataReader["contact_id"] != DBNull.Value)
                        {
                            obj.shipperId = (int)dataReader["contact_id"];
                        }
                        if (dataReader["contact_name"] != DBNull.Value)
                        {
                            obj.shipperName = (string)dataReader["contact_name"];
                        }
                        
                        list.Add(obj);
                    }
                }
                return list;
            }
        }
    }   
}