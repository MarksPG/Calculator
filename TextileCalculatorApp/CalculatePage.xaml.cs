﻿using TextileCalculatorApp.DataProvider;
using TextileCalculatorApp.Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using System;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TextileCalculatorApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CalculatePage : Page
    {
        //private readonly ObservableCollection<Textile> textileSuspensions = new ObservableCollection<Textile>();

       
        public CalculatePage()
        {
            InitializeComponent();
            APIHelper.InitializeClient();
            GetAllTextiles();
            
            foreach (TextileSuspension value in Enum.GetValues(typeof(TextileSuspension)))
            {
                FontsCombo.Items.Add(value);
            }
        }

        private async void GetAllTextiles()
        {
            TextileDataProvider tdp = new TextileDataProvider();
            var textiles = await tdp.GetTextiles();
            
            foreach (var textile in textiles)
            {
                TextileList.Items.Add(textile);
            }
            TextileList.SelectedIndex = 0;
            
        }

        private void PopulateContent()
        {
            Textile chosenTextile = TextileList.SelectedItem as Textile;

            foreach (var width in chosenTextile.Widths)
            {
                WidthList.Items.Add(width);
            }
            WidthList.SelectedIndex = 0;

            foreach (var colour in chosenTextile.Colours)
            {
                ColourList.Items.Add(colour);
            }
            ColourList.SelectedIndex = 0;
        }


        private void TextileChanged(object sender, SelectionChangedEventArgs e)
        {
            
            WidthList.Items.Clear();
            ColourList.Items.Clear();
            
            PopulateContent();

        }

        private void SelectedWidth(object sender, SelectionChangedEventArgs e)
        {
            Textile chosenTextile = TextileList.SelectedItem as Textile;

            
        }
    

        private void ShowCurrentColourPicture(object sender, SelectionChangedEventArgs e)
        {
            Textile chosenTextile = TextileList.SelectedItem as Textile;
            Colour chosenColour = ColourList.SelectedItem as Colour;

            if (chosenColour != null)
            {
                TextileDataProvider tdp = new TextileDataProvider();


                BitmapImage bitmapImage = new BitmapImage
                {
                    UriSource = new Uri(tdp.GetPictureURL(chosenTextile, chosenColour))
                };
                currentPicture.Source = bitmapImage;
            }
            

        }

    }
}