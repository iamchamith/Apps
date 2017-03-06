using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;
using static ECart.Bo.Utility.Enums;

namespace ECART.Utility
{
    public class UserSession
    {

        public string Email { get; set; }
        public int UserId { get; set; }
        public UserType UserType { get; set; }
    }

    public class Session
    {
        public static UserSession User
        {
            get
            {
                HttpSessionState session = HttpContext.Current.Session;
                if (session["user"] != null)
                {
                    return (UserSession)session["user"];
                }
                return null;
            }
            set
            {
                HttpSessionState session = HttpContext.Current.Session;
                session["user"] = value;
            }
        }

        public static void SessionDesposed() {
            try
            {
                HttpSessionState session = HttpContext.Current.Session;
                session.Abandon();
            }
            catch {
                throw;
            }
        }
    }
    public class UserAuthorizeAttribute : AuthorizeAttribute
    {
        string Roles = string.Empty;
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            return (Session.User == null) ? false : true;
        }
    }
}