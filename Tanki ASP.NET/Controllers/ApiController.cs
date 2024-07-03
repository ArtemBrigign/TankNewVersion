using Microsoft.AspNetCore.Mvc;
using Tanki_ASP.NET.Game;

namespace Tanki_ASP.NET.Controllers
{
	public class ApiController
	{
		private readonly IProfile _profile;
		public ApiController(IProfile profile) {
			_profile = profile;
		}
		string Login(string login, string password)
		{
			return (_profile.ValidateProfile(login, password)) ? "Success" : "Failure";
		}
	}
}
