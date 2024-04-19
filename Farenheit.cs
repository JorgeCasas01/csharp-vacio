using System;
using iFarenheit;

namespace farenheit{
    public class Farenheit : iFarenheit {
        double tempf (double tempf){
            celcius = (tempf-32)*0.5556;
            return "los farenheit ingresados en centigrados son "+celcius;
        }
        double tempc (double tempc){
            faren = (tempc*1.8)+32;
            return "los farenheit ingresados en centigrados son "+celcius;
        }
    }
}