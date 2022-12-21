using System;
namespace MauiTestApp.Service
{
	public class SettingsService : ISettingsService
    {
		public SettingsService()
		{
		}

        public string AuthAccessToken { get => string.Empty; set => throw new NotImplementedException(); }
        public string AuthIdToken { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UseMocks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdentityEndpointBase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string GatewayShoppingEndpointBase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string GatewayMarketingEndpointBase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UseFakeLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AllowGpsLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

