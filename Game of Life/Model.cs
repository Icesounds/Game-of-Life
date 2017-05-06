using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game_of_Life
{
    public class Model
    {

        public bool[,] gridArray = new bool[100, 100]; //Zellen tod / leben
        bool[,] gridArrayTemp = new bool[100, 100]; //Zwischenspeicher für Spielrundenveränderung


        public void survive()
        {
            int num; //Ausgelagert Wegen Garbage Collector (Nicht mehr verwendete Objekte löschen)
            
            Array.Copy(gridArray, gridArrayTemp, gridArray.Length); //Anfang der Runde durch Kopieren des aktuellen Standes
            for (int j = 0; j < 100; j++) //Erste Zeile
            {
                num = 0;
                // i = Zeilen; j = Spalten
                if (j != 0 && gridArray[0, j - 1])
                {
                    num++;
                }
                if (j != 99 && gridArray[0, j + 1])
                {
                    num++;
                }
                if (gridArray[1, j])
                {
                    num++;
                }
                if (j != 99 && gridArray[1, j + 1])
                {
                    num++;
                }
                if (j != 0 && gridArray[1, j - 1])
                {
                    num++;
                }
                setCellDeadOrAlive(0, j, num);
            }

            for (int j = 0; j < 100; j++) //Letzte Zeile
            {
                num = 0;
                // i = Zeilen; j = Spalten
                if (j != 0 && gridArray[99, j - 1])
                {
                    num++;
                }
                if (j != 99 && gridArray[99, j + 1])
                {
                    num++;
                }
                if (gridArray[98, j])
                {
                    num++;
                }
                if (j != 99 && gridArray[98, j + 1])
                {
                    num++;
                }
                if (j != 0 && gridArray[98, j - 1])
                {
                    num++;
                }
                setCellDeadOrAlive(0, j, num);
            }

            for (int i = 1; i < 99; i++) //Linke Spalte, von 1 bis 99, weil bei Zeile schon Ecken geprüft
            {
                num = 0;
                // i = Zeilen; j = Spalten
                if ( gridArray[i - 1, 0])
                {
                    num++;
                }
                if (gridArray[i + 1, 0])
                {
                    num++;
                }
                if (gridArray[i, 1])
                {
                    num++;
                }
                if (gridArray[i + 1, 1])
                {
                    num++;
                }
                if (gridArray[i - 1, 1])
                {
                    num++;
                }
                setCellDeadOrAlive(0, i, num);
            }

            for (int i = 1; i < 99; i++) //Rechte Spalte 
            {
                num = 0;
                // i = Zeilen; j = Spalten
                if (gridArray[i - 1, 99])
                {
                    num++;
                }
                if (gridArray[i + 1, 99])
                {
                    num++;
                }
                if (gridArray[i, 98])
                {
                    num++;
                }
                if (gridArray[i + 1, 98])
                {
                    num++;
                }
                if (gridArray[i - 1, 98])
                {
                    num++;
                }
                setCellDeadOrAlive(0, i, num);
            }


            for (int i = 1; i < 99; i++) //0, 100 sonderfall
            {
                for (int j = 1; j < 99; j++) //0, 100 sonderfall
                {
                    num = 0;
                    // i = Zeilen; j = Spalten
                    if (gridArray[i - 1, j - 1])
                    {
                        num++;
                    }
                    if (gridArray[i - 1, j])
                    {
                        num++;
                    }
                    if (gridArray[i - 1, j + 1])
                    {
                        num++;
                    }
                    if (gridArray[i, j + 1])
                    {
                        num++;
                    }
                    if (gridArray[i + 1, j + 1])
                    {
                        num++;
                    }
                    if (gridArray[i + 1, j])
                    {
                        num++;
                    }
                    if (gridArray[i + 1, j - 1])
                    {
                        num++;
                    }
                    if (gridArray[i, j - 1])
                    {
                        num++;
                    }
                    setCellDeadOrAlive(i, j, num);
                }
            }
            Array.Copy(gridArrayTemp, gridArray, gridArray.Length); //Beenden der Runde durch Kopieren in das Anzeige und Überprüfungsarray
        }

        public void setCellDeadOrAlive(int x, int y, int cells)
        {
            if (cells == 3)
            {
                gridArrayTemp[x, y] = true;
            }
            else if (cells == 1 || cells == 0)
            {
                gridArrayTemp[x, y] = false;
            }
            else if (gridArrayTemp[x,y] && cells == 2)
            {
            }
            else
            {
                gridArrayTemp[x, y] = false;
            }
        }

        public Point getGridPosition(int x, int y)
        {
            x /= 5;
            y /= 5;

            Point p = new Point();
            p.X = x;
            p.Y = y;

            gridArray[x, y] = alternateBool(gridArray[x, y]);

            return p;
        }

        private static bool alternateBool(bool b)
        {
            if (b == true)
            {
                b = false;
            }
            else
            {
                b = true;
            }
            return b;
        }
    }
}
