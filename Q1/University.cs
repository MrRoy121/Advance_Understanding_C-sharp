using System;

namespace Q1
{
public class University : School {

    String rating;

    public String Rating
    {
        get { return rating; }
        set { rating = value; }
    }

    public University(String schoolName, String location, String district, String province, String privateInstitution, String rank, String rating) : base(schoolName, location, district, province, privateInstitution, rank)
    {
        Rating = rating;
    }
  
    
    public override String ToStrings()
    {
        return (base.ToStrings()+".\nRating: " + rating);
    }
 
}}
