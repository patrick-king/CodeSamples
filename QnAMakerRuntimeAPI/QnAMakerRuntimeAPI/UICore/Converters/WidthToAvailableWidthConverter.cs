﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;

namespace QnAMakerRuntimeAPI.UICore.Converters
{
    class WidthToAvailableWidthConverter: IValueConverter
        {
            public object Convert(object o, Type type, object parameter, CultureInfo culture)
            {
                ListView l = o as ListView;
                GridView g = l.View as GridView;
                double total = 0;
                for (int i = 0; i < g.Columns.Count - 1; i++)
                {
                total += g.Columns[i].Width;
                }
                return (l.ActualWidth - total);
            }

            public object ConvertBack(object o, Type type, object parameter, CultureInfo culture)
            {
                throw new NotSupportedException();
            }
        
    }
}
