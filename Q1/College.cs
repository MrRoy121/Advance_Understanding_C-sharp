using System;

namespace Q1
{
public class College : School {

    String type;

    public String Type
    {
        get { return type; }
        set { type = value; }
    }

    public College(String schoolName, String location, String district, String province, String privateInstitution, String rank, String type) : base(schoolName, location, district, province, privateInstitution, rank)
    {
        Type = type;
    }
  
    
    public override String ToStrings()
    {
        return (base.ToStrings()+".\nType: " + type);
    }
 
}}