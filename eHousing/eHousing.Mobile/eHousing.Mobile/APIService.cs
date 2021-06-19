using eHousing.Model;
using eHousing.Model.Request;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eHousing.Mobile
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route;

        private readonly string ApiURL = "http://localhost:31186/api"; 
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<MUser> Authenticate(UserAuthenticationRequest request)
        {
            try
            {
                var url = $"{ApiURL}/User/Authenticate";
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<MUser>();
            }
            catch (FlurlHttpException)
            {
                return default;
            }
        }

        public async Task<MUser> Register(UserUpsertRequest request)
        {
            try
            {
                var url = $"{ApiURL}/User/Register";
                return await url.PostJsonAsync(request).ReceiveJson<MUser>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default;
            }
        }
        public async Task<T> Get<T>(object search)
        {
            var url = $"{ApiURL}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException)
            {
                return default;
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{ApiURL}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            try
            {
                var url = $"{ApiURL}/{_route}";

                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<T> Update<T>(int ID, object request)
        {
            try
            {
                var url = $"{ApiURL}/{_route}/{ID}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<bool> Delete<T>(int ID)
        {
            try
            {
                var url = $"{ApiURL}/{_route}/{ID}";

                return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<bool>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return false;
            }
        }
        public async Task<List<MEstate>> GetFavoriteEstates(int ID)
        {
            try
            {
                var url = $"{ApiURL}/User/{ID}/FavoriteEstate";
               

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<List<MEstate>>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default;
            }
        }
        public async Task<MEstate> InsertFavoriteEstate(int UserId,int EstateId)
        {
            try
            {
                var url = $"{ApiURL}/User/FavoriteEstate/{EstateId}?UserId={UserId}";

                return await url.WithBasicAuth(Username, Password).PostJsonAsync(null).ReceiveJson<MEstate>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default;
            }
        }
        public async Task<MEstate> DeleteFavoriteEstate(int UserId, int EstateId)
        {
            try
            {
                var url = $"{ApiURL}/User/FavoriteEstate/{EstateId}?UserId={UserId}";

                return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<MEstate>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default;
            }
        }
    }
}