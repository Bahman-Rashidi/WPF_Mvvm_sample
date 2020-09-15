using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public enum ProductOrderState
    {
        Srart, Processing, Done, Canceled
    }
    public abstract class Product : INotifyPropertyChanged
    {

        protected Product(List<IMyAction> actionList, String imageSrc, String title, ProductOrderState orderState)
        {

            this.actionsList = actionList;
            this.imageSrc = imageSrc;
            this.Title = title;
            this.orderState = orderState;

        }


        private ProductOrderState orderState;
        public ProductOrderState ProductOrderState
        {
            get { return orderState; }
            set
            {
                if (value != orderState)
                {
                    orderState = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ProductOrderState"));
                    }

                }
            }
        }

        private List<IMyAction> actionsList;

        public List<IMyAction> ActionList
        {
            get { return actionsList; }
            set
            {
                if (value != actionsList)
                {
                    actionsList = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ActionList"));
                    }

                }
            }
        }


        private String imageSrc;

        public String ImageSrc
        {
            get { return imageSrc; }
            set
            {
                if (value != imageSrc)
                {
                    imageSrc = value;
                    //  RaisePropertyChanged("Products");
                }
            }
        }




        private String title;

        public event PropertyChangedEventHandler PropertyChanged;

        public String Title
        {
            get { return title; }
            set
            {
                if (value != title)
                {
                    title = value;
                    //  RaisePropertyChanged("Title");
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Title"));
                    }
                }
            }
        }


        private bool isCanceled;
        public bool IsCanceled
        {
            get { return isCanceled; }
            set
            {
                if (value != isCanceled)
                {
                    isCanceled = value;
                    //  RaisePropertyChanged("Title");
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("IsCanceled"));
                    }
                }
            }
        }

        public async void prepare()
        {

            try
            {
                bool OperationCompleted = true;
                foreach (IMyAction action in actionsList)
                {
                    if (IsCanceled == false)
                    {

                        action.doStep();
                        await Task.Delay(3000);
                        OperationCompleted = true ;
                    }

                    else {

                         this.ProductOrderState = ProductOrderState.Canceled;
                        OperationCompleted = false;
                        break;
                   

                    }


                }
                if (OperationCompleted)
                {
                    this.ProductOrderState = ProductOrderState.Done;
                }

               

            }
            catch (Exception ex)
            {

                this.ProductOrderState = ProductOrderState.Canceled;
            }
           

          
        }


       

        //constructor injection
    }



    public abstract class Action : IMyAction , INotifyPropertyChanged
    {
        private ActionState state { get; set; }
        public ActionState State
        {
            get { return state; }
            set
            {
                if (value != state)
                {
                    state = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("State"));
                    }

                }
            }
        }

        private ActionIconState iconstate { get; set; }
        public ActionIconState Iconstate
        {
            get { return iconstate; }
            set
            {
                if (value != iconstate)
                {
                    iconstate = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Iconstate"));
                    }

                }
            }
        }




        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;



        public async void doStep()
        {
           
            try
            {
                this.state = ActionState.Processing;
                this.Iconstate = ActionIconState.Processing;
                await Task.Delay(3000);
                // Thread.sleep(10000);
                // System.out.println("Boil Water");
                this.state = ActionState.Done;
                this.Iconstate = ActionIconState.Done;
               
            }
            catch (Exception e)
            {
                //  System.out.println("error while boiling water");
                this.state = ActionState.Error;
                this.Iconstate = ActionIconState.New;
               
            }

            
        }

        public void reset()
        {
            Iconstate = ActionIconState.New;
            State = ActionState.New;

        }

    }
}
