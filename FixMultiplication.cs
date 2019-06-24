using System;
 public class FixMultiplication
 {
     
    public static int isMissing(int t,int T)
    {
           int count=0;
   int missing_digit = -1;
   int[] ht = new int[10];
   while(t!=0)
   {
	ht[t%10]++;
	t/=10;
   }
   while(T!=0)
   {
	ht[T%10]--;
	T/=10;
   }
   for(int i=0;i<=9;i++)
   {
	 if(ht[i]==1)
	 {
		  count++;
		  missing_digit = i;
	 }
   }
   if(count!=1)
	   missing_digit = -1;
   return missing_digit;
    }
       int FindDigit(string inp)
     {
         int t=0;
         string[] inp1 = inp.Split('=');
         string[] inp2 = inp1[0].Split('*');
         int A = Convert.ToInt32(inp2[0]);
         int B = Convert.ToInt32(inp2[1]);
         int C = Convert.ToInt32(inp1[1]);

         if(A*B<C)
	 {
		int a = C/B;
		int b = C/A;
		if((t=isMissing(a,A))!=-1)
		{
		  return t;
		}
		if((t=isMissing(b,B))!=-1)
		{
		return t;
		}
	 return -1;
	 }
	 if(A*B>C)
	 {
		return  isMissing(A*B,C);
	 }
	 return -1;
     }
     public static void Main(String[] args)
     {
    string inp = Console.ReadLine();
    FixMultiplication obj = new FixMultiplication();
    Console.WriteLine(" "+obj.FindDigit(inp));
     }
 }
