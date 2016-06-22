using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using iReferUService.DataObjects;
using iReferUService.Models;
using Microsoft.Azure.Mobile.Server;
using System.Threading.Tasks;
using System.Web.Http.OData;
using System.Web.Http.Controllers;

namespace iReferUService.Controllers
{
    public class ReferralItemController : TableController<ReferralItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            iReferUContext context = new iReferUContext();            
            DomainManager = new EntityDomainManager<ReferralItem>(context, Request);
        }

        // GET tables/ReferralItem
        public IQueryable<ReferralItem> GetAllReferralItems()
        {
            return Query();
        }

        // GET tables/ReferralItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ReferralItem> GetReferralItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ReferralItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ReferralItem> PatchReferralItem(string id, Delta<ReferralItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/ReferralItem
        public async Task<IHttpActionResult> PostReferralItem(ReferralItem item)
        {
            ReferralItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ReferralItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteReferralItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}