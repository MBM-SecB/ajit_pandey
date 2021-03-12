
using Microsoft.AspNetCore.Mvc;

public class StateController:  Controller
{
    
    public ViewResult First()
    {
        // State Management
        // 1. Client Side
            // 1.1 Cookies
            var name  = "Azyt Pandey";
            Response.Cookies.Append("user", name);

            // 1.2 Query Strings (Query Parameters)



            return  View();

    }

    public ViewResult Second(string name,int age) //1.2 Query Strings
    {
        
        return View();
    }

    [HttpPost]
    public string Second(string collegeName) //1.3 Hidden Fields
    {
        
        return collegeName;
    }

}