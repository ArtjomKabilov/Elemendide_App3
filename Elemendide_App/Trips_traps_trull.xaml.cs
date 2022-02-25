using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trips_traps_trull : ContentPage
    {
        Image img;
        bool x = false;
        List<Image> newList=new List<Image>();

        public Trips_traps_trull()
        {
            
            Grid g = new Grid
            {
                
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions =
                {
                    new RowDefinition{Height = new GridLength(2, GridUnitType.Star) },
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width = GridLength.Auto },
                }
            };
            Grid g2 = new Grid
            {
                RowSpacing = 0,
                RowDefinitions =
                {
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width= new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width= new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width= new GridLength(1, GridUnitType.Star)},
                }
            };
            g2.BackgroundColor = Color.White;
            g.BackgroundColor = Color.White;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    img = new Image();
                    img.Source = ImageSource.FromFile("index.png");
                    img.StyleId = b++.ToString();
                    g2.Children.Add(img, i, j);
                    var tap = new TapGestureRecognizer();
                    img.GestureRecognizers.Add(tap);
                    tap.Tapped += async (object sender, EventArgs e) =>
                    {
                        
                        Image img = sender as Image;
                        newList.Add(img);
                        if (x)
                        {
                            img.Source = ImageSource.FromFile("krestik.png");
                            img.GestureRecognizers.Clear();
                            x = !x;
                        }
                        else
                        {
                            img.Source = ImageSource.FromFile("nolik.png");
                            img.GestureRecognizers.Clear();
                            x = !x;
                        }

                        win();
                        
                            
                        
                    };
                }
                
            }
            g.Children.Add(g2);
            Content = g;

        }
        private async void win()
        {

            /*if (getImage("3").Source == getImage("4").Source && getImage("4").Source == getImage("5").Source && getImage("5").Source == getImage("3").Source)
            {
                await DisplayAlert("", "WIN", "Go");

            }*/
            string i;
            if (x)
            {
                i = "krestik.png";
            }
            else
            {
                i = "nolik.png";
            }
            if (getImage("0", i) && getImage("1", i) && getImage("2", i))
            {
                await DisplayAlert("", "WIN", "Go");

            }
            /*if (getImage("6").Source == getImage("7").Source && getImage("7").Source == getImage("8").Source && getImage("8").Source == getImage("6").Source)
            {
                await DisplayAlert("", "WIN", "Go");

            }
            if (getImage("0").Source == getImage("4").Source && getImage("4").Source == getImage("8").Source && getImage("8").Source == getImage("0").Source)
            {
                await DisplayAlert("", "WIN", "Go");

            }
            if (getImage("0").Source == getImage("3").Source && getImage("3").Source == getImage("6").Source && getImage("6").Source == getImage("0").Source)
            {
                await DisplayAlert("", "WIN", "Go");

            }
            if (getImage("2").Source == getImage("4").Source && getImage("4").Source == getImage("6").Source && getImage("6").Source == getImage("2").Source)
            {
                await DisplayAlert("", "WIN", "Go");

            }
            if (getImage("2").Source == getImage("5").Source && getImage("5").Source == getImage("8").Source && getImage("8").Source == getImage("2").Source)
            {
                await DisplayAlert("", "WIN", "Go");

            }
            if (getImage("1").Source == getImage("4").Source && getImage("4").Source == getImage("7").Source && getImage("7").Source == getImage("1").Source)
            {
                await DisplayAlert("", "WIN", "Go");

            }*/
            
        }
        private bool getImage(string n, string m)
        {
            foreach (Image item in newList)
            {
                if (item.StyleId == n && item.Source == ImageSource.FromFile(m))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
