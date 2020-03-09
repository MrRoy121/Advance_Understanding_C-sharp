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

    Console.Write("\nThe Table with final mark is : \n");
    Double s1, s2, s3, s4, s5, s6, s7, s8;
    s1 = (((arr1[1,1]*0.33) + (arr1[2,1]*0.33) + (arr1[3,1]*0.34))* 0.4) + (arr1[4,1]*0.6);
    s2 = (((arr1[1,2]*0.33) + (arr1[2,2]*0.33) + (arr1[3,2]*0.34))* 0.4) + (arr1[4,2]*0.6);
    s3 = (((arr1[1,3]*0.33) + (arr1[2,3]*0.33) + (arr1[3,3]*0.34))* 0.4) + (arr1[4,3]*0.6);
    s4 = (((arr1[1,4]*0.33) + (arr1[2,4]*0.33) + (arr1[3,4]*0.34))* 0.4) + (arr1[4,4]*0.6);
    s5 = (((arr1[1,5]*0.33) + (arr1[2,5]*0.33) + (arr1[3,5]*0.34))* 0.4) + (arr1[4,5]*0.6);
    s6 = (((arr1[1,6]*0.33) + (arr1[2,6]*0.33) + (arr1[3,6]*0.34))* 0.4) + (arr1[4,6]*0.6);
    s7 = (((arr1[1,7]*0.33) + (arr1[2,7]*0.33) + (arr1[3,7]*0.34))* 0.4) + (arr1[4,7]*0.6);
    s8 = (((arr1[1,8]*0.33) + (arr1[2,8]*0.33) + (arr1[3,8]*0.34))* 0.4) + (arr1[4,8]*0.6);
    
    arr1[5,1] = Convert.ToInt32(s1);
    arr1[5,2] = Convert.ToInt32(s2);
    arr1[5,3] = Convert.ToInt32(s3);
    arr1[5,4] = Convert.ToInt32(s4);
    arr1[5,5] = Convert.ToInt32(s5);
    arr1[5,6] = Convert.ToInt32(s6);
    arr1[5,7] = Convert.ToInt32(s7);
    arr1[5,8] = Convert.ToInt32(s8);
    
    for(i=0;i<6;i++){
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
          }else if(i==5){
	        Console.Write("Final      :\t\t");
          }
        }else{

           Console.Write("{0}\t",arr1[i,j]);
        }
        }
      }

    Console.Write("\n\n\n");

    Double t4 = (arr1[1,1] + arr1[1,2]+ arr1[1,3]+arr1[1,4]+arr1[1,5]+arr1[1,6]+arr1[1,7]+arr1[1,8])/8;
    Console.Write("\nThe Average of Test 01 mark is : {0}", Convert.ToInt32(t4));

    Console.Write("\n\n\n");

    Double t1 = (arr1[2,1] + arr1[2,2]+ arr1[2,3]+arr1[2,4]+arr1[2,5]+arr1[2,6]+arr1[2,7]+arr1[2,8])/8;
    Console.Write("\nThe Average of Test 02 mark is : {0}", Convert.ToInt32(t1));
    
    Console.Write("\n\n\n");

    Double t2 = (arr1[3,1] + arr1[3,2]+ arr1[3,3]+arr1[3,4]+arr1[3,5]+arr1[3,6]+arr1[3,7]+arr1[3,8])/8;
    Console.Write("\nThe Average of Assignment mark is : {0}", Convert.ToInt32(t2));

    Console.Write("\n\n\n");

    Double t3 = (arr1[4,1] + arr1[4,2]+ arr1[4,3]+arr1[4,4]+arr1[4,5]+arr1[4,6]+arr1[4,7]+arr1[4,8])/8;
    Console.Write("\nThe Average of Exam mark is : {0}", Convert.ToInt32(t3));

    

    
    Console.Write("\n\n\n");
    
    for(int q = 1; q<9; q++){
      if(arr1[5,q]<50){
        Console.Write("\nID - {0} - Fail ", arr1[0,q]);
        contents = contents + "\nID: " + arr1[0,q] + " Score: " + arr1[5,q];
      }else{
        Console.Write("\nID - {0} - Pass ", arr1[0,q]);
        contents = contents + "\nID: " + arr1[0,q] + " Score: " + arr1[5,q];
      }
    }

    
    Console.Write("\n\n\n");
    System.IO.File.WriteAllText (@"D:\path.txt", contents);
    
   }
  }
}
