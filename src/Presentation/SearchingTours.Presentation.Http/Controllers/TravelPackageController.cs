using Microsoft.AspNetCore.Mvc;
using SearchingTours.Application.Contracts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Presentation.Http.Requests;
using SearchingTours.Presentation.Http.Responses;

namespace SearchingTours.Presentation.Http.Controllers;

[ApiController]
[Route("travel-package")]
public class TravelPackageController : ControllerBase
{
    private readonly ITravelPackageService _travelPackageService;

    public TravelPackageController(ITravelPackageService travelPackageService)
    {
        _travelPackageService = travelPackageService;
    }

    [HttpGet("{id}")]
    public ActionResult<TravelPackageEntity> Get(Guid id)
    {
        TravelPackageEntity? travelPackage = _travelPackageService.GetTravelPackage(id);
        if (travelPackage == null)
        {
            return NotFound();
        }

        return Ok(travelPackage);
    }

    [HttpPost]
    public ActionResult<TravelPackagePostResponse> Post([FromBody] TravelPackagePost data)
    {
        try
        {
            TravelPackageEntity createdTravelPackage = _travelPackageService.AddTravelPackage(data.TravelAgencyId, data.Name, data.AmountOfPeople, data.AmountOfPackages, data.Destination, data.Price, data.Description, data.StartDate, data.EndDate, data.Rating);
            return CreatedAtAction(nameof(Get), new { id = createdTravelPackage.Id }, createdTravelPackage);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while creating the travel package." + ex);
        }
    }

    [HttpPut("{id}")]
    public ActionResult<TravelPackageEntity> Update(Guid id, [FromBody] Dictionary<string, string> data)
    {
        try
        {
            TravelPackageEntity? updatedTravelPackage = _travelPackageService.UpdateTravelPackage(id, data);
            return Ok(updatedTravelPackage);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        bool result = _travelPackageService.DeleteTravelPackage(id);
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