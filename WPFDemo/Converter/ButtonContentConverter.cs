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
  public  class ButtonContentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {

            String src = "";
            if (value != null)
            {
                ProductOrderState stateIcon = (ProductOrderState)value;

                switch (stateIcon)
                {
                    case ProductOrderState.Canceled:
                        src = "Order Canceled !";
                        break;
                    case ProductOrderState.Done:
                        src = "Order Completed";
                        break;
                    case ProductOrderState.Srart:
                        src = "Start";
                        break;

                    case ProductOrderState.Processing:
                        src = "Cancel Order";
                        break;
                    default:
                        src = "Start";
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
