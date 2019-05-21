using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;


public class AuthUser : System.Web.Services.Protocols.SoapHeader
{
    public string UserName { get; set; }
    public string Password { get; set; }


    public bool IsValid()
    {
        int count = 0;

        string config = ConfigurationManager.ConnectionStrings[""].ConnectionString;
    }
}