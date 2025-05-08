﻿namespace ExCSS
{
    internal sealed class PaddingBlockStartProperty : Property
    {
        private static readonly IValueConverter StyleConverter =
            Converters.AutoLengthOrPercentConverter.OrDefault(Length.Zero);

        internal PaddingBlockStartProperty()
            : base(PropertyNames.PaddingBlockStart, PropertyFlags.Unitless | PropertyFlags.Animatable)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}