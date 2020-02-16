using System;
using System.Collections;

namespace Q1
{
  class Program
  {
    static void Main(string[] args)
    {
      School school = new School("XYZ School", "XYZ Location", "XYZ District", "XYZ Province", "XYZ Private Instutition", "XYZ Rank");
      String s = school.ToStrings();
      //Console.WriteLine(s);
    
      College college = new College("XYZ College", "XYZ Location", "XYZ District", "XYZ Province", "XYZ Private Instutition", "XYZ Rank", "XYZ Type");
      String c = college.ToStrings();
      //Console.WriteLine(c);

      University university = new University("XYZ University", "XYZ Location", "XYZ District", "XYZ Province", "XYZ Private Instutition", "XYZ Rank", "XYZ Rating");
      String u = university.ToStrings();
      //Console.WriteLine(u);

        ArrayList myList = new ArrayList();
        myList.Add(school);
        myList.Add(college);
        myList.Add(university);

        Console.WriteLine("Size : " + myList.Count);
    }
  }
}
