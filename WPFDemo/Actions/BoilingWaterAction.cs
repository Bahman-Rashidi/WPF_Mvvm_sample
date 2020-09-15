using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Models
{
    //public class BoilingWaterAction : IMyAction, INotifyPropertyChanged
    //{

    //    private ActionState state { get; set; }
    //    public ActionState State
    //    {
    //        get { return state; }
    //        set
    //        {
    //            if (value != state)
    //            {
    //                state = value;

    //                if (PropertyChanged != null)
    //                {
    //                    PropertyChanged(this, new PropertyChangedEventArgs("State"));
    //                }

    //            }
    //        }
    //    }

    //    private ActionIconState iconstate { get; set; }
    //    public ActionIconState Iconstate
    //    {
    //        get { return iconstate; }
    //        set
    //        {
    //            if (value != iconstate)
    //            {
    //                iconstate = value;

    //                if (PropertyChanged != null)
    //                {
    //                    PropertyChanged(this, new PropertyChangedEventArgs("Iconstate"));
    //                }

    //            }
    //        }
    //    }
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public async void doStep()
    //    {
    //        try
    //        {
    //            this.state = ActionState.Processing;
    //            this.Iconstate = ActionIconState.Processing;
    //            await Task.Delay(3000);
    //            // Thread.sleep(10000);
    //            // System.out.println("Boil Water");
    //            this.state = ActionState.Done;
    //            this.Iconstate = ActionIconState.Done;
    //        }
    //        catch (Exception e)
    //        {
    //            //  System.out.println("error while boiling water");
    //            this.state = ActionState.Error;
    //            this.Iconstate = ActionIconState.New;
    //        }
    //    }






    //    private string title = "BoilingWater";
    //    public string Title
    //    {
    //        get { return title; }
    //        set
    //        {
    //            title = value;
    //            if (PropertyChanged != null)
    //            {
    //                PropertyChanged(this, new PropertyChangedEventArgs("Title"));
    //            }
    //        }
    //    }
    //}


    public class BoilingWaterAction2 : Action
    {
    }
    }
