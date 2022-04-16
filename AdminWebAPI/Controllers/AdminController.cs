using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdminWebAPI.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/Admin/Dashboard")]
        [HttpGet]
        public int[] Dashboard()
        {
            return AdminService.Dashboard();
        }

        [Route("api/Admin/Edit/Profile")]
        [HttpPut]
        public HttpResponseMessage Edit(AdminModel e)
        {
            if (ModelState.IsValid)
            {
                var result = AdminService.EditProfile(e);
                if (result)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Updated successfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotModified, "Not Modified");
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }


        

    }
}
