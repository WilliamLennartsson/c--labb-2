using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    class SortedPosList
    {
        private List<Position> posList;
        public List<Position> PosList
        {
            get
            {
                if (posList == null)
                {
                    return new List<Position>();
                }
                return posList;
            }
            set
            {
                posList = value;
            }
        }

        public SortedPosList()
        {
            posList = new List<Position>();
        }
        public SortedPosList(string filePath)
        {
            posList = new List<Position>();
            loadFile(filePath);
        }

        public void loadFile(string filePath)
        {
            int index = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                string[] bits = line.Split(',');
                try
                {
                    string a = bits[0].Split('(')[1];
                    string b = bits[1].Split(')')[0];
                    double x = Convert.ToDouble(a);
                    double y = Convert.ToDouble(b);
                    posList.Add(new Position(x, y));
                } 
                catch (Exception e)
                {
                    Console.WriteLine("Error parsing line: " + e);
                }
                
                index++;
            }
            file.Close();
        }

        //Methods
        public void Add(Position pos)
        {
            double len = pos.length();
            for (int i = 0; i < posList.Count(); i++)
            {
                if (len < posList[i].length())
                {
                    posList.Insert(i, pos);
                    return;
                }
            }
            posList.Add(pos); /* Inserted pos len is the biggest number in the list so it's added last */
        }
        public SortedPosList Clone()
        {
            SortedPosList newList = new SortedPosList();
            for (int i = 0; i < posList.Count(); i++)
            {
                newList.Add(posList[i].clone());
            }
            return newList;
        }
        public int Count()
        {
            return PosList.Count;
        }
        private List<Position> Sort(List<Position> list)
        {
            list.Sort((x, y) => x.length().CompareTo(y.length()));
            return list;
        } /* Not used */
        public bool Remove(Position pos)
        {
            for (int i = 0; i < posList.Count(); i++)
            {
                if (posList[i].Equals(pos))
                {
                    posList.Remove(posList[i]);
                    return true;
                }
            }
            return true;
        }

        // Operators
        public Position this[int i]
        {
            get
            {
                return posList[i];
            }
        }
        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList newList = sp1.Clone();
            for (int i = 0; i < sp2.Count(); i++)
            {
                newList.Add(sp2[i].clone());
            }
            return newList;
        }
        public static SortedPosList operator -(SortedPosList sp1, SortedPosList sp2)
        {
            foreach (Position pos1 in sp1.posList.Reverse<Position>())
            {
                foreach (Position pos2 in sp2.posList.Reverse<Position>())
                {
                    if (pos1.Equals(pos2))
                    {
                        sp1.Remove(pos1);
                    }
                }
            }
            return sp1.Clone();
        }

    }
}
