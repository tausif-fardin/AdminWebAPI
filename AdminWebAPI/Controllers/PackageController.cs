using BLL.Entities;
using BLL.Services;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdminWebAPI.Controllers
{
    public class PackageController : ApiController
    {
        [Route("api/Package/All")]
        [HttpGet]
        public List<PackageModel> GetAll()
        {
            return PackageService.Get();
        }

        [Route("api/Package/Details/{id}")]
        [HttpGet]
        public PackageModel Details(int id)
        {
            return PackageService.Details(id);
        }
        [Route("api/Package/Add")]
        [HttpPost]
        public HttpResponseMessage Add(PackageModel e)
        {
            if (ModelState.IsValid)
            {
                var result = PackageService.Add(e);
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
        [Route("api/Package/Edit")]
        [HttpPut]
        public HttpResponseMessage Edit(PackageModel e)
        {
            if (ModelState.IsValid)
            {
                var result = PackageService.Edit(e);
                if (result)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Edited successfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Not Edited");
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }

        [Route("api/Package/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var result = PackageService.Delete(id);
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
