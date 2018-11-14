using System;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedPosList listWithPath = new SortedPosList(@"c:\users\willi\Documents\test.txt");

            Position pos1 = new Position(47, 14);
            Position pos2 = new Position(10, 18);
            Position pos3 = new Position(80, 64);
            Position pos4 = new Position(12, 5);
            Position pos5 = new Position(52, 14);

            Position pos6 = new Position(90, 14);
            Position pos7 = new Position(10, 18);
            Position pos8 = new Position(80, 64);
            Position pos9 = new Position(122, 5);
            Position pos10 = new Position(13, 14);


            SortedPosList list = new SortedPosList();
            list.Add(pos1);
            list.Add(pos2);
            list.Add(pos3);
            list.Add(pos4);
            list.Add(pos5);

            SortedPosList list2 = new SortedPosList();
            list2.Add(pos6);
            list2.Add(pos7);
            list2.Add(pos8);
            list2.Add(pos9);
            list2.Add(pos10);

            SortedPosList list3 = list2 - list;

            Console.WriteLine(list.Count());

            for (int i = 0; i < list3.Count(); i++)
            {
                Console.WriteLine(list3[i].ToString() + ".  Length: " + list3[i].length());
            }

            /* list.Remove(new Position(80, 64));
            list.Remove(new Position(10, 10));
            list.Remove(new Position(10, 11));
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list.PosList[i].ToString() + ".  Length: " + list.PosList[i].length());
            }
            */
            Console.ReadLine();
        }
    }
}















            //Position pos = new Position(10, 10);
            //pos.ToString();
