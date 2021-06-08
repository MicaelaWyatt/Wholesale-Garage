using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero dsr = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram r3500 = new Ram();

            fxs.MainColor = "Midnight Blue";
            dsr.MainColor = "Black";
            modelS.MainColor = "Burgundy";
            r3500.MainColor = "Silver";
            mx410.MainColor = "White";

            fxs.Drive();
            dsr.Drive();
            modelS.Drive();
            r3500.Drive();
            mx410.Drive();
        }
    }
}

