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
            if (rdBlackCar.Checked)
            {
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
                }
            }else if(rdWhiteCar.Checked)
            {
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
                }

            }
            else if(rdWhiteMini.Checked)
            {
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
                }
            }
            else if (rdBlackMini.Checked)
            {
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
            
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdBlackCar.Checked || rdWhiteCar.Checked)
            {
                //invoker.CarCommands.Enqueue(buildCarConcreteCommand);
                //lblCarQ.Text = invoker.MinibusCommands.Count.ToString();
            }
            if (rdWhiteMini.Checked || rdBlackMini.Checked)
            {
                //invoker.MinibusCommands.Enqueue(buildMinibusConcreteCommand);
                //lblMinibusQ.Text = invoker.MinibusCommands.Count.ToString();
            }
            var work = new Thread(doWork);
            work.Start();

            
        }
    }
}