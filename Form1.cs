using CoolHQAssignment.Data;
using CoolHQAssignment.Services;
using CoolHQAssignment.Services.Assembly;
using CoolHQAssignment.Services.Commands;
using CoolHQAssignment.Services.Spraybooth;
using System.Diagnostics;
using System.Net.Sockets;

namespace CoolHQAssignment
{
    public partial class Form1 : Form
    {
        private Invoker invoker;
        private Reciever reciever;
        Booth booth;
        private QueueManager sb;

        BuildMinibusConcreteCommand buildMinibusConcreteCommand;
        BuldCarConcreteCommand buildCarConcreteCommand;

        private delegate void ProgressCallback(string progress);
        private delegate void QueueCallback(int queueNumber);
        private delegate void SprayCarCallBack(string Color, int i);

        int CarQ, MinibusQ;
        string[] tempArray;

        public Form1()
        {
            InitializeComponent();
            invoker = new Invoker();
            reciever = new Reciever();

            buildMinibusConcreteCommand = new BuildMinibusConcreteCommand(reciever);
            buildCarConcreteCommand = new BuldCarConcreteCommand(reciever);
            
            sb = QueueManager.Instance;
            
            lblCarLine.Text = "Idle";
            lblCarQ.Text = "Idle";
            lblMinibusLine.Text = "Idle";
            lblMinibusQ.Text = "Idle";
            lblSpraybooth.Text = "Idle";

        }
        
        private void doWork()
        {
            invoker.ManufactureCar = new BuldCarConcreteCommand(reciever);
            invoker.ManufactureMinibus = new BuildMinibusConcreteCommand(reciever);
            
            string VehicleColor;
            if (rdBlackCar.Checked)
            {
                booth = new BlackCarBooth();
                SprayColor sprayColor = booth.Spray();
        
                VehicleColor = sprayColor.OutputColor();
                invoker.CarButton("Black LUX 1000");
                tempArray = reciever.carMaker("Black LUX 1000");

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
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        lblSpraybooth.Invoke(new SprayCarCallBack(SprayVehicle), new object[] { "Idle", 0 });
                    }
                }
                QueueManager.Instance.DecrementCarQueue();
                if (lblCarQ.InvokeRequired)
                    lblCarQ.Invoke(new QueueCallback(CarQueueDecrement), new object[] { CarQ });
                else
                    CarQueueDecrement(CarQ);
            }
            else if (rdWhiteCar.Checked)
            {
                booth = new WhiteCarBooth();
                SprayColor sprayColor = booth.Spray();
                VehicleColor = sprayColor.OutputColor();

                invoker.CarButton("White LUX 1000");
                tempArray = reciever.carMaker("White LUX 1000");
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
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        lblSpraybooth.Invoke(new SprayCarCallBack(SprayVehicle), new object[] { "Idle", 0 });
                    }
                }
                QueueManager.Instance.DecrementCarQueue();
                if (lblCarQ.InvokeRequired)
                    lblCarQ.Invoke(new QueueCallback(CarQueueDecrement), new object[] { CarQ });
                else
                    CarQueueDecrement(CarQ);
            }
            else if (rdWhiteMini.Checked)
            {
                booth = new WhiteMinibusBooth();
                SprayColor sprayColor = booth.Spray();

                VehicleColor = sprayColor.OutputColor();
                invoker.MinibusButton("White MV500");
                tempArray = reciever.minibusMaker("White MV500");
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
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        lblSpraybooth.Invoke(new SprayCarCallBack(SprayVehicle), new object[] { "Idle", 0 });
                    }

                }
                QueueManager.Instance.DecrementMinibusQueue();
                if (lblMinibusQ.InvokeRequired)
                    lblMinibusQ.Invoke(new QueueCallback(MinibusQueueDecrement), new object[] { MinibusQ });
                else
                    MinibusQueueDecrement(CarQ);
            }
            else if (rdBlackMini.Checked)
            {
                booth = new BlackMinibusBooth();
                SprayColor sprayColor = booth.Spray();

                VehicleColor = sprayColor.OutputColor();
                invoker.MinibusButton("Black MV500");
                tempArray = reciever.minibusMaker("Black MV500");
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
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        lblSpraybooth.Invoke(new SprayCarCallBack(SprayVehicle), new object[] { "Idle", 0 });
                    }
                }

                QueueManager.Instance.DecrementMinibusQueue();
                if (lblMinibusQ.InvokeRequired)
                    lblMinibusQ.Invoke(new QueueCallback(MinibusQueueDecrement), new object[] { MinibusQ });
                else
                    MinibusQueueDecrement(CarQ);
            }
        }

        private void CarQueueDecrement(int queueNumber)
        {
            lblCarQ.Text = queueNumber.ToString();
        }

        private void MinibusQueueDecrement(int queueNumber)
        {
            lblMinibusQ.Text = queueNumber.ToString();
        }

        private void SetProgressMinibus(string progress)
        {
            lblMinibusLine.Text = progress;
        }

        private void SetProgressLabel(string progress)
        {
            lblCarLine.Text = progress;
        }
        
        private void SprayVehicle(string CarColor, int i)
        {
            lblSpraybooth.Text = CarColor;
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //if (rdBlackCar.Checked || rdWhiteCar.Checked)
            //{
            //    CarQ++;
            //    lblCarQ.Text = CarQ.ToString();
            //}
            //if (rdWhiteMini.Checked || rdBlackMini.Checked)
            //{
            //    MinibusQ++;
            //    lblMinibusQ.Text = MinibusQ.ToString();
            //}

            if (rdBlackCar.Checked || rdWhiteCar.Checked)
            {
                QueueManager.Instance.IncrementCarQueue();
                lblCarQ.Text = QueueManager.Instance.GetCarQueue().ToString();
            }

            if (rdWhiteMini.Checked || rdBlackMini.Checked)
            {
                QueueManager.Instance.IncrementMinibusQueue();
                lblMinibusQ.Text = QueueManager.Instance.GetMinibusQueue().ToString();
            }
            
            var work = new Thread(doWork);
            work.Start();

            lblCarQ.Text = QueueManager.Instance.GetCarQueue().ToString();
            lblMinibusQ.Text = QueueManager.Instance.GetMinibusQueue().ToString();
            //lblCarQ.Text = CarQ.ToString();
            //lblMinibusQ.Text = MinibusQ.ToString();
        }
    }
}