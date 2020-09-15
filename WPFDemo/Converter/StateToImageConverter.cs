using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace WPFDemo
{
  public  class StateToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {

            string src = "";
            if (value != null)
            {
                ActionIconState stateIcon = (ActionIconState)value;

                switch (stateIcon)
                {
                    case ActionIconState.New:
                        src = "/WPFDemo;component/Images/icon/line.png";
                        break;
                    case ActionIconState.Processing:
                        src = "/WPFDemo;component/Images/icon/wait.gif";
                        break;
                    case ActionIconState.Done:
                        src = "/WPFDemo;component/Images/icon/ok.png";
                        break;
                    default:
                        src = "/WPFDemo;component/Images/icon/line.png";
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
