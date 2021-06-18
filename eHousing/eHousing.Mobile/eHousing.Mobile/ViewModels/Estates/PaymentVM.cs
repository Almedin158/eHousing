using Acr.UserDialogs;
using eHousing.Mobile.Helpers;
using eHousing.Mobile.Models;
using eHousing.Mobile.Views.Estates;
using eHousing.Model;
using eHousing.Model.Request;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eHousing.Mobile.ViewModels.Estates
{
    public class PaymentVM : BaseVM
    {
        private readonly APIService estateStatusService = new APIService("EstateStatus");
        private readonly APIService estateService = new APIService("Estate");
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        public PaymentVM()
        {
          
        }
     
        public PaymentVM(INavigation nav, MEstate estate, int months)
        {
            this.Navigation = nav;
            this.months = months;
            this.totalPrice = estate.Price * months;
            SubmitCommand = new Command(async () => await RentEstate());
        }

        private readonly INavigation Navigation;
        public MEstate Estate { get; set; }
        public int months { get; set; }


        private string StripeTestApiKey = "pk_test_51J3fTqCH2V85GJHeK6utsc7hHKNHuxzNrIxqYAmIBzoUurr5T5L4Zuc8EclWehaQZujrYgSPsELH768WRqUZfspV00v4IpTblD";

        private CreditCard _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;
        private string _number;
        private string _cvc;
        private int _totalPrice;

        MUser user = SignedInUser.User;
        public string Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }
        public string Cvc
        {
            get { return _cvc; }
            set { SetProperty(ref _cvc, value); }
        }
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }
        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }
        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        public int totalPrice
        {
            get { return _totalPrice; }
            set
            {
                SetProperty(ref _totalPrice, value);
            }
        }
        public CreditCard CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }
        public ICommand SubmitCommand { get; set; }
        private async Task<string> CreateTokenAsync()
        {
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;

                var Tokenoptions = new TokenCreateOptions()
                {
                    Card = new TokenCardOptions()
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = user.FirstName + " " + user.LastName,
                        AddressLine1 = "Adema Buce 13",
                        AddressLine2 = "",
                        AddressCity = "Sarajevo",
                        AddressZip = "71000",
                        AddressState = "Sarajevo",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "usd",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> MakePaymentAsync(string token)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51J3fTqCH2V85GJHeUgxvmUtIa5lLchyuUkZJlvDgDOhnERBMuI4dSEgjPJOGikC8z4KX79585DT9EyYRFU9oFNFg0034CeXecA";

                var options = new ChargeCreateOptions();

                options.Amount = Convert.ToInt64(Estate.Price) * 100;
                options.Currency = "usd";
                options.Description = Estate.EstateName;
                options.Source = stripeToken.Id;
                options.StatementDescriptor = "Custom descriptor";
                options.Capture = true;
                options.ReceiptEmail = user.Email.ToString();
                var service = new ChargeService();
                Charge charge = service.Create(options);
                UserDialogs.Instance.Alert("Purchase was successful!");
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(Estate.EstateName + " (CreateCharge)" + ex.Message);
                throw ex;
            }
        }
        public async Task RentEstate()
        {
            if (Estate.IsOccupied == true)
            {
                UserDialogs.Instance.Alert("Sadly, the estate is already occupied", "Payment failed", "OK");
                return;
            }


            if (ExpMonth == null || ExpMonth == "" || ExpYear == null || ExpYear == "" || Number == null || Number == "" || Cvc == null || Cvc == "")
            {
                UserDialogs.Instance.Alert("You have to fill all fields!", "Payment failed", "OK");
                return;
            }
            if (ExpMonth != null || ExpMonth != "" || ExpYear != null || ExpYear != "" || Number != null || Number != "" || Cvc != null || Cvc != "")
            {
                if (!IsDigitsOnly(ExpMonth) || !IsDigitsOnly(ExpMonth) || !IsDigitsOnly(Number) || !IsDigitsOnly(Cvc))
                {
                    UserDialogs.Instance.Alert("You can't use letters!", "Payment failed", "OK");
                    return;
                }
            }
            CreditCardModel = new CreditCard();
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CreditCardModel.Number = Number;
            CreditCardModel.Cvc = Cvc;
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing ...");
                await Task.Run(async () =>
                {
                    var Token = CreateTokenAsync();
                    Console.Write(Estate.EstateName + "Token :" + Token);
                    if (Token.ToString() != null)
                    {
                        IsTransectionSuccess = await MakePaymentAsync(Token.Result);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write(Estate.EstateName + ex.Message);
            }
            finally
            {
                if (IsTransectionSuccess)
                {
                    var date = DateTime.Now;
                    var request = new EstateStatusUpsertRequest()
                    {
                        EstateId = Estate.EstateId,
                        UserId = SignedInUser.User.UserId,
                        OccupiedSince = DateTime.Now,
                        OccupiedTill = date.AddMonths(months),
                        Months = months,
                        TotalPrice = Estate.Price * months
                    };
                    await estateStatusService.Insert<MEstateStatus>(request);
                    await Navigation.PushAsync(new MyEstatesPage());
                    Console.Write(Estate.EstateName + "Payment Successful");
                    
                    var req = new EstateUpsertRequest
                    {
                        EstateDescription=Estate.EstateDescription,
                        PetsAllowed=Estate.PetsAllowed.Value,
                        CreationDate=Estate.CreationDate,
                        EstateName=Estate.EstateName,
                        EstateTypeId=Estate.EstateTypeId,
                        FloorSpace=Estate.FloorSpace,
                        Image=Estate.Image,
                        NumberOfRooms=Estate.NumberOfRooms,
                        Price=Estate.Price,
                        StreetId=Estate.StreetId,
                        UserId=Estate.UserId,

                        IsOccupied = true,
                    };
                    await estateService.Update<MEstate>(Estate.EstateId, req);

                    UserDialogs.Instance.HideLoading();

                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    //UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                    Console.Write(Estate.EstateName + "Payment Failure ");
                }
            }

        }
    }
}
