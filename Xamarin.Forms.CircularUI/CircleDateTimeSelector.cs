﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.CircularUI
{
    /// <summary>
    /// The CircleDateTimeSelector is a view that can change the value by bezel action by touching each item of "Year: Month: Day" and "Hour: Minute: AM / PM"
    /// </summary>
    /// <since_tizen> 4 </since_tizen>
    public class CircleDateTimeSelector : Xamarin.Forms.View, IRotaryFocusable
    {
        /// <summary>
        /// BindableProperty. Identifies the MarkerColor bindable property.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public static readonly BindableProperty MarkerColorProperty = BindableProperty.Create(nameof(MarkerColor), typeof(Color), typeof(CircleDateTimeSelector), Color.Default);
        /// <summary>
        /// BindableProperty. Identifies the ValueType bindable property.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public static readonly BindableProperty ValueTypeProperty = BindableProperty.Create(nameof(ValueType), typeof(DateTimeType), typeof(CircleDateTimeSelector), DateTimeType.Date);
        /// <summary>
        /// BindableProperty. Identifies the DateTime bindable property.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public static readonly BindableProperty DateTimeProperty = BindableProperty.Create(nameof(DateTime), typeof(DateTime), typeof(CircleDateTimeSelector), DateTime.Now);
        /// <summary>
        /// BindableProperty. Identifies the MaximumDate bindable property.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public static readonly BindableProperty MaximumDateProperty = BindableProperty.Create(nameof(MaximumDate), typeof(DateTime), typeof(CircleDateTimeSelector), DateTime.Now + TimeSpan.FromDays(3650));
        /// <summary>
        /// BindableProperty. Identifies the MinimumDate bindable property.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public static readonly BindableProperty MinimumDateProperty = BindableProperty.Create(nameof(MinimumDate), typeof(DateTime), typeof(CircleDateTimeSelector), new DateTime(1900, 1, 1));

        /// <summary>
        /// Gets or sets Marker color
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public Color MarkerColor { get => (Color)GetValue(MarkerColorProperty); set => SetValue(MarkerColorProperty, value); }
        /// <summary>
        /// Gets or sets DateTimeType value. If it is Time, the UI will be changed to enable time selection. If it is a Date, the date can be changed.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public DateTimeType ValueType { get => (DateTimeType)GetValue(ValueTypeProperty); set => SetValue(ValueTypeProperty, value); }
        /// <summary>
        /// Gets or sets the date / time.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public DateTime DateTime { get => (DateTime)GetValue(DateTimeProperty); set => SetValue(DateTimeProperty, value); }
        /// <summary>
        /// Gets or sets the maximum date when ValueType is Date.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public DateTime MaximumDate { get => (DateTime)GetValue(MaximumDateProperty); set => SetValue(MaximumDateProperty, value); }
        /// <summary>
        /// Gets or sets the minimum date when ValueType is Date.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public DateTime MinimumDate { get => (DateTime)GetValue(MinimumDateProperty); set => SetValue(MinimumDateProperty, value); }
    }
}
