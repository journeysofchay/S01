
float display_result_sec = 3.5f;
int display_result_millisec = (int)(display_result_sec*1000);




Console.Write("\n\n\n");





for(   int i=1   ;   i < 60000   ;  i*=2    )
{
    Console.Write(i+" ");
}



Thread.Sleep(display_result_millisec);
return;



