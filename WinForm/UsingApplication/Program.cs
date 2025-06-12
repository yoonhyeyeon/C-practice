using System;
using System.Windows.Forms;

namespace UsingApplication
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();

            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Closing Window...");
                    Application.Exit();
                });
            Console.WriteLine("Starting Window Application...");
            Application.Run(form);

            Console.WriteLine("Exiting Window Application...");
        }
    }
}
