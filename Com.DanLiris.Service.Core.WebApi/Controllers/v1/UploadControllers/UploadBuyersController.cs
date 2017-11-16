﻿using Microsoft.AspNetCore.Mvc;
using Com.DanLiris.Service.Core.Lib;
using Com.DanLiris.Service.Core.Lib.Services;
using Com.DanLiris.Service.Core.WebApi.Helpers;
using Com.DanLiris.Service.Core.Lib.Models;

namespace Com.DanLiris.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/upload-buyers")]
    public class UploadBuyersController : BasicUploadController<BuyerService, Buyer, BuyerService.BuyerMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";
       
        public UploadBuyersController(BuyerService service) : base(service, ApiVersion)
        {
        }
    }
}