namespace QueueingForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();

            Application.Run(new queuingForm(new CashierClass()));
        }

        private static void ThreadStart()
        {
            Application.Run(new CashierWindowQueueForm()); 
        }
    }
    }
