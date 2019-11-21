using Nine.Shows.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nine.Shows.Shared;
using Nine.Shows.Api.Attributes;
using Nine.Shows.Business;

namespace Nine.Shows.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class TVGuideController : ControllerBase
    {
        private readonly ILogger<TVGuideController> _logger;
        private readonly ITVShowsFilter _showsFilter;

        public TVGuideController(ILogger<TVGuideController> logger, ITVShowsFilter showsFilter)
        {
            this._logger = logger;
            this._showsFilter = showsFilter;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return WellKnownConstants.WelcomeMessage;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ValidateModel]
        public ActionResult<Result> Post([FromBody] ShowsList showsList)
        {
            return this._showsFilter.GetDRMEnabledShows(showsList);
        }
    }
}
