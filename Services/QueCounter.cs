using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services
{
    
    public sealed class QueueManager
    {
        private static QueueManager instance = null;
        private static readonly object lockObject = new object();

        private int carQueue;
        private int minibusQueue;

        private QueueManager()
        {
            // Initialize the queues
            carQueue = 0;
            minibusQueue = 0;
        }

        public static QueueManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new QueueManager();
                        }
                    }
                }
                return instance;
            }
        }

        public void IncrementCarQueue()
        {
            carQueue++;
        }

        public void DecrementCarQueue()
        {
            if (carQueue > 0)
                carQueue--;
        }

        public void IncrementMinibusQueue()
        {
            minibusQueue++;
        }

        public void DecrementMinibusQueue()
        {
            if (minibusQueue > 0)
                minibusQueue--;
        }

        public int GetCarQueue()
        {
            return carQueue;
        }

        public int GetMinibusQueue()
        {
            return minibusQueue;
        }
    }

}
