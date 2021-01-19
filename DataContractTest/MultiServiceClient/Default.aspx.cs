using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiServiceClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dateBtn_Click(object sender, EventArgs e)
        {
            var client = new CompanyServiceReference.CompanyGetDateClient();
            dateLabel.Text = client.GetDate();
        }

        protected void nameBtn_Click(object sender, EventArgs e)
        {
            var client = new CompanyServiceReference.CompanyGetPersonClient();
            CompanyServiceReference.Person person = client.GetPerson(
                firstNameTxtBox.Text, lastNameTxtBox.Text);

            personLabel.Text = $"Your name is: {person.FirstName} {person.LastName}";

            // Reccomend to use Mapper for Person to replace Person class from service
            // to native client class with the same signature.
        }
    }
}