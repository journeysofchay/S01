float display_result_sec = 7f;
int display_result_millisec = (int)(display_result_sec*1000);












string eye_on_his_left="-";
string eye_on_his_right="-";
string mouth="[]";
string head_n_face;

// render
head_n_face=
@"  \\"+ "\n" +
@"  \\\\\"+"\n" +
@" / \\  \\"+"\n" +
@"[| "+eye_on_his_right+"  "+eye_on_his_left+" |]"+"\n" +
@"\| "+mouth+"   |/"+"\n"+
@"  \    /"+"\n"+
@"    --"+"\n";


Console.WriteLine(head_n_face);




Thread.Sleep(display_result_millisec);