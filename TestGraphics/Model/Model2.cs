using System;
using System.Threading;

namespace TimotheusUS.MVVMsamples.TestGraphics
{
    public delegate void EventHandlerModifyLetter(string letter);

    public class Model2
    {
        private Thread workerThread;
        private volatile static bool isStopped = false;
        public Action<string> NotiyCounterIncremented;
        public Model2()
        {
            this.workerThread = new System.Threading.Thread(DoWork);
            this.workerThread.Start();
        }
        private void DoWork()
        {
            int i = 0;
            while (!Model2.isStopped)
            {
                Thread.Sleep(2000);
                this.NotiyCounterIncremented((i++).ToString());
            }            
        }
        public void Stop()
        {
            Model2.isStopped = true;
            Thread.Sleep(2500);
        }
    }
}
