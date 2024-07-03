namespace Tanki_ASP.NET.Game
{
	public class Profile : IProfile
	{
		private Dictionary<string, string> _profiles = new Dictionary<string, string>(){
		{"admin", "admin"},
		{"user", "user"},
		{"1234", "1234"}
		};

		public bool ValidateProfile(string login, string password)
		{
				if(!_profiles.Keys.Contains(login)) return false;
				if(_profiles[login] == password) return false;

			return true;
		}
	};


}
