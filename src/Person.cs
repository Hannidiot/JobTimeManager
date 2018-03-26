using System.Collections.Generic;
using System;

namespace JTManagerController
{
    public class Person {
        // 留作基类方便以后扩展

    }

    public class Worker {
        public string name {get; set;}
        public List<Tuple<int, double, double>> absentTime {get;}

        public Worker(string n) {
            name = n;
        }

        public void addABT(Tuple<int, double, double> abt) {
            absentTime.Add(abt);
        }
    }
}