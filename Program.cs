using System;
using System.Collections.Generic;

namespace JTManagerController
{
    class Program
    {
        private static List<TimeUnit> tms = new List<TimeUnit>();
        private static List<Worker> wkrs = new List<Worker>();

        void InputTimeInfo() {

            Console.Write("共有几天: ");
            int d = Convert.ToInt32(Console.Read());
            
            Console.Write("每天有几种工作时段: ");
            int units = Convert.ToInt32(Console.Read());
            Console.WriteLine("设定每个时段需求人数的默认值");
            
            double[] bg = new double[units];
            double[] ed = new double[units];
            int[] pr = new int[units];
            Console.WriteLine("  开始\t结束\t需求人数");
            for(int k = 0; k < units; k++){
                Console.Write((k+1).ToString() + ".");
                bg[k] = Convert.ToDouble(Console.Read());
                ed[k] = Convert.ToDouble(Console.Read());
                pr[k] = Convert.ToInt32(Console.Read());
            }

            for(int i = 0; i < d; i++) {
                for(int k = 0; k < units; k++) {
                    tms.Add(new TimeUnit(new Tuple<int, double, double>(i+1, bg[k], ed[k]), pr[k]));
                }
            }

        }

        void InputWorkerInfo() {
            Console.WriteLine("有几个员工");
            int pnum = Convert.ToInt32(Console.Read());

            for(int i = 0; i < pnum; i++) {
                Console.Write("姓名: ");
                string name = Console.ReadLine();
                Worker wkr = new Worker(name);

                Console.WriteLine("输入员工非空闲时间，每组三个(星期x-开始-终止)，输入负数来终止");
                while(true) {
                    int wd = Convert.ToInt32(Console.Read());
                    double bg = Convert.ToDouble(Console.Read());
                    double ed = Convert.ToDouble(Console.Read());
                    if(bg < 0 || ed < 0){
                        break;
                    }
                    wkr.addABT(new Tuple<int, double, double>(wd, bg, ed));
                }
                wkrs.Add(wkr);
            }
        }

        void Process() {
            
        }

        void OutConsole() {

        }

        void OutExcel() {

        }

        static void Main(string[] args)
        {
            Tuple<int, int> a = new Tuple<int, int>(1, 2);
            Console.WriteLine(a.Item1);
            Console.WriteLine(a.Item2);
        }
    }
}
