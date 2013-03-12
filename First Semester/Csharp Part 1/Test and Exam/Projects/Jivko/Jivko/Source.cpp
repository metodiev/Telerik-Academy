#include<stdio.h>
#include<string.h>

int main (void)
{
	int choice = 1;
    char str [200];
	printf("Menu:");
	printf("\n Izberete vyzmojnost");
	printf("\n 1. Vyvedete Tekst");
	printf("\n 2. Izvadete simvol ot teksta");
	printf("\n 3. Prebroqvane na simvolite v teksta");
	printf("\n 4. Prebroqvane na cifrite malkite i glavni bukvi v teksta");
	printf("\n 5. Izhod");

	 while (choice > 0 && choice < 5)
	 {
		
		printf("\n Molq izberete vyzmojnost\n");
		scanf("%d", &choice);
		 switch (choice)
		 {
		 case 1: //gets(str);
			 scanf("%s", str);
			 break;

		 case 2: puts(str);
			 break;
		 case 3: 
			int i, n;
			/*Get string length
            Returns the length of the C string str.
*/			n = strlen(str);
			for ( ; ; )
			{

			}

			 break;
		 case 4:
			 break;
		 case 5:
			 break;
		 default:
			 break;
		 }
	}
	
}