using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForwarderManagementDataAccessLayer.Repositories.Users;
using ForwarderManagementEntityLayer.Locations;
using GbsFwCom.InfoEnumerate;
using GbsFwCom.ClassesBase;
using GbsFwCom.Execution;
using System.Diagnostics;

namespace ForwarderManagementUnitTest
{
    [TestClass]
    public class CitiesTesting
    {
       
        //[TestMethod]
        //public void InsertCitiesTest()
        //{
        //    using (CitiesRps citiesRps = new CitiesRps())
        //    {
        //        Cities cities = new Cities() { CityName = "Dhaka South", CountryCode = "BD", CountryId= 19, ProvinceId=0 , ObjectStatus = InfoObjectStatus.Inserted };
        //        CrudInfo crudInfo = new CrudInfo();
        //        ExecutionResult<Cities> result = citiesRps.Save(cities, crudInfo);
        //        if (result.IsExecutionOk == true && result.Results != null && result.Results.FirstOrDefault() != null)
        //        {
        //            int idRecordInserted = result.Results.FirstOrDefault().Id;

        //            Debug.WriteLine("Debug:  Record Inserted N° " + idRecordInserted);
        //        }
        //        Assert.IsTrue(result.IsExecutionOk == true, "Insert failed, message: " + result.ExecutionMessage);
        //    }            
        //}
        

        //[TestMethod]
        //public void FindCitiesTest()
        //{
        //    using (CitiesRps citiesRps = new CitiesRps())
        //    {
        //        CitiesFilter citiesFilter;
        //        FilterInfo filterInfo = new FilterInfo();
                
        //        ExecutionPagResult<Cities> result;
        //        // Find BY ID
        //        citiesFilter = new CitiesFilter() { CityName = "Dhaka" };
                
        //        result = citiesRps.Find(citiesFilter, filterInfo);
        //        Assert.IsTrue(result.IsExecutionOk == true, "Find BY ID failed, message: " + result.ExecutionMessage);

        //        citiesFilter = new CitiesFilter() { CityName = "%Dhaka%" };
        //        result = citiesRps.Find(citiesFilter, filterInfo);
        //        Assert.IsTrue(result.IsExecutionOk == true, "Find LIKE failed, message: " + result.ExecutionMessage);

        //        citiesFilter = new CitiesFilter();
        //        result = citiesRps.Find(citiesFilter, filterInfo);
        //        Assert.IsTrue(result.IsExecutionOk == true, "Find ALL failed, message: " + result.ExecutionMessage);
        //    }
        //}

        //[TestMethod]
        //public void UpdateCitiesTest()
        //{
        //    using (CitiesRps citiesRps = new CitiesRps())
        //    {

        //        Cities cities = new Cities() { Id =277124, CityName = "Dhaka North", CountryCode = "BD", CountryId = 19, ObjectStatus = InfoObjectStatus.Updated };
        //        CrudInfo crudInfo = new CrudInfo();
        //        ExecutionResult<Cities> result = citiesRps.Save(cities, crudInfo);
        //        Assert.IsTrue(result.IsExecutionOk == true, "Insert failed, message: " + result.ExecutionMessage);
        //    }
        //}

        //[TestMethod]
        //public void DeleteCitiesTest()
        //{
        //    using (CitiesRps citiesRps = new CitiesRps())
        //    {

        //        Cities cities = new Cities() { Id = 277124, ObjectStatus = InfoObjectStatus.Deleted };
        //        CrudInfo crudInfo = new CrudInfo();
        //        ExecutionResult<Cities> result = citiesRps.Save(cities, crudInfo);
               
        //        Assert.IsTrue(result.IsExecutionOk == true, "Delete failed, message: " + result.ExecutionMessage);
        //    }
        //}
    }
}
