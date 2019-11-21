using Nine.Shows.DTOs;
using FluentAssertions;
using Nine.Shows.Shared;
using Nine.Shows.Test.TestData;
using Xunit;

namespace Nine.Shows.Test
{
    public class ShowsListValidatorTest
    {
        private readonly ShowsListValidator<ShowsList> _showsListValidator;
        public ShowsListValidatorTest()
        {
            this._showsListValidator = new ShowsListValidator<ShowsList>();
        }

        [Fact]
        public void validmodel_returns_true()
        {
            var result = this._showsListValidator.Validate(TVShowsPayload.showslist_validjson);
            result.Should().BeTrue();
        }

        [Fact]
        public void invalidmodel_returns_false()
        {
            var result = this._showsListValidator.Validate(TVShowsPayload.showslist_invalidjson);
            result.Should().BeFalse();
        }
    }
}
