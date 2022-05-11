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
        private string socSecNb { get; set}
        private DateTime dateTime;
        private SerLCD lcd;
        private Display DisplayObj;
        public void visInfo { get; set; }
        //private int[] array = new int [10];
    {

        ADC1015 adc = new ADC1015();
        int værdi = adc.ReadADC_SingleEnded(0);
        SerLCD = new SerLCD();
        TWIST twist = new TWIST();
        //int[] array = new int [10];
        //List<int> liste = new List<int>();

     


    

        

    }


   public void display(string socSecNb, DateTime dateTime)
        {
            this.socSecNb = socSecNb;
            this.dateTime = dateTime;
        }

    public void WriteSocSecNb()
    {
        int[] array = new int [10];

        SerLCD.lcdGotoXY(0, 0);
        SerLCD.lcdPrint(DateTime.Now.ToString());
        SerLCD.lcdGotoXY(0, 1);
         SerLCD.lcdPrint("Indtast CPR-nummer: ");
        //adc.StopADC();
        //SerLCD.lcdPrint(adc.SINGLE_Measurement[0].Take().ToString());
        SerLCD.lcdGotoXY(0, 2);


        int i = 0;

        for (int i = 0; i <= 9; i++) //det her er længden på det der skal vises på display
        {
           
            if (TWIST.count()==true) //vi vil gerne, at hver gang man drejer lidt med twist, så viser den næste tal
            {
                SerLCD.lcdPrint(array[i]
            }
        

        else if (TWIST.isPressed()== true) //når man så klikker, så udskriver den det valgte tal på pladsen
        {
            SerLCD.lcdPrint(x);
        }
       

        }
		
             

        SerLCD.lcdGotoXY(1, 2); //går til næste plads på rækken, hvor næste tal skal stå
        SerLCD.Cursor();
        SerLCD.Blink();

        SerLCD.lcdGotoXY(2, 2);
        SerLCD.Cursor();
        SerLCD.Blink();

        SerLCD.lcdGotoXY(3, 2);
        SerLCD.Cursor();
        SerLCD.Blink();

        SerLCD.lcdGotoXY(4, 2);
        SerLCD.Cursor();
        SerLCD.Blink();

        SerLCD.lcdGotoXY(5, 2); //Her skal der eventuelt bare være bindestreg
        SerLCD.lcdPrint("-");

        SerLCD.lcdGotoXY(6, 2);
        SerLCD.Cursor();
        SerLCD.Blink();

        SerLCD.lcdGotoXY(7, 2);
        SerLCD.Cursor();
        SerLCD.Blink();

        SerLCD.lcdGotoXY(8, 2);
        SerLCD.Cursor();
        SerLCD.Blink();

        SerLCD.lcdGotoXY(9, 2);
        SerLCD.Cursor();
        SerLCD.Blink();



        TWIST.setCount(0)



        TWIST.isPressed()==true
            //hvis ja, indsættes tallet i CPR-nummeret
        
        if (TWIST.)

        
    }


    public void SlutMaaling()
    {
        SerLCD.lcdClear();
        SerLCD.lcdGotoXY(0,0);
        SerLCD.lcdPrint("Måling afsluttet.");
        SerLCD.lcdGotoXY(0,1);
        SerLCD.lcdPrint("Gem måling?");
        SerLCD.lcdGotoXY(0,2);
        SerLCD.lcdPrint("Tryk: 1:JA 2:NEJ");
        SerLCD.lcdPrint("1 2");

        if (TWIST.count()==1)
        {
            //gem måling
        }

        else
            //clear alt


        SerLCD.lcdPrint
       if (TWIST.count()==true)
    }

    }
}
