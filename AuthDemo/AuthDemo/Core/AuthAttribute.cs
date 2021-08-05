using AuthDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Core
{
    public class AuthAttribute : TypeFilterAttribute
    {
        public AuthAttribute() : base(typeof(AuthorizeActionFilter))
        {
            Arguments = new object[] { };
        }

        public class AuthorizeActionFilter : IAuthorizationFilter
        {
            //private readonly PermissionEnum.Rights[] _item;

            public AuthorizeActionFilter()
            {

            }
            public void OnAuthorization(AuthorizationFilterContext context)
            {
                string token = context.HttpContext.Request?.Headers["token"].ToString();

                AuthService authService = new AuthService();
                var authModel = authService.GetTokenModelByvalue(token);
                if (authModel.Expirydate < DateTime.Now)
                {
                    return;
                }
            }


        }

    }
}
