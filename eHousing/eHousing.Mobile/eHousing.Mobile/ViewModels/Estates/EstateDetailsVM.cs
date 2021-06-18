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



        private MEstate _estate;
        public MEstate Estate
        {
            get { return _estate; }
            set { SetProperty(ref _estate, value); }
        }

        private int _months;
        public int Months
        {
            get { return _months; }
            set
            {
                SetProperty(ref _months, value);
            }
        }

        public EstateDetailsVM()
        {
           
        }
        public EstateDetailsVM(MEstate estate)
        {
            Estate = estate;
            

        }

       

    }
}
