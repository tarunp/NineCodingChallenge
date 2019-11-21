using Nine.Shows.DTOs;
using FluentAssertions;
using Moq;
using Nine.Shows.Shared;
using Nine.Shows.Test.TestData;
using Xunit;
using Nine.Shows.Business;

namespace Nine.Shows.Test
{
    public class ShowsFilterTest
    {
        private readonly TVShowsFilter _showsFilter;
        private  Mock<IValidator<ShowsList>> _validator;
        public ShowsFilterTest()
        {
            this._validator = new Mock<IValidator<ShowsList>>();
            this._showsFilter = new TVShowsFilter(this._validator.Object);
           
        }

        [Fact]
        public void validjson_returndrm_episodes_test()
        {
            this._validator.Setup(val => val.Validate(It.IsAny<ShowsList>())).Returns(true);
            var result = this._showsFilter.GetDRMEnabledShows(TVShowsPayload.showslist_validjson);
            result.response.Capacity.Should().BeGreaterOrEqualTo(1);
        }

        [Fact]
        public void validjson_nodrm_episodes_test()
        {
            this._validator.Setup(val => val.Validate(It.IsAny<ShowsList>())).Returns(true);
            var result = this._showsFilter.GetDRMEnabledShows(TVShowsPayload.showslist_validjson_noepisodes);
            result.response.Capacity.Should().Be(0);
        }

        [Fact]
        public void invalidjson_nodrm_episodes_test()
        {
            this._validator.Setup(val => val.Validate(It.IsAny<ShowsList>())).Returns(false);
            var result = this._showsFilter.GetDRMEnabledShows(TVShowsPayload.showslist_invalidjson);
            result.response.Should().BeNull();
        }
    }
}
