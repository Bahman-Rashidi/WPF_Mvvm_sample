using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFDemo
{
    public  class EnaableBtnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {

            bool src = true;
            if (value != null)
            {
                ProductOrderState stateIcon = (ProductOrderState)value;

                switch (stateIcon)
                {
                    case ProductOrderState.Canceled:
                        src = true;
                        break;
                    case ProductOrderState.Done:
                        src = true;
                        break;
                    case ProductOrderState.Srart:
                        src = true;
                        break;

                    case ProductOrderState.Processing:
                        src = false;
                        break;
                    default:
                        src = true;
                        break;


                }



                //requestImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/service.png"));
                return src;
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
