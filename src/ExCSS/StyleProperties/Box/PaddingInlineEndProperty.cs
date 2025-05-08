namespace ExCSS
{
    internal sealed class PaddingInlineEndProperty : Property
    {
        private static readonly IValueConverter StyleConverter =
            Converters.AutoLengthOrPercentConverter.OrDefault(Length.Zero);

        internal PaddingInlineEndProperty()
            : base(PropertyNames.PaddingInlineEnd, PropertyFlags.Unitless | PropertyFlags.Animatable)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}