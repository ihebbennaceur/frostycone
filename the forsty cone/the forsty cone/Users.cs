
using System;
using System.Text;

public class Users
{
   
    public string username = ""; 
    public string password = "";
    public string email = "";
    public int id;
    public int isAdmin = 0;
    public string DOB = ""; // = "DD-MM-YYYY";




    public Users(){}






        bool chkint(char a) 
        {
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; 

            for (int I = 0; I < nums.Length; I++) 
            {
                if (a != nums[I]) 
                {
                    continue;
                }
                else
                    return true; 
            }
            return false;
        }
        //checks if the input is an integer

    


    public bool Checkdt(string date)
    {

        string[] s1 = date.Split('-');  


        if (int.Parse(s1[0]) > 31 || int.Parse(s1[0]) < 0) 
        {
            return false;
        }
        else if (int.Parse(s1[1]) > 12 || int.Parse(s1[1]) < 0)
        {
            return false;
        }
        else if (int.Parse(s1[2]) > 1900 || int.Parse(s1[2]) < 2026)
        {
            return false;
        }
        else
        {
            return true;
        }
    } 
}

