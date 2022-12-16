using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        int PesoLettera = 0;
        foreach (char l in input.ToLower()){
            switch(l){
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'l':
                case 'n':
                case 'r':
                case 's':
                case 't':
                    PesoLettera = PesoLettera + 1;
                    break;
                case 'd':
                case 'g':
                    PesoLettera = PesoLettera + 2;
                    break;
                case 'b':
                case 'c':
                case 'm':
                case 'p':
                    PesoLettera = PesoLettera + 3;
                    break;
                case 'f':
                case 'h':
                case 'v':
                case 'w':
                case 'y':
                    PesoLettera = PesoLettera + 4;
                    break;
                case 'k':
                    PesoLettera = PesoLettera + 5;
                    break;
                case 'j':
                case 'x':
                    PesoLettera = PesoLettera + 8;
                    break;
                case 'q':
                case 'z':
                    PesoLettera = PesoLettera + 10;
                    break;
            }
        }
        return PesoLettera;
    }
}