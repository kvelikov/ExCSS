namespace ExCSS
{
    internal sealed class PaddingBlockEndProperty : Property
    {
        private static readonly IValueConverter StyleConverter =
            Converters.AutoLengthOrPercentConverter.OrDefault(Length.Zero);

        internal PaddingBlockEndProperty()
            : base(PropertyNames.PaddingBlockEnd, PropertyFlags.Unitless | PropertyFlags.Animatable)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}