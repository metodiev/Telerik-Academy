using System;

class AlgoShepherd
{
    static void Main()
    {

        
        int f = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        decimal[] x1 = new decimal[f];
        decimal[] x2 = new decimal[f];
        decimal[] y1 = new decimal[f];
        decimal[] y2 = new decimal[f];


        for (int i = 0; i < f; i++)
        {
            x1[i] = decimal.Parse(Console.ReadLine());
            y1[i] = decimal.Parse(Console.ReadLine());
            x2[i] = decimal.Parse(Console.ReadLine());
            y2[i] = decimal.Parse(Console.ReadLine());
        }
        decimal[] sheepX1 = new decimal[s];
        decimal[] sheepY1 = new decimal[s];

        for (int i = 0; i < s; i++)
        {
            sheepX1[i] = decimal.Parse(Console.ReadLine());
            sheepY1[i] = decimal.Parse(Console.ReadLine());
        }
        Array.Sort(x1);
        Array.Sort(y1);
        Array.Sort(x2);
        Array.Sort(y2);

        int sheeps = 0;
        for (int i = 0; i < s; i++)
        {
            int temp = 0;
            if (x1[i] > 0 && y1[i] > 0)
            {
                temp = 1;
            }
            if (x1[0] < 0 && y1[i] > 0)
            {
                temp = 2;
            }

            if (x1[0] < 0 && y1[0] < 0)
            {
                temp = 3;
            }
            if (x1[i] > 0 && y1[0] < 0)
            {
                temp = 4;   
            }

            if (x2[i] > 0 && y2[i] > 0)
            {
                temp = 1;
            }
            if (x2[0] < 0 && y2[i] > 0)
            {
                temp = 2;
            }

            if (x2[0] < 0 && y2[0] < 0)
            {
                temp = 3;
            }
            if (x2[i] > 0 && y2[0] < 0)
            {
                temp = 4;
            }
            switch (temp)
            {
                case 1: if (x1[i] > sheepX1[i] && y1[i] > sheepY1[i])
                        {
                            sheeps += 1;
                        }
                    break;
                    case 2: if (x1[0] > sheepX1[i] && y1[i] > sheepY1[i])
                            {
                                sheeps += 1;
                            }

                    break;
                        case 3:
                        if (x1[0] > sheepX1[i] && y1[0] > sheepY1[i])
                        {
                            sheeps += 1;
                        }
                   
                    break;
                    case 4:
                        if (x1[f] > sheepX1[i] && y1[0] > sheepY1[i])
                        {
                            sheeps += 1;
                        }
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(sheeps);

             int fencesNumber;
            int goatsNumber;
            fencesNumber = int.Parse(Console.ReadLine());
            goatsNumber = int.Parse(Console.ReadLine());

        double [] fencesXLefts = new double [fencesNumber];
        double [] fencesXRights= new double [fencesNumber];

        double [] fencesYTops = new double [fencesNumber];
        double []  fencesYBottoms = new double [fencesNumber];

        for (int i=0; i<fencesNumber; i++)
        {
           fencesXLefts [i] = double.Parse(Console.ReadLine());
           fencesYTops [i]  = double.Parse(Console.ReadLine());
           fencesXRights [i] = double.Parse(Console.ReadLine());
           fencesYBottoms [i] = double.Parse(Console.ReadLine());

            if (fencesXLefts[i] > fencesXRights[i])
            {
                fencesXLefts[i] = fencesXRights[i];
            }
            if (fencesYTops[i] < fencesYBottoms[i])
            {
                fencesYTops[i] = fencesYBottoms[i];
            }
        }

        double goatX;
        double goatY;

        int goatsInsideCount = 0;

        for (int i=0; i<goatsNumber; i++)
        {
             goatX = double.Parse(Console.ReadLine());
             goatY = double.Parse(Console.ReadLine());

            for (int f=0; f<fencesNumber; f++)
            {
                if (fencesXLefts[f] < goatX && goatX < fencesXRights[f] &&
                    fencesYBottoms[f] < goatY && goatY < fencesYTops[f])
                    {
                        goatsInsideCount++;
                        break;
                    }
            }
        }

        Console.WriteLine( goatsInsideCount  );
        }
    }



