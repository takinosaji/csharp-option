namespace CSharp.Option
{
    public static class OptionExtensions
    {
        public static Option<T> ToSome<T>(this T @object) =>
            Option<T>.Some(@object);

        public static Option<T> ToOption<T>(this T @object)
            where T: class?
        {
            return @object is null
                ? Option<T>.None
                : Option<T>.Some(@object);
        }

        public static Option<T> DefaultToOption<T>(this T @object)
            where T: struct
        {
            return @object.Equals(default)
                ? Option<T>.None
                : Option<T>.Some(@object);
        }

        public static T? ToNullable<T>(this Option<T> option)
            where T: struct
        {
            return option == Option<T>.None
                ? null
                : option.Value;
        }
    }
}