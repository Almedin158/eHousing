using eHousing.Mobile.Views.Estates;
using eHousing.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eHousing.Mobile.ViewModels.Estates
{
    public class EstateDetailsVM:BaseVM
    {
        public ICommand OpenGalleryCommand;

        private MEstate _estate;
        public MEstate Estate
        {
            get { return _estate; }
            set { SetProperty(ref _estate, value); }
        }

        public EstateDetailsVM()
        {
            OpenGalleryCommand = new Command(async () => await ShowGallery());
        }
        public EstateDetailsVM(MEstate estate)
        {
            Estate = estate;
            

        }
        public EstateDetailsVM(INavigation nav)
        {
            this.Navigation = nav;
            OpenGalleryCommand = new Command(async () => await ShowGallery());
          

        }
        private readonly INavigation Navigation;

        public async Task ShowGallery()
        {
            await Navigation.PushAsync(new EstateGalleryPage(Estate));
        }


    }
}
