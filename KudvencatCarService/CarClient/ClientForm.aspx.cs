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
            using (var client = new CarServiceReference.CarServiceClient())
            {
                int carId = int.Parse(IdTxtBx.Text);
                var car = client.GetCar(carId);

                if (car != null)
                {
                    MarkTxtBx.Text = car.Mark;
                    ModelTxtBx.Text = car.Model;
                    YearTxtBx.Text = car.YearOfProduction.Year.ToString();
                    EngineTypeDropDownList.SelectedIndex = (int)car.EngineType;

                    if (car.EngineType == CarServiceReference.EngineType.Electric)
                    {
                        var electricCar = (CarServiceReference.ElectricCar)car;
                        RangeTxtBx.Text = electricCar.RangeInKilometers.ToString();
                    }
                    else
                    {
                        var oilFuelCar = (CarServiceReference.OilFuelCar)car;
                        EngineCCTxtBx.Text = oilFuelCar.EngineСС.ToString();
                        EnginePowerTxtBx.Text = oilFuelCar.EnginePower.ToString();
                    }

                    ResultLabel.Text = "Sucessfull get car";
                }
                else
                {
                    ResultLabel.Text = "Err get car";
                }
            }
        }

        protected void SaveCarBtn_Click(object sender, EventArgs e)
        {
            using (var client = new CarServiceReference.CarServiceClient())
            {
                int carId = int.Parse(IdTxtBx.Text);

                CarServiceReference.Car car = null;
                if (EngineTypeDropDownList.SelectedIndex == 1)
                {
                    car = new CarServiceReference.ElectricCar()
                    {
                        Id = carId,
                        Mark = MarkTxtBx.Text,
                        Model = ModelTxtBx.Text,
                        YearOfProduction = Convert.ToDateTime(YearTxtBx.Text),
                        EngineType = (CarServiceReference.EngineType)EngineTypeDropDownList.SelectedIndex,
                        RangeInKilometers = int.Parse(RangeTxtBx.Text)
                    };

                    SaveCar(car);
                }
                else if (EngineTypeDropDownList.SelectedIndex == 2)
                {
                    car = new CarServiceReference.OilFuelCar()
                    {
                        Id = carId,
                        Mark = MarkTxtBx.Text,
                        Model = ModelTxtBx.Text,
                        YearOfProduction = Convert.ToDateTime(YearTxtBx.Text),
                        EngineType = (CarServiceReference.EngineType)EngineTypeDropDownList.SelectedIndex,
                        EnginePower = int.Parse(EnginePowerTxtBx.Text),
                        EngineСС = int.Parse(EngineCCTxtBx.Text)
                    };

                    SaveCar(car);
                }
                else
                {
                    ResultLabel.Text = "Choose engine type";
                }

                void SaveCar(CarServiceReference.Car carForSave)
                {
                    client.SaveCar(carForSave);
                    ResultLabel.Text = "Car saved";
                }
            }     
        }

        protected void EngineTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(EngineTypeDropDownList.SelectedIndex)
            {
                case -1:
                case 0:
                    RangeLabel.Visible = false;
                    RangeTxtBx.Visible = false;
                    RangeMeterLabel.Visible = false;

                    EngineCCLabel.Visible = false;
                    EngineCCTxtBx.Visible = false;

                    EnginePowerLabel.Visible = false;
                    EnginePowerTxtBx.Visible = false;
                    break;

                case 1:
                    RangeLabel.Visible = true;
                    RangeTxtBx.Visible = true;
                    RangeMeterLabel.Visible = true;

                    EngineCCLabel.Visible = false;
                    EngineCCTxtBx.Visible = false;

                    EnginePowerLabel.Visible = false;
                    EnginePowerTxtBx.Visible = false;
                    break;

                case 2:
                    RangeLabel.Visible = false;
                    RangeTxtBx.Visible = false;
                    RangeMeterLabel.Visible = false;

                    EngineCCLabel.Visible = true;
                    EngineCCTxtBx.Visible = true;

                    EnginePowerLabel.Visible = true;
                    EnginePowerTxtBx.Visible = true;
                    break;
            }
        }

        protected void CleatBtn_Click(object sender, EventArgs e)
        {
            IdTxtBx.Text = string.Empty;
            MarkTxtBx.Text = string.Empty;
            ModelTxtBx.Text = string.Empty;
            YearTxtBx.Text = string.Empty;
            EngineCCTxtBx.Text = string.Empty;
            EnginePowerTxtBx.Text = string.Empty;
            RangeTxtBx.Text = string.Empty;
            EngineTypeDropDownList.SelectedIndex = 0;
        }
    }
}