using MiFinca.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace MiFinca.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapView : ContentPage
	{
        //Position default Barcelona(ciutat).
        private static Position posDefault = new Position(41.385064, 2.173403);
        private static Position posCurrent;

        public MapView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            //cargamos los pins que representan los anuncios.
            //loadpins();
            //mymap.movetoregion(mapspan.fromcenterandradius(posdefault,
            //    distance.fromkilometers(20)));

            //try
            //{
            //    notify.showloading();

            //    plugin.geolocator.abstractions.position position = await myprofileviewmodel.getlocation();

            //    if (position != null)
            //    {
            //        poscurrent = new position(position.latitude, position.longitude);
            //        mymap.movetoregion(mapspan.fromcenterandradius(poscurrent, distance.fromkilometers(2)));
            //    }
            //    else
            //    {
            //        await navigation.popasync();
            //    }
            //}
            //catch (httprequestexception)
            //{
            //    notify.showtoast(appresources.msg_error_servidor_conexion);
            //}
            //catch (exception ex)
            //{
            //    await myjson.senderrorlogs(ex);
            //}
            //finally
            //{
            //    notify.hideloading();
            //}

        }

        //private async void loadPins()
        //{
        //    try
        //    {
        //        Notify.ShowLoading();
        //        //Creamos lista de anuncios con la peticion al WebService.
        //        List<Advertisements> advList = await MyJson.GetAdvertisementsAsync();
        //        GoogleGeocodeResponseApi geocode;
        //        List<GoogleGeocodeResponseApi.Result> listGeocodeResponse;
        //        List<Pin> listPins = new List<Pin>();


        //        foreach (Advertisements adv in advList)
        //        {
        //            Cities c = MySqlite.GetCity(adv.IdCity);
        //            geocode = await MyJson.GetLocationByAddressAsync(c.Name);
        //            listGeocodeResponse = geocode.Results;

        //            foreach (GoogleGeocodeResponseApi.Result res in listGeocodeResponse)
        //            {
        //                Pin pin = new Pin
        //                {
        //                    Position = new Position(res.Geometry.Location.Lat, res.Geometry.Location.Lng),
        //                    Label = adv.Nickname,
        //                    Address = adv.Race,
        //                    BindingContext = adv
        //                };
        //                pin.Clicked += Pin_Clicked;
        //                listPins.Add(pin);

        //            }

        //        }

        //        foreach (Pin pin in listPins)
        //        {
        //            myMap.Pins.Add(pin);
        //        }

        //    }
        //    catch (HttpRequestException)
        //    {
        //        Notify.ShowToast(AppResources.msg_error_servidor_conexion);
        //    }
        //    catch (Exception ex)
        //    {
        //        await MyJson.SendErrorLogs(ex);
        //    }
        //    finally
        //    {
        //        Notify.HideLoading();
        //    }

        //}

        //private async void Pin_Clicked(object sender, EventArgs e)
        //{
        //    Pin selectedPin = sender as Pin;
        //    Advertisements selectedAdv = ((Advertisements)selectedPin.BindingContext);

        //    await Navigation.PushAsync(new ShowAdvView(selectedAdv.Id));
        //}
    }
}