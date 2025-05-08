﻿namespace ExCSS
{
    internal sealed class PaddingBlockProperty : ShorthandProperty
    {
        private static readonly IValueConverter StyleConverter = Converters.AutoLengthOrPercentConverter.Periodic(
                PropertyNames.PaddingBlockStart, PropertyNames.PaddingBlockEnd)
            .OrDefault(Length.Zero);

        internal PaddingBlockProperty()
            : base(PropertyNames.PaddingBlock)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}