using Nine.Shows.DTOs;
using System.Collections.Generic;

namespace Nine.Shows.Test.TestData
{
    public static class TVShowsPayload
    {
        public static ShowsList showslist_validjson = new ShowsList()
        {
             payload = new List<Payload>()
             {
                  new Payload()
                  {
                       drm = true,
                       episodeCount = 2,
                       title = "Dummy title",
                       slug = "Dummy-slug",
                       image = new Image()
                       {
                           showImage = "http://imagepath/"
                       }
                  },
                  new Payload()
                  {
                       drm = true,
                       episodeCount = 0,
                       title = "Dummy title",
                       slug = "Dummy-slug",
                       image = new Image()
                       {
                           showImage = "http://imagepath/"
                       }
                  }
             }
        };

        public static ShowsList showslist_validjson_noepisodes = new ShowsList()
        {
            payload = new List<Payload>()
             {
                  new Payload()
                  {
                       drm = true,
                       episodeCount = 0,
                       title = "Dummy title",
                       slug = "Dummy-slug",
                       image = new Image()
                       {
                           showImage = "http://imagepath/"
                       }
                  },
                  new Payload()
                  {
                       drm = true,
                       episodeCount = 0,
                       title = "Dummy title",
                       slug = "Dummy-slug",
                       image = new Image()
                       {
                           showImage = "http://imagepath/"
                       }
                  }
             }
        };

        public static ShowsList showslist_invalidjson = new ShowsList();
    }
}
