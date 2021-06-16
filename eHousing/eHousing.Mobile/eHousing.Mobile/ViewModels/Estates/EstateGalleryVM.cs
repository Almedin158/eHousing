using eHousing.Model;
using eHousing.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eHousing.Mobile.ViewModels.Estates
{
    public class EstateGalleryVM:BaseVM
    {
        private readonly APIService pictureService = new APIService("Picture");
        public ObservableCollection<MPicture> pictureList { get; set; } = new ObservableCollection<MPicture>();

        public ICommand InitCommand { get; set; }

        private MEstate _estate;
        public MEstate Estate
        {
            get { return _estate; }
            set { SetProperty(ref _estate, value); }
        }
        public EstateGalleryVM()
        {
            InitCommand = new Command(async () => await Init(Estate));
        }

        public EstateGalleryVM(MEstate estate)
        {
            Estate = estate;
            InitCommand = new Command(async () => await Init(Estate));
        }

        public async Task Init(MEstate estate)
        {
            var request = new PictureSearchRequest()
            {
                EstateId = estate.EstateId
            };
            var pictures = await pictureService.Get<List<MPicture>>(request);

            foreach(var p in pictures) {

                pictureList.Add(p);
            }
        }



    }
}
