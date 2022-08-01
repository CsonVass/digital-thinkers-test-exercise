using BL;
using BL.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

[ApiController]
[Route("api")]
public class FormulaController : ControllerBase
{
    private readonly FormulaManager formulaManager;

    public FormulaController(FormulaManager formulaManager) => this.formulaManager = formulaManager;

    [HttpGet("/drivers")]
    public async Task<ActionResult<List<DriverDTO>>> GetDrivers(){

    }


    [HttpPost("/drivers/{driverId}/overtake")]
    public async Task<ActionResult<bool>> Overtake([FromRoute] int driverId) {
    }

}