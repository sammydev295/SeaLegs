﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;

using Microsoft.Azure.Mobile.Server;

using Sealegs.DataObjects;
using Sealegs.Backend.Models;
using Sealegs.Backend.Identity;

namespace Sealegs.Backend.Controllers
{
    public class CategoryController : ApiController
    {



        //public IQueryable<Category> GetAllCategory()
        //{
        //    return Query();
        //}

        //public SingleResult<Category> GetCategory(string id)
        //{
        //    return Lookup(id);
        //}

        //[EmployeeAuthorize()]
        //public Task<Category> PatchCategory(string id, Delta<Category> patch)
        //{
        //     return UpdateAsync(id, patch);
        //}

        //[EmployeeAuthorize]
        //public async Task<IHttpActionResult> PostCategory(Category item)
        //{
        //    Category current = await InsertAsync(item);
        //    return CreatedAtRoute("Tables", new { id = current.Id }, current);
        //}

        //[EmployeeAuthorize]
        //public Task DeleteCategory(string id)
        //{
        //     return DeleteAsync(id);
        //}

    }
}