using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRS.AMS.WebserviceConsumer
{
    public partial class AirtimeManagementSystem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var proxy = new CRSWebService.CRSWebServiceAMS();
            var employee =
                new CRSWebService.CRSWebServiceAMS().Verify_Employee_IDNumber_AccountNumber(txtSystemPrefix.Text,
                                                                                            int.Parse(
                                                                                                txtCompanyNumber.Text),
                                                                                            int.Parse(
                                                                                                txtEmployeeNumber.Text),
                                                                                            txtIDNumber.Text,
                                                                                            txtAccountNumber.Text);
            //Label1.Text = employee
        }
    }
}