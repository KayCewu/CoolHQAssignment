using CoolHQAssignment.Services.Assembly;
using CoolHQAssignment.Services.Commands;

namespace CoolHQAssignment
{
    public partial class Form1 : Form
    {
        private Invoker invoker;
        private Reciever reciever;
        string[] tempArray;
        public Form1()
        {
            InitializeComponent();
            invoker=new Invoker();
            reciever = new Reciever();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            invoker.ManufactureMinibus = new BuildMinibusConcreteCommand(reciever);

            if (rdBlackCar.Checked)
            {
                invoker.CarButton("Black");
                tempArray = reciever.carMaker("Black");
            }

            for(int i = 0; i < tempArray.Length; i++)
            {
                lblCarLine.Text = tempArray[i];
            }
        }
    }
}