using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace ExemploXamarinGoogleMapas
{
    public partial class MainPage : ContentPage
    {
   
        readonly Pin _pinTokyo = new Pin()
        {
            Type = PinType.Place,
            Label = "Tokyo SKYTREE",
            Address = "Sumida-ku, Tokyo, Japan",
            Position = new Position(35.71d, 139.81d)
        };


        readonly Pin _pinTokyo2 = new Pin()
        {
            Icon = BitmapDescriptorFactory.DefaultMarker(Color.Gray),
            Type = PinType.Place,
            Label = "Second Pin",
            Position = new Position(35.71d, 139.815d),
            ZIndex = 5
        };

        readonly Pin meuPin = new Pin()
        {
            Icon = BitmapDescriptorFactory.FromBundle("bertuzzi.jpg"),
            Type = PinType.Place,
            Label = "Meu Pin customizado",
            Position = new Position(35.71d, 139.815d),
            ZIndex = 5
        };


        public MainPage()
        {
            InitializeComponent();

            map.MyLocationEnabled = true;
            map.UiSettings.MyLocationButtonEnabled = true;

            _pinTokyo.IsDraggable = true;
           // map.Pins.Add(_pinTokyo);
            map.Pins.Add(meuPin);
            map.SelectedPin = _pinTokyo;
            map.MoveToRegion(MapSpan.FromCenterAndRadius(_pinTokyo.Position, Distance.FromMeters(5000)), true);
        }
    }
}
