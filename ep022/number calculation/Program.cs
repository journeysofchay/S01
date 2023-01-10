




Console.Write("\n\n\n");

float shirt_sales_income_USD = 6516;
float shirt_unit_cost_USD = 7;
float shirt_unit_retail_USD = 12;

float shirts_sold_units = shirt_sales_income_USD / shirt_unit_retail_USD;

float profit = (shirt_unit_retail_USD-shirt_unit_cost_USD) * shirts_sold_units;


Console.WriteLine(" Shirt Sales Report");
Console.WriteLine("\tincome        : "+shirt_sales_income_USD+"\t USD");
Console.WriteLine("\tcost per unit : "+shirt_unit_cost_USD+"\t USD");
Console.WriteLine("\tretail price  : "+shirt_unit_retail_USD+"\t USD");
Console.WriteLine("\tsold          : "+shirts_sold_units+"\t Units");
Console.WriteLine("\tprofit        : "+profit+"\t USD");



Console.Write("\n\n");


Thread.Sleep(20000);
