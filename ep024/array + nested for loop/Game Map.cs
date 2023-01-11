
float display_result_sec = 5.5f;
int display_result_millisec = (int)(display_result_sec*1000);




Console.Write("\n\n\n");







/*
short[] a=new short[5];

a[0] = 88;
a[1] = 11;
a[2] = -12;
a[3] = -56;
a[4] = -9999;

for(int i=0; i<5 ;i++)
{
    Console.WriteLine("a["+i+"] = " + a[i]);
}
*/




short[,] map2d=new short[5,5];


map2d[4,4] = 1000;

for(int y=0; y<5 ;y++)
{
    for(int x=0; x<5 ;x++)
    {
        if(map2d[x,y]==1000)
            Console.Write("Me! ");
        else
            Console.Write(map2d[x,y] + " ");
    }
    Console.WriteLine();
}




Thread.Sleep(display_result_millisec);
return;