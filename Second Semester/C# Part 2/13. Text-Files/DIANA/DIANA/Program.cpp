#include <iostream>

using namespace std;
 
int main()
{
	int izbor = 0;
	double aKvadrat ;
	double h ;
	double s;
	int a ;
	double sKvadrat;
	double r;
	double sOkryjnost;

	cout<<"Menu:\n";
	cout<<"1. Namerete liceto na triygylnik\n";
	cout<<"2. Namerete liceto na kvadrat\n";
	cout<<"3. Namerete liceto na Okryjnost\n";
	cout<<"napravete izbor\n";

	cin>> izbor;

	switch (izbor)
	{
	case 1: cout<<"Vyvedete edna strana na triygylnika:\n";
			
			cin>>a;
			cout<<"Vyvedete visochinata na triygylnika\n";
			cin>>h;
			s = (a*h)/(2);
			cout<<"Liceto na triygylnika e:\n";
			cout<<s;
			break;

	case 2: cout<<"Vyvvedete edna strana na kvadrata:\n";
			cin>>aKvadrat;
			sKvadrat = aKvadrat*aKvadrat;
			cout<<"Liceto na kvadrata e:\n";
			cout<<sKvadrat;
			break;

	case 3: cout<<"Vyvedete radiusa na okryjnostta:\n";
			cin>>r;		
			sOkryjnost = (3.14*r*r);
			cout<<"Liceto na okryjnostta e:\n";
			cout<<sOkryjnost;
			break;

	default: cout<<"Gresen izbor molq opitaite otnovo\n";
		break;
	}

	return 0;
}