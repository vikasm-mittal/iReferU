namespace SimpliVity.Common.Converters
{
    using System;
    using Xamarin.Forms;

    /// <summary>
    /// Reverses bool value true to false and false to true
    /// </summary>
    public class ReverseBooleanConverter : IValueConverter
    {
        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        public ReverseBooleanConverter() { }

        #endregion

        #region IValueConverter Members

        /// <summary>
        /// Converts true to false and vice versa
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="targetType">
        /// The target type.
        /// </param>
        /// <param name="parameter">
        /// The parameter.
        /// </param>
        /// <param name="culture">
        /// The culture.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (null == value)
            {
                return null;
            }
            return !(bool)value;            
        }

        /// <summary>
        /// The convert back, true to false and vice versa
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="targetType">
        /// The target type.
        /// </param>
        /// <param name="parameter">
        /// The parameter.
        /// </param>
        /// <param name="culture">
        /// The culture.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// Returns not implemented exception.
        /// </exception>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (null == value)
            {
                return null;
            }
            return !(bool)value;
        }
        #endregion
    }
}
