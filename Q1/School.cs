using System;

namespace Q1
{
    public class School {

    private String schoolName, location, district, province, privateInstitution, rank;

    public School(String schoolName, String location, String district, String province, String privateInstitution, String rank)
    {
        this.schoolName = schoolName;
        this.location = location;
        this.district = district;
        this.province = province;
        this.privateInstitution = privateInstitution;
        this.rank = rank;
    }
 
 
    public String SchoolName
    {
        
        get { return schoolName; }
        set { schoolName = value; }
    }
    
 
    public String Location
    {
        
        get { return location; }
        set { location = value; }
        
    }
 
 
    public String District
    {
        
        get { return district; }
        set { district = value; }
        
    }
 
    public String Province
    {
        
        get { return province; }
        set { province = value; }
    }
 
 
    public String PrivateInstitution
    {
        get { return privateInstitution; }
        set { privateInstitution = value; }
    }
 
   public String Rank
   {
        get { return rank; }
        set { rank = value; }
   }
 
    public virtual String ToStrings()
    {
        return ("Name :" + this.SchoolName
                + ".\nLocation :" + this.Location
                + ".\nDistrict :" + this.District
                + ".\nProvince :" + this.Province
                + ".\nPrivateInstitution :" + this.PrivateInstitution
                + ".\nRank :" + this.Rank);
    }
 
}

}
