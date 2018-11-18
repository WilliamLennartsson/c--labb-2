using System;

namespace Labb2
{
    /*
(9,19)
(50,20)
(30,4)
(3,10)
(19,39)
(90,33)
(15,15)
(3,10)
*/
    class Program
    {
        static void Main(string[] args)
        {

            //WillTest();
            //test();
            pathTest();

            Console.ReadLine();
        }
        private static void pathTest()
        {
            SortedPosList listWithPath = new SortedPosList(@"c:\users\willi\Documents\test.txt");
            Position posM = new Position(12, 37);
            Position posN = new Position(100, 114);
            listWithPath.Add(posM);
            listWithPath.Add(posN);

            for (int i = 0; i < listWithPath.Count(); i++)
            {
                //Console.WriteLine(listWithPath[i].ToString());
            }
        }
        private static void WillTest()
        {
            
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

            //Console.WriteLine(list.Count());

            for (int i = 0; i < list3.Count(); i++)
            {
                //Console.WriteLine(list3[i].ToString() + ".  Length: " + list3[i].length());
            }

            list.Remove(new Position(80, 64));
            list.Remove(new Position(10, 10));
            list.Remove(new Position(10, 11));
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list.PosList[i].ToString() + ".  Length: " + list.PosList[i].Length());
            }
            
        }
        private static void test()
        {
            Console.WriteLine(new Position(2, 4) + new Position(1, 2) + "\n");
            Console.WriteLine(new Position(2, 4) - new Position(1, 2) + "\n");
            Console.WriteLine(new Position(1, 2) - new Position(3, 6) + "\n");
            Console.WriteLine(new Position(3, 5) % new Position(1, 3) + "\n");

            SortedPosList list1 = new SortedPosList();
            SortedPosList list2 = new SortedPosList();
            list1.Add(new Position(3, 7));
            list1.Add(new Position(1, 4));
            list1.Add(new Position(2, 6));
            list1.Add(new Position(2, 3));
            Console.WriteLine(list1 + "\n");
            list1.Remove(new Position(2, 6));
            Console.WriteLine(list1 + "\n");

            list2.Add(new Position(3, 7));
            list2.Add(new Position(1, 2));
            list2.Add(new Position(3, 6));
            list2.Add(new Position(2, 3));
            Console.WriteLine((list2 + list1) + "\n");

            SortedPosList circleList = new SortedPosList();
            circleList.Add(new Position(1, 1));
            circleList.Add(new Position(2, 2));
            circleList.Add(new Position(3, 3));
            Console.WriteLine(circleList.CircleContent(new Position(5, 5), 4) + "\n");
        }
    }
}















            //Position pos = new Position(10, 10);
            //pos.ToString();
