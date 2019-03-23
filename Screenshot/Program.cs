using System.Drawing.Imaging;
using System.Threading;

namespace Screenshot
{
    class Program
    {

        private static int Count { get; set; }

        static void Main(string[] args)
        {
            Count = 1;

            TimerTask();
        }

        private static void TimerTask()
        {
            if (Count != 10)
            {
                ScreenCapture sc = new ScreenCapture();
                sc.CaptureScreenToFile(@"C:\Users\Erhan Emre Eroğlu\Desktop\Screenshots\Shot_" + Count + ".png", ImageFormat.Png);

                Count++;

                Thread.Sleep(1000);

                TimerTask();
            }
        }
    }
}
