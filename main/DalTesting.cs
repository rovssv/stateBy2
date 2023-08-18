using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GbsFwDal.Factory;
using System.Data;
using ForwarderManagementEntityLayer.Users;
using GbsFwCom.ClassesBase;
using GbsFwCom.Execution;
using GbsFwCom.InfoEnumerate;
using ForwarderManagementDataAccessLayer.Repositories.Users;
using GbsFwDal.Queries;
using ForwarderManagementCom.ConstTabSchema;
using ForwarderManagementDataAccessLayer.Translators.Users;
using ForwarderManagementDataAccessLayer.Queries;

namespace ForwarderManagementUnitTest
{
    //[TestClass]
    //public class DALTesting
    //{
    //    [TestMethod]
    //    public void ConnectionFactoryTest()
    //    {
    //        IDbConnection conn = AdoConnectionFactory.CreateAdoConnection();
    //        Assert.IsNotNull(conn, "Errore connessione non istanziata");
    //    }
    //    [TestMethod]
    //    public void IsertUsersGroupTest()
    //    {

    //        using (UsersGroupsRps usersGroupRps = new UsersGroupsRps())
    //        {

    //            UsersGroup usersGroup = new UsersGroup() { Desc = "Gruppo TEST", ObjectStatus = InfoObjectStatus.Inserted };
    //            CrudInfo crudInfo = new CrudInfo();
    //            ExecutionResult<UsersGroup> result = usersGroupRps.Save(usersGroup, crudInfo);
    //            Assert.IsTrue(result.IsExecutionOk == true, "Insert failed, message: " + result.ExecutionMessage);
    //        }



    //    }

    //    [TestMethod]
    //    public void UpdateUsersGroupTest()
    //    {

    //        using (UsersGroupsRps usersGroupRps = new UsersGroupsRps())
    //        {

    //            UsersGroup usersGroup = new UsersGroup() { Id = 9, Desc = "Gruppo TEST Updated", ObjectStatus = InfoObjectStatus.Updated };
    //            CrudInfo crudInfo = new CrudInfo();
    //            ExecutionResult<UsersGroup> result = usersGroupRps.Save(usersGroup, crudInfo);
    //            Assert.IsTrue(result.IsExecutionOk == true, "Insert failed, message: " + result.ExecutionMessage);
    //        }
    //    }

    //    [TestMethod]
    //    public void DeleteUsersGroupTest()
    //    {

    //        using (UsersGroupsRps usersGroupRps = new UsersGroupsRps())
    //        {

    //            UsersGroup usersGroup = new UsersGroup() { Id = 8, ObjectStatus = InfoObjectStatus.Deleted };
    //            CrudInfo crudInfo = new CrudInfo();
    //            ExecutionResult<UsersGroup> result = usersGroupRps.Save(usersGroup, crudInfo);
    //            Assert.IsTrue(result.IsExecutionOk == true, "Delete failed, message: " + result.ExecutionMessage);
    //        }
    //    }

    //    [TestMethod]
    //    public void FindUsersGroupTest()
    //    {

    //        using (UsersGroupsRps usersGroupRps = new UsersGroupsRps())
    //        {
    //            UsersGroupFilter usersGroupFilter;
    //            FilterInfo filterInfo = new FilterInfo();
    //            ExecutionPagResult<UsersGroup> result ;
    //            // Find BY ID
    //            usersGroupFilter = new UsersGroupFilter() { Id = 2 };
    //            result = usersGroupRps.Find(usersGroupFilter, filterInfo);
    //            Assert.IsTrue(result.IsExecutionOk == true, "Find BY ID failed, message: " + result.ExecutionMessage);

    //            usersGroupFilter = new UsersGroupFilter() { GroupName = "%TEST%" };
    //            result = usersGroupRps.Find(usersGroupFilter, filterInfo);
    //            Assert.IsTrue(result.IsExecutionOk == true, "Find LIKE failed, message: " + result.ExecutionMessage);

    //            usersGroupFilter = new UsersGroupFilter();
    //            result = usersGroupRps.Find(usersGroupFilter, filterInfo);
    //            Assert.IsTrue(result.IsExecutionOk == true, "Find ALL failed, message: " + result.ExecutionMessage);
    //        }
    //    }

    //    [TestMethod]
    //    public void GetByIdUsersGroupTest()
    //    {

    //        using (UsersGroupsRps usersGroupRps = new UsersGroupsRps())
    //        {
                
    //            FilterInfo filterInfo = new FilterInfo();
    //            ExecutionResult<UsersGroup> result;
    //            // GET BY BY ID
    //            result = usersGroupRps.GetById(1, filterInfo);
    //            Assert.IsTrue(result.IsExecutionOk == true, "Get BY ID failed, message: " + result.ExecutionMessage);
    //            // GET BY BY with Id list
    //            List<int> idList = new List<int>{1,2,3};
                
    //            result = usersGroupRps.GetById(idList, filterInfo);
    //            Assert.IsTrue(result.IsExecutionOk == true, "Get BY ID failed, message: " + result.ExecutionMessage);
    //        }
    //    }
    //    [TestMethod]
    //    public void TestAsyncFindEncode()
    //    {
    //        bool result = false;
    //         QueryProcessor queryprocessor = new QueryProcessor ();
    //         AsyncEncodeCall<UsersEncode, UsersFilter, UsersTrl, TabUserInfo> asyncGroupEncode = new AsyncEncodeCall<UsersEncode, UsersFilter, UsersTrl, TabUserInfo>(queryprocessor);
    //         // paremeter for call
    //         UsersFilter userfilter = null;
    //         TabUserInfo dbuserInfo = TabUserInfo.GetInstance;

             
    //         // I find all users with asynchronous call
    //         asyncGroupEncode.FindDtoEncodeAsync(userfilter, null, callBackTestFindUserEncode, dbuserInfo);
    //         // Invalidate precedenta call and find only one user by ID
    //         userfilter = new UsersFilter { Id = 2, IsAsincCall = true };
    //         asyncGroupEncode.FindDtoEncodeAsync(userfilter, null, callBackTestFindUserEncode, dbuserInfo);
    //         userfilter = new UsersFilter { Id = 3, IsAsincCall = true };
    //         asyncGroupEncode.FindDtoEncodeAsync(userfilter, null, callBackTestFindUserEncode, dbuserInfo);
    //         userfilter = new UsersFilter { Code = "%hasa%", IsAsincCall = true };
    //         asyncGroupEncode.FindDtoEncodeAsync(userfilter, null, callBackTestFindUserEncode, dbuserInfo);
    //         // Wait one minute for catch call back
    //         System.Threading.Thread.Sleep(60000);

    //         result = true;


    //    }
        
    //    public void callBackTestFindUserEncode(List<UsersEncode> listEncode, Exception exByFindAsync)
    //    {
    //        bool resultFind = false;
    //        //This routine will be call by Async Encode Find
    //        if (listEncode != null && exByFindAsync == null)
    //        {
    //            resultFind = true;
    //        }
    //        Assert.IsTrue(resultFind == true, "FIND Asynchronous failed");
    //    }


    //}


   
}
