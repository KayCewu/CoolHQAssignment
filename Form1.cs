using CoolHQAssignment.Services.Assembly;
using CoolHQAssignment.Services.Commands;
using System.Diagnostics;
using System.Net.Sockets;

namespace CoolHQAssignment
{
    public partial class Form1 : Form
    {
        private Invoker invoker;
        private Reciever reciever;
        string[] tempArray;
        BuildMinibusConcreteCommand buildMinibusConcreteCommand;
        BuldCarConcreteCommand buildCarConcreteCommand;
        private delegate void ProgressCallback(string progress);
        private delegate void SprayCarCallBack(string Color, int i);
        int CarQ, MinibusQ;
        public Form1()
        {
            InitializeComponent();
            invoker = new Invoker();
            reciever = new Reciever();
            buildMinibusConcreteCommand = new BuildMinibusConcreteCommand(reciever);
            buildCarConcreteCommand = new BuldCarConcreteCommand(reciever);

        }
        private void doWork()
        {
            invoker.ManufactureCar = new BuldCarConcreteCommand(reciever);
            invoker.ManufactureMinibus = new BuildMinibusConcreteCommand(reciever);
            string VehicleColor;
            if (rdBlackCar.Checked)
            {
                VehicleColor = "Black Car";
                invoker.CarButton("Black");
                tempArray = reciever.carMaker("Black");

                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (lblCarLine.InvokeRequired)
                    {
                        lblCarLine.Invoke(new ProgressCallback(SetProgressLabel), new object[] { tempArray[i] });
                    }
                    else
                    {
                        SetProgressLabel(tempArray[i]);
                    }
                    Thread.Sleep(2000);
                    if (i == tempArray.Length-1)
                    {
                        lblSpraybooth.Invoke(new SprayCarCallBack(SprayVehicle), new object[] {VehicleColor, i });
                    }

                }
            }
            else if (rdWhiteCar.Checked)
            {
                VehicleColor = "White Car";
                invoker.CarButton("White");
                tempArray = reciever.carMaker("White");
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (lblCarLine.InvokeRequired)
                    {
                        lblCarLine.Invoke(new ProgressCallback(SetProgressLabel), new object[] { tempArray[i] });
                    }
                    else
                    {
                        SetProgressLabel(tempArray[i]);
                    }
                    Thread.Sleep(2000);
                    if (i == tempArray.Length - 1)
                    {
                        lblSpraybooth.Invoke(new SprayCarCallBack(SprayVehicle), new object[] { VehicleColor, i });
                    }
                }

            }
            else if (rdWhiteMini.Checked)
            {
                VehicleColor = "White Minibus";
                invoker.MinibusButton("White");
                tempArray = reciever.minibusMaker("White");
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (lblMinibusLine.InvokeRequired)
                    {
                        lblMinibusLine.Invoke(new ProgressCallback(SetProgressMinibus), new object[] { tempArray[i] });
                    }
                    else
                    {
                        SetProgressMinibus(tempArray[i]);
                    }
                    Thread.Sleep(2000);
                    if (i == tempArray.Length - 1)
                    {
                        lblSpraybooth.Invoke(new SprayCarCallBack(SprayVehicle), new object[] { VehicleColor, i });
                    }

                }
            }
            else if (rdBlackMini.Checked)
            {
                VehicleColor = "Black Minibus";
                invoker.MinibusButton("Black");
                tempArray = reciever.minibusMaker("Black");
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (lblMinibusLine.InvokeRequired)
                    {
                        lblMinibusLine.Invoke(new ProgressCallback(SetProgressMinibus), new object[] { tempArray[i] });

                    }
                    else
                    {
                        SetProgressMinibus(tempArray[i]);
                    }
                    Thread.Sleep(2000);
                    if (i == tempArray.Length - 1)
                    {
                        lblSpraybooth.Invoke(new SprayCarCallBack(SprayVehicle), new object[] { VehicleColor, i });
                    }
                }
            }


        }

        private void SetProgressMinibus(string progress)
        {
            lblMinibusLine.Text = progress;

        }
        private void SetProgressLabel(string progress)
        {
            lblCarLine.Text = progress;
            //if (progress == "Sent Black for painting")
            //{
            //    lblSpraybooth.Text = "Spraying Black Car";
            //}
        }
        private void SprayVehicle(string CarColor,int i)
        {
              lblSpraybooth.Text="Spraying "+CarColor;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdBlackCar.Checked || rdWhiteCar.Checked)
            {
                CarQ++;
                lblCarQ.Text = CarQ.ToString();

            }
            if (rdWhiteMini.Checked || rdBlackMini.Checked)
            {

            }
            var work = new Thread(doWork);
            work.Start();


        }
    }
}