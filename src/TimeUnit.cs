using System.Collections.Generic;
using System;

namespace JTManagerController{

    public class TimeUnit {

        public Tuple<int, double, double> workTime {get;}
        public int peopleRequired {get; set;}
        public List<string> peopleName {get;}


        public TimeUnit(Tuple<int ,double, double> wrktm, int pr) {
            workTime = wrktm;
            peopleRequired = pr;
        }

        public void addWorker(Worker wkr) {
            peopleName.Add(wkr.name);
            peopleRequired--;
        }
    }

}