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
        BoxView[,] boxs = new BoxView[5, 5];
        int i, j;
        Image img;
        public Trips_traps_trull()
        {
            this.BackgroundColor = Color.Black;
             Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},

                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},

                }
            }; 
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    
                    img = new Image { Source = ImageSource.FromFile("index.png") };

                    grid.Children.Add(img, i, j);
                    var tap = new TapGestureRecognizer();
                    
                    img.GestureRecognizers.Add(tap);
                    tap.Tapped += async (object sender, EventArgs e) =>
                    {
                        
                        Image img = sender as Image;
                        if (img.Source == ImageSource.FromFile("nolik.png"))
                        {
                            img.Source = ImageSource.FromFile("krestik.png");
                        }
                        else
                        {
                            img.Source = ImageSource.FromFile("nolik.png");
                        }
                    };
                }
            }
            Content = grid;
        }
    }
}
