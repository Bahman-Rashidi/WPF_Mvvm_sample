using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;


namespace WPFDemo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// //backtoMainCommand
        public MainViewModel()
        {
            //if (IsInDesignMode)
            //{
            //    Title = "Hello MVVM Light (Design Mode)";
            //}
            //else
            //{
            //    Title = "Hello MVVM Light";
            //}


            products = new ObservableCollection<Product>();

            List<IMyAction> HotChoclateActoions = new List<IMyAction>();
         

            HotChoclateActoions.Add(new BoilingWaterAction2() { Title= "Boil water" });
            HotChoclateActoions.Add(new AddDrinkingChocolateToCupAction2() { Title = "Add drinking chocolate to cup" });
            HotChoclateActoions.Add(new AddWaterAction2() { Title = "Add water" });

            products.Add(new HotChoclate(HotChoclateActoions, "/WPFDemo;component/Images/hot_chocolate.jpg", "Hot Choclate") { });

            List<IMyAction> IcedCoffeeActopns = new List<IMyAction>();

            IcedCoffeeActopns.Add(new CrushIceAction() { Title = "Crush Ice" });

            IcedCoffeeActopns.Add(new AddIceToBlenderAction() { Title = "Add ice to blender" });
            IcedCoffeeActopns.Add(new AddCoffeeSyrupToBlenderAction() { Title = "Add coffee syrup to blender" });
            IcedCoffeeActopns.Add(new BlendIngredientsAction() { Title = "Blend ingredients" });
            IcedCoffeeActopns.Add(new AddIngredients() { Title = "Add ingredients" });
            products.Add(new IcedCoffee(IcedCoffeeActopns, "/WPFDemo;component/Images/iced_coffee.jpg", "Iced Coffee") { });




            List<IMyAction> LemonTeaActions = new List<IMyAction>();
            LemonTeaActions.Add(new BoilingWaterAction2() { Title = "Boil water" });
            LemonTeaActions.Add(new AddWaterAction2() { Title = "Add water" });
            LemonTeaActions.Add(new SteepTeaBagInHotWater() { Title = "Steep tea bag in hot water" });
            LemonTeaActions.Add(new AddLemonAction() { Title = "Add lemon" });
            products.Add(new LemonTea(LemonTeaActions, "/WPFDemo;component/Images/lemon_tea.jpg", " Lemon Tea") { });





            List<IMyAction> WhiteCoffeeWithsugarActions = new List<IMyAction>();
            WhiteCoffeeWithsugarActions.Add(new BoilingWaterAction2() { Title = "Boil water" });
            WhiteCoffeeWithsugarActions.Add(new AddSugarAction() { Title = "Add sugar" });
            WhiteCoffeeWithsugarActions.Add(new AddCoffeeGranulesToCupAction() { Title = "Add coffee granules to cup" });
            WhiteCoffeeWithsugarActions.Add(new AddWaterAction2() { Title = "Add water" });

            WhiteCoffeeWithsugarActions.Add(new AddMilkAction() { Title = " Add milk" });
            products.Add(new WhiteCoffee(WhiteCoffeeWithsugarActions, "/WPFDemo;component/Images/white_coffee.jpg", " Lemon Tea") { });




            OrderCommand = new RelayCommand(StartOrderMethod);

            this.backtoMainCommand = new RelayCommand<Window>(this.CloseWindow);
        }

        public RelayCommand<Window> backtoMainCommand { get; private set; }
        private void CloseWindow(Window window)
        {
            SelectedProduct.ProductOrderState = ProductOrderState.Srart;
            foreach (var item in SelectedProduct.ActionList)
            {
                item.reset();
            }
            //SelectedProduct.ProductOrderState
            SelectedProduct = null;
            if (window != null)
            {
                window.Close();
             
            }


        }

        public string Title { get; set; }

        



        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set
            {
                if (value != products)
                {
                    products = value;
                    RaisePropertyChanged("Products");
                }
            }
        }



        private Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                if (value != selectedProduct)
                {
                    selectedProduct = value;
                    RaisePropertyChanged("SelectedProduct");

                    if (selectedProduct != null)
                    {
                        DetalsWindows newForm = new DetalsWindows(); //create your new form.

                        newForm.Show(); //show the new form.
                    }
                    
                }
            }
        }



        public ICommand OrderCommand { get; private set; }

        private void StartOrderMethod()
        {
            switch (SelectedProduct.ProductOrderState)
            {

                case ProductOrderState.Processing:

                    SelectedProduct.IsCanceled = true;
                    return;

                case ProductOrderState.Done:

                    System.Windows.MessageBox.Show("your order was completed", "");
                    return;

                 

                case ProductOrderState.Canceled:

                    SelectedProduct.IsCanceled = true;
                    return;
                   
                case ProductOrderState.Srart:

                   
                    break;

            }

            SelectedProduct.prepare();
            SelectedProduct.ProductOrderState = ProductOrderState.Processing;
          
        }

    }



    public class imageconverter : IValueConverter
    {
        public string Source { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

       

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        
    }
}