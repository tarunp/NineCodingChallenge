using Nine.Shows.DTOs;

namespace Nine.Shows.Business
{
    public interface ITVShowsFilter
    {
        Result GetDRMEnabledShows(ShowsList inputJson);
    }
}
