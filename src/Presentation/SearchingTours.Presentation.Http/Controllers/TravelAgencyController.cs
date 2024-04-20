using Microsoft.AspNetCore.Mvc;
using SearchingTours.Application.Contracts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Presentation.Http.Requests;

namespace SearchingTours.Presentation.Http.Controllers;

[ApiController]
[Route("travelagency")]
public class TravelAgencyController : ControllerBase
{
    private readonly ITravelAgencyService _travelAgencyService;

    public TravelAgencyController(ITravelAgencyService travelAgencyService)
    {
        _travelAgencyService = travelAgencyService;
    }

    [HttpGet("{id}")] 
    public ActionResult<TravelAgencyEntity> Get(Guid id)
    {
        TravelAgencyEntity? travelAgency = _travelAgencyService.GetTravelAgency(id);
        if (travelAgency == null)
        {
            return NotFound();
        }

        return Ok(travelAgency);
    }

    [HttpPost]
    public ActionResult<TravelAgencyEntity> Post([FromBody] TravelAgencyPost data)
    {
        try
        {
            TravelAgencyEntity createdTravelAgency = _travelAgencyService.AddTravelAgency(data.Name, data.ContactInfo, data.Password);
            return CreatedAtAction(nameof(Get), new { id = createdTravelAgency.Id }, createdTravelAgency);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while creating the travel agency." + ex);
        }
    }

    [HttpPut("{id}")]
    public ActionResult<TravelAgencyEntity> Update(Guid id, [FromBody] Dictionary<string, string> data)
    {
        try
        {
            TravelAgencyEntity? updatedTravelAgency = _travelAgencyService.UpdateTravelAgency(id, data);
            return Ok(updatedTravelAgency);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        bool result = _travelAgencyService.DeleteTravelAgency(id);
        if (result)
        {
            return NoContent();
        }
        else
        {
            return NotFound();
        }
    }
}