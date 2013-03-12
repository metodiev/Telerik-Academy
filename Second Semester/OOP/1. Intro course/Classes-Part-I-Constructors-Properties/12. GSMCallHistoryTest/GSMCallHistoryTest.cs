using System;

public class GSMCallHistoryTest
{
    public static void Main()   
    {
        //create new instance of the GSM class
        GSM gsm = new GSM("Nokia", "Nokia", 55.55M, "Owner");
        gsm.AddCall(new Call() );
        gsm.DeleteCall(new Call());
        gsm.ClearCallHistory();
    }
}

