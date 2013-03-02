
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KnightsOfRushmoar
{
	public class DataRepository
	{
		private List<Member> _korMembers;
		public List<Member> KorMembers { get { return _korMembers; } }
		private List<Tournament> _tournaments;
		public List<Tournament> Tournaments { get { return _tournaments; } }

		public void InitMemberList()
		{
			if (_korMembers == null) {
				_korMembers = new List<Member> ();
				_korMembers.Add (new Member () { Id=1, Name="Sander Egberink", Description="#1 Zerg in KoR", Alias="Abradix" });
				_korMembers.Add (new Member () { Id=2, Name="Ruud van der Linden", Description="4gater", Alias="p34nuts" });
				_korMembers.Add (new Member () { Id=3, Name="Bas Jacobz", Description="CANNON RUSH", Alias="Empire" });
				_korMembers.Add (new Member () { Id=4, Name="Cyriel van t End", Description="Unicorn", Alias="Mindcrash" });
				_korMembers.Add (new Member () { Id=5, Name="Tim de Groot", Description="#1 Designer in KoR", Alias="TIMMMEH" });
			}
		}

		public void InitTournamentList()
		{
			if (_tournaments == null) {
				_tournaments = new List<Tournament> ();
				_tournaments.Add (new Tournament () { Name = "Knights of Rushmoar HotS Invitational" });
			}
		}
	}
}

