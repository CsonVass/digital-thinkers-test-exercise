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
    [ProducesResponseType(typeof(List<DriverDTO>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<List<DriverDTO>>> GetDrivers()
    {
        List<DriverDTO> drivers = new List<DriverDTO>(await formulaManager.ListDrivers());

        if(drivers == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(drivers);
        }
    }


    [HttpPut("/drivers/{driverId}/overtake")]
    public async Task<ActionResult> Overtake([FromRoute] int driverId)
    {
        bool result = await formulaManager.Overtake(driverId);

        if (result)
        {
            return Ok();
        }
        else
        {
            return Conflict();
        }
        
    }

}