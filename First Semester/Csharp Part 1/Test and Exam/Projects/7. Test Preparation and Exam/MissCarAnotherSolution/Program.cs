using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int first = 0;
        int second = 0;
        int third = 0;
        int fourth =0 ;
        int fifth = 0 ;
        int six= 0;
        int nineth = 0;
        int eight =0 ;
        int ten = 0;
        int seventh =0;

        for (int i = 0; i < N; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            if (vote ==1)
            {
                first++;
            }
            if (vote==2)
            {
                second++;
            }
            if (vote==3)
            {
                third++;
            }

            if (vote==4)
            {
                fourth++;
            }
            if (vote ==5)
            {
                fifth++;
                
            }
            if (vote == 6)
            {
                six++;

            }
            if (vote ==7)
            {
                seventh++;
            }
            if (vote ==8 )

	        {
                eight++;
	        }
            if (vote==9)
            {
                eight++;
            }
            if (vote == 10)
            {
                ten++;
            }
        }
        int[] arr = new int[10];
        arr[0] = first;
       
        arr[1]=  second;
        arr[2]=  third ; 
        arr[3]=  fourth ;
        arr[4]=  fifth ;
        arr[5]=  six;
        arr[7]=  nineth ;
        arr[8]=  eight;
        arr[9]=  ten ;
        arr[6] = seventh;
        
        int[] arr2 = new int[10];
        arr2[0] = first;
        arr2[1] = second;
        arr2[2] = third;
        arr2[3] = fourth;
        arr2[4] = fifth;
        arr2[5] = six;
        arr2[7] = nineth;
        arr2[8] = eight;
        arr2[9] = ten;
        arr2[6] = seventh;
        Array.Sort(arr2);

        int get = 0;
        int temp = arr2[9];
        int max = 0;
        int count = 0 ;
        int temp1 = 0;
        for (int i = 0; i < arr.Length; i++)
        {
             
            max = Math.Max(arr[i],0);
           
            if (temp == max)
            {
                count++;
                if (count == 2)
                {
                    break;
                }
                if (count != 2)
	            {
		            get = i; 
	            }
               
                
                
            }
        }
        Console.WriteLine(get+1);
    }
}

