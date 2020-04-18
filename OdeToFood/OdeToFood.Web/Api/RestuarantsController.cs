using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToFood.Web.Api
{
    public class RestuarantsController : ApiController
    {
        private readonly IRestuarantData _db;

        public RestuarantsController(IRestuarantData db)
        {
            this._db = db;
        }
        public IEnumerable<Restuarant> get()
        {
            var model = _db.GetAll();
            return model;
        }
    }
}
