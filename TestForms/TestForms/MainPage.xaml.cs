using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestForms.models;
using TestForms.restapi;
using Xamarin.Forms;

namespace TestForms
{
    public partial class MainPage : ContentPage
    {
        RestService _restService;

        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
        }


        async void Button_Clicked(object sender, EventArgs e)
        {
            List<Character> characters
                = await _restService.GetCharacters(Constants.RickMortyApiURL);
            collectionView.ItemsSource = characters;
            Debug.WriteLine("DEBUG: {0}",characters.Count);
        }
    }
}
