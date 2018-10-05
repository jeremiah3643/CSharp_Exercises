using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main (string[] args) {
            HashSet<string> ShowRoom = new HashSet<string> ();

            ShowRoom.Add ("Chevy Nova");
            ShowRoom.Add ("Mustang");
            ShowRoom.Add ("Chevy Colorado");
            ShowRoom.Add ("Car");
            ShowRoom.Add ("Chevy Nova");

            HashSet<string> UsedLot = new HashSet<string> ();
            UsedLot.Add ("Honda Fit");
            UsedLot.Add ("Ford F-150");

            ShowRoom.UnionWith (UsedLot);

            ShowRoom.Remove ("Mustang");

            HashSet<string> JunkYard = new HashSet<string> ();
            JunkYard.Add ("Chevy Nova");
            JunkYard.Add ("Car");
            JunkYard.Add ("Pinto");
            JunkYard.Add ("Model T");

            HashSet<string> clone = new HashSet<string> (ShowRoom);
            clone.IntersectWith (ShowRoom);
            ShowRoom.UnionWith (JunkYard);
            ShowRoom.Remove ("Car");

            foreach (string car in ShowRoom) {
                Console.WriteLine (car);
            }
        }

    }
}