using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController: BaseApiController
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound() { 
            return NotFound();
        }
        [HttpGet("bad-request")]
        public ActionResult GetBadRequest() { 
            return BadRequest(new ProblemDetails { 
                Title = "This is a bad request",
                Status = 400,
              
            });
        }
        [HttpGet("unauthorized")]
        public ActionResult GetUnauthorized() { 
            return Unauthorized();
        }
        [HttpGet("validation-error")]
        public ActionResult GetValidationError() { 
          ModelState.AddModelError("problem 1", "This is problem 1");
          ModelState.AddModelError("problem 2", "This is problem 2");
       
       return ValidationProblem();

        }
        [HttpGet("server-error")]
        public ActionResult GetServerError() { 
          throw new Exception("This is some server error");
        }
    }
}