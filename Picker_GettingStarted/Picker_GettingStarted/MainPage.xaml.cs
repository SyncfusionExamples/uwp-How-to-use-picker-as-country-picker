using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfPicker.XForms;
using Xamarin.Forms;

namespace Picker_GettingStarted
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            /// <summary>
            ///Collection to add the columnn items.
            /// </summary>
            ObservableCollection<object> countryNameCollection = new ObservableCollection<object>();

            /// <summary>
            ///Picker Item Loaded event.
            /// </summary>
            picker.OnPickerItemLoaded += PickerItemLoaded;

            countryNameCollection.Add("India.png");
            countryNameCollection.Add("UAE.png");
            countryNameCollection.Add("USA.png");
            countryNameCollection.Add("UK.png");
            countryNameCollection.Add("Germany.png");
            countryNameCollection.Add("Canada.png");
            countryNameCollection.Add("China.png");
            picker.ItemsSource = countryNameCollection;
           
        }

        /// <summary>
        ///Picker Item Loaded event.
        /// </summary>
        private void PickerItemLoaded(object sender, PickerViewEventArgs e)
        {
            Country country = new Country() { CountryImage = e.Item.ToString() };
            e.View = new CustomView(country);
        }

        /// <summary>
        ///Button clicked event.
        /// </summary>
        private void Button_Clicked(object sender, EventArgs e)
        {
            picker.IsOpen = true;
        }

    }
}
