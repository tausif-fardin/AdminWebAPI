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
    public class EmployeeController : ApiController
    {
        [Route("api/Employee/All")]
        [HttpGet]
        public List<EmployeeModel> GetAll()
        {
            return EmployeeService.Get();
        }

        [Route("api/Employee/Details/{id}")]
        [HttpGet]
        public EmployeeModel Details(int id)
        {
            return EmployeeService.Details(id);
        }

        [Route("api/Employee/Add")]
        [HttpPost]
        public HttpResponseMessage Add(EmployeeModel e)
        {
            if (ModelState.IsValid)
            {
                var result = EmployeeService.Add(e);
                if (result)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Added successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Failed to add.");
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }

        [Route("api/Employee/Edit")]
        [HttpPut]
        public HttpResponseMessage Edit(EmployeeModel e)
        {
            if (ModelState.IsValid)
            {
                var result = EmployeeService.Edit(e);
                if (result)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Edit successfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Not Edited");
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }

        [Route("api/Employee/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var result = EmployeeService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Deleted");
            }
        }
    }
}
