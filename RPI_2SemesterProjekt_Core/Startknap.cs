using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaspberryPiNetCore;
using RaspberryPiNetCore.ADC;
using RaspberryPiNetCore.JoySticks;
using RaspberryPiNetCore.LCD;
using RaspberryPiNetCore.TWIST;

namespace RPI_2SemesterProjekt_Core
{
    class Startknap
    {
        private static RPi rpi;
        private static Key key1;


        public bool Start()
        {
            rpi = new RPi();
            key1 = new Key(rpi, Key.ID.P1);



        }
    }
}
