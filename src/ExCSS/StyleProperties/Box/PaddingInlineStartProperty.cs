﻿namespace ExCSS
{
    internal sealed class PaddingInlineStartProperty : Property
    {
        private static readonly IValueConverter StyleConverter =
            Converters.AutoLengthOrPercentConverter.OrDefault(Length.Zero);

        internal PaddingInlineStartProperty()
            : base(PropertyNames.PaddingInlineStart, PropertyFlags.Unitless | PropertyFlags.Animatable)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}