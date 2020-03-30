using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Picker_GettingStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomView : ContentView
    {
        /// <summary>
        ///Variable to store country names
        /// </summary>
        Country _country;

        int i;
        public CustomView(Country country)
        {
            i = 0;
            _country = country;
            InitializeComponent();

            foreach (char count in country.CountryImage)
            {
                i++;
            }

            _country.CountryText = country.CountryImage.Remove(i - 4);

            switch (_country.CountryText)
            {
                case "Germany":
                    _country.CountryCode = "+49";
                    break;
                case "UAE":
                    _country.CountryCode = "+971";
                    break;
                case "USA":
                    _country.CountryCode = "+1";
                    break;
                case "UK":
                    _country.CountryCode = "+44";
                    break;
                case "China":
                    _country.CountryCode = "+86";
                    break;
                case "Canada":
                    _country.CountryCode = "+1";
                    break;
                default:
                    _country.CountryCode = "+91";
                    break;
            }
            this.BindingContext = _country;
        }
    }

   
}