using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFDemo
{
  public  class ButttonChangeColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            
            // Color color = (Color)value;
            if (value != null)
            {
                ProductOrderState stateIcon = (ProductOrderState)value;

                switch (stateIcon)
                {
                    case ProductOrderState.Canceled:
                        return Brushes.Red;
                       
                    case ProductOrderState.Done:
                        return Brushes.Green;
                    
                    case ProductOrderState.Srart:
                        return Brushes.Gray;
                       

                    case ProductOrderState.Processing:
                        return Brushes.Gray;
                        
                    default:
                        return Brushes.Gray;
                     


                }



             
            }
            else return null;
        }

       

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return null;
        }

       
    }
}
