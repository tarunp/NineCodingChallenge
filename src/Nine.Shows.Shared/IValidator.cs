namespace Nine.Shows.Shared
{
    public interface IValidator<T>
    {
        bool Validate(T value);
    }
}
