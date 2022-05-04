using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaspberryPiNetCore.ADC;
using RaspberryPiNetCore.JoySticks;
using RaspberryPiNetCore.LCD;
using RaspberryPiNetCore.TWIST;

namespace RPI_2SemesterProjekt_Core
{
    class Display
    {
        private string socSecNb;
        private DateTime dateTime;
        private Display DisplayObj;


        ADC1015 adc = new ADC1015();
        int værdi = adc.ReadADC_SingleEnded(0);
        SerLCD display = new SerLCD();
        TWIST twist = new TWIST();
        //List<string> liste = new List<string>();

        display.lcdGotoXY(0, 0);
        display.lcdPrint(DateTime.Now.ToString());
        display.lcdGotoXY(0, 1);
        adc.StopADC();
        display.lcdPrint(adc.SINGLE_Measurement[0].Take().ToString());
        display.lcdGotoXY(0, 2);
        display.lcdPrint("1");

        public void visInfo { get; set; }


        public void display(string socSecNb, DateTime dateTime)
        {
            this.socSecNb = socSecNb;
            this.dateTime = dateTime;
        }
    }
}
