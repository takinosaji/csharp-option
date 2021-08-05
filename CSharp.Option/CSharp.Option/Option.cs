using System;

namespace CSharp.Option
{
    public class Option<T>
    {
        public T Value { get; }
        public bool HasObject { get; }

        private Option()
        {
            HasObject = false;
        }

        private Option(T @object)
        {
            Value = @object;
            HasObject = true;
        }

        public static Option<T> None { get; } = new();

        public static Option<T> Some(T obj) => new(obj);
    }
}