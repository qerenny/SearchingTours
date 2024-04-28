using Microsoft.AspNetCore.Mvc;
using SearchingTours.Application.Contracts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Presentation.Http.Requests;
using SearchingTours.Presentation.Http.Responses;

namespace SearchingTours.Presentation.Http.Controllers;

[ApiController]
[Route("review")]
public class ReviewController : ControllerBase
{
    private readonly IReviewService _reviewService;

    public ReviewController(IReviewService reviewService)
    {
        _reviewService = reviewService; 
    }

    [HttpGet("{id}")] 
    public ActionResult<ReviewEntity> Get(Guid id)
    {
        ReviewEntity? review = _reviewService.GetReview(id);
        if (review == null)
        {
            return NotFound();
        }

        return Ok(review);
    }

    [HttpPost]
    public ActionResult<ReviewPostResponse> Post([FromBody] ReviewPost data)
    {
        try
        {
            ReviewEntity createdReview = _reviewService.AddReview(data.TravelPackageId, data.AuthorName, data.Text, data.Rating);
            return CreatedAtAction(nameof(Get), new { id = createdReview.Id }, createdReview);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while creating the review." + ex);
        }
    }

    [HttpPut("{id}")]
    public ActionResult<ReviewEntity> Update(Guid id, [FromBody] Dictionary<string, string> data)
    {
        try
        {
            ReviewEntity? updatedReview = _reviewService.UpdateReview(id, data);
            return Ok(updatedReview);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        bool result = _reviewService.Delete(id);
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