using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Commands
{
    class Invoker
    {
        //public Queue<ICommandBase> MinibusCommands = new Queue<ICommandBase>();
        //public Queue<ICommandBase> CarCommands = new Queue<ICommandBase>();
        //string cartype;
        //public void CarCommandsExecute()
        //{
        //    foreach (ICommandBase x in CarCommands)
        //    {
        //        CarCommands.Dequeue();
        //        x.Execute(cartype);
        //    }
        //}
        //public void MinibusCommandsExecute()
        //{
        //    foreach (ICommandBase x in MinibusCommands)
        //    {
        //        MinibusCommands.Dequeue();
        //        x.Execute(cartype);
        //    }
        //}
        public ICommandBase ManufactureCar { get; set; }
        public ICommandBase ManufactureMinibus { get; set; }

        public void CarButton(string vehicleType)
        {
            ManufactureCar.Execute(vehicleType);
        }

        public void MinibusButton(string vehicleType)
        {
            ManufactureMinibus.Execute(vehicleType);
        }
    }
}
