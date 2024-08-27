using System;
namespace LOPVADOITUONG
{
    public class StopWatch
    {
        private DateTime startTime;
        public DateTime GetStartTime()
        {
            return startTime;
        }
        private DateTime endTime;
        public DateTime GetEndTime()
        {
            return endTime;
        }
        public StopWatch()
        {
            startTime = DateTime.Now;
        }
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public double GetElapsedTime()
        {
            TimeSpan elapsedtime = endTime - startTime;
            return elapsedtime.TotalMilliseconds;
        }
    }
    public class DoThoiGianThucThi
    {
        public static int[] DanhSachCanSapXep()
        {
            int[] muoivanso = new int[100000];
            Random phantu = new Random();
            for (int i = 0; i < 100000; i++)
            {
                muoivanso[i] = phantu.Next(0,100);
            }
            return muoivanso;
        }
        public static void SapXepChon(int[] arr)
        {
            int n = arr.Length;
            int n0 = n;
            for(int i = 0; i < n; i++)
            {
                int max = arr[0];
                int indextmp = 0;
                for(int j = 1; j < n0; j++)
                {
                    if (max<arr[j])
                    {
                        max = arr[j];
                        indextmp = j;
                    }
                }
                arr[indextmp] = arr[n0-1];
                arr[n0-1] = max;
                n0--;
            }
        }
        public static void Main(string[] args)
        {
            StopWatch donghodo = new StopWatch();
            donghodo.Start();
            int[] mang = DanhSachCanSapXep();
            SapXepChon(mang);
            donghodo.Stop();
            Console.WriteLine($"Chuong trinh vua chay trong {donghodo.GetElapsedTime()} mili giay\nBat dau tu {donghodo.GetStartTime()} den {donghodo.GetEndTime()}");
        }
    }
}