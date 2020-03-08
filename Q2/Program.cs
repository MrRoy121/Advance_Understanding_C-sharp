using System;

namespace Q2
{
  class Program
  {
    static void Main(string[] args)
    {
      String contents = "";
  int i,j;
  	int[,] arr1 = new int[7,10];
 
  for(i=0;i<5;i++)
  {
      for(j=1;j<9;j++)
      {
          if(i==0){
	        Console.Write("Enter No {0} Student No : ",j);
          }else if(i==1){
	        Console.Write("Enter No {0} Students T1 Marks : ",j);
          }else if(i==2){
	        Console.Write("Enter No {0} Students T2 Marks : ",j);
          }else if(i==3){
	        Console.Write("Enter No {0} Students Assign Marks : ",j);
          }else if(i==4){
	        Console.Write("Enter No {0} Students Exam Marks : ",j);
          }
		  arr1[i,j] = Convert.ToInt32(Console.ReadLine()); 
      }
  }  
 
 Console.Write("\nThe Table is : \n");
  for(i=0;i<5;i++)
  {
      Console.Write("\n");
      for(j=0;j<9;j++){
        if(j==0){
        if(i==0){
	        Console.Write("Student No :\t\t");
          }else if(i==1){
	        Console.Write("T1         : \t\t");
          }else if(i==2){
	        Console.Write("T2         :\t\t");
          }else if(i==3){
	        Console.Write("Assign     :\t\t");
          }else if(i==4){
	        Console.Write("Exam       :\t\t");
          }
        }else{

           Console.Write("{0}\t",arr1[i,j]);
        }
     }
    }
    Console.Write("\n\n\n");

}
