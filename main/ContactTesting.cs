using ForwarderManagementCom;
using ForwarderManagementDataAccessLayer.Repositories.Users;
using ForwarderManagementEntityLayer.Users;
using GbsFwCom.ClassesBase;
using GbsFwCom.Execution;
using GbsFwCom.InfoEnumerate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FMUnitTest
{
    [TestClass]
    public class ContactTesting
    {
        [TestMethod]
        public void Insert()
        {
            int id = 0;
            using (ContactsRps rps = new ContactsRps())
            {
                ContactsDto items = new ContactsDto()
                {
                    CompanyName = "New Company test",
                    ObjectStatus = InfoObjectStatus.Inserted
                };
                CrudInfo crudInfo = new CrudInfo();
                ExecutionResult<ContactsDto> result = rps.Save(items, crudInfo);
                if (result.IsExecutionOk == true && result.Results != null && result.Results.FirstOrDefault() != null)
                {
                    int idRecordInserted = result.Results.FirstOrDefault().Id;

                    id = idRecordInserted;

                    Debug.WriteLine("Debug:  Record Inserted N " + idRecordInserted);
                }
                Assert.IsTrue(result.IsExecutionOk == true, "Insert failed, message: " + result.ExecutionMessage);
            }

            using (RolesContactRps rps = new RolesContactRps())
            {
                RolesContact items = new RolesContact()
                {
                    ContactId = id,
                    RoleId = (int)InfoRoles.Shipper,
                    ObjectStatus = InfoObjectStatus.Inserted
                };
                CrudInfo crudInfo = new CrudInfo();
                ExecutionResult<RolesContact> result = rps.Save(items, crudInfo);
                if (result.IsExecutionOk == true && result.Results != null && result.Results.FirstOrDefault() != null)
                {
                    int idRecordInserted = result.Results.FirstOrDefault().Id;

                    id = idRecordInserted;

                    Debug.WriteLine("Debug:  Record Inserted N " + idRecordInserted);
                }
                Assert.IsTrue(result.IsExecutionOk == true, "Insert failed, message: " + result.ExecutionMessage);
            }
        }
    }
}
