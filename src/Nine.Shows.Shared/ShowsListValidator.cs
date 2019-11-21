using Nine.Shows.DTOs;

namespace Nine.Shows.Shared
{
    public class ShowsListValidator<T> : IValidator<T> where T : ShowsList
    {
       public bool Validate(T value)
        {
            if(value != null && value.payload != null)
            {
                return true;
            }

            return false;
        }
    }
}
