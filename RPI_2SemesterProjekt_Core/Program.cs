using RaspberryPiNetCore.ADC;
using RaspberryPiNetCore.JoySticks;
using RaspberryPiNetCore.LCD;
using RaspberryPiNetCore.TWIST;
using System;


namespace Raspberry_Pi_Dot_Net_Core_Console_Application3
{
    class Program
    {
        static void Main(string[] args)
        {
            ADC1015 adc = new ADC1015();
            int værdi = adc.ReadADC_SingleEnded(0);
            SerLCD display = new SerLCD();
            TWIST twist = new TWIST();
            //List<string> liste = new List<string>();
            List<int> talraekke = new List<int>();




            //display.lcdGotoXY(0, 0);
            //display.lcdPrint(DateTime.Now.ToString());
            //display.lcdGotoXY(0, 1);
            //adc.StopADC();
            //display.lcdPrint(adc.SINGLE_Measurement[0].Take().ToString());
            //display.lcdGotoXY(0, 2);
            //display.lcdPrint("1");

            display.lcdGotoXY(0, 0);
            display.lcdPrint("Indtast CPR-nummer på patient:");
            display.lcdGotoXY(0, 1);
            display.lcdCursor(); display.lcdBlink();
            twist.isMoved //her vælger vi tallet 3 som er første del af CPR-nummeret

             display.lcdGotoXY(0, 3);
            display.lcdPrint
                display.lcdGotoXY(0, 4);






        }

       
    }
}
