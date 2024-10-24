/* Muestra los números del 1000 al 100, descendiendo de 10 en 10, con 
una orden "for". Emplea el tipo de datos que consideres óptimo para no 
desperdiciar espacio.*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        for (ushort i = 1000; i >= 100; i -= 10)
        {
            Console.Write("{0} ", i);
        }
    }
}

/*
1000 990 980 970 960 950 940 930 920 910 900 890 880 870 860 850 840 
830 820 810 800 790 780 770 760 750 740 730 720 710 700 690 680 670 660 
650 640 630 620 610 600 590 580 570 560 550 540 530 520 510 500 490 480 
470 460 450 440 430 420 410 400 390 380 370 360 350 340 330 320 310 300 
290 280 270 260 250 240 230 220 210 200 190 180 170 160 150 140 130 120 
110 100
*/
