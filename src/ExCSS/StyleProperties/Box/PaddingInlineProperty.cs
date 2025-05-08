namespace ExCSS
{
    internal sealed class PaddingInlineProperty : ShorthandProperty
    {
        private static readonly IValueConverter StyleConverter = Converters.AutoLengthOrPercentConverter.Periodic(
                PropertyNames.PaddingInlineStart, PropertyNames.PaddingInlineEnd)
            .OrDefault(Length.Zero);

        internal PaddingInlineProperty()
            : base(PropertyNames.PaddingInline)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}