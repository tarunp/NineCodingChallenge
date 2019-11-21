using Nine.Shows.DTOs;
using Nine.Shows.Shared;
using System.Linq;

namespace Nine.Shows.Business
{
    public class TVShowsFilter : ITVShowsFilter
    {
        private readonly IValidator<ShowsList> _validator;
        public TVShowsFilter(IValidator<ShowsList> validator)
        {
            this._validator = validator;
        }

        public Result GetDRMEnabledShows(ShowsList showsList)
        {
            var result = new Result();
            if (this._validator.Validate(showsList))
            {
                var records = showsList.payload.FindAll(item => item.drm == true && item.episodeCount > 0);
                result.response = records.Select(item => new Response() { image = item.image.showImage, slug = item.slug, title = item.title }).ToList();
            }

            return result;
        }
    }
}
