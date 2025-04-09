using CargoManager.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CargoManager.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class CargoController : ControllerBase
    {
       
    }
}
