namespace CSharp.Option
{
    public static class OptionExtensions
    {
        public static Option<T> ToOption<T>(this T @object) =>
            Option<T>.Some(@object);

        public static T? ToNullable<T>(this Option<T> option)
            where T : struct =>
            option == Option<T>.None
                ? null
                : option.Value;
    }
}