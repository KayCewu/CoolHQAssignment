using CoolHQAssignment.Services.Assembly;

namespace CoolHQAssignment
{
    public partial class Form1 : Form
    {
        private Invoker invoker;
        private AssembleCar assembleCar;
        public Form1()
        {
            InitializeComponent();
            invoker=new Invoker();
            assembleCar = new AssembleCar();    
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}