using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarClient
{
    public partial class ClientForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetCarBtn_Click(object sender, EventArgs e)
        {
            var client = new CarServiceReference.CarServiceClient();
            int carId = int.Parse(IdTxtBx.Text);
            var car = client.GetCar(carId);

            if(car != null)
            {
                MarkTxtBx.Text = car.Mark;
                ModelTxtBx.Text = car.Model;
                YearTxtBx.Text = car.YearOfProduction.Year.ToString();
                ResultLabel.Text = "Sucessfull get car";
            }
            else
            {
                ResultLabel.Text = "Err get car";
            }
        }

        protected void SaveCarBtn_Click(object sender, EventArgs e)
        {
            var client = new CarServiceReference.CarServiceClient();
            int carId = int.Parse(IdTxtBx.Text);
            client.SaveCar(new CarServiceReference.Car()
            {
                Id = carId,
                Model = ModelTxtBx.Text,
                Mark = MarkTxtBx.Text,
                YearOfProduction = Convert.ToDateTime(YearTxtBx.Text)
            });

            ResultLabel.Text = "Car saved";
        }
    }
}