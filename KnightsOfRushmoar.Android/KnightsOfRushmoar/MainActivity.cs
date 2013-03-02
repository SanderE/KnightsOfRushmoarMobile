using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace KnightsOfRushmoar
{
	[Activity (Label = "KnightsOfRushmoar", MainLauncher = true)]
	public class Activity1 : Activity
	{
		private DataRepository dataRepos;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			this.RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
			this.RequestWindowFeature (WindowFeatures.NoTitle);

			dataRepos = new DataRepository ();
			new System.Threading.Thread(delegate() {
				dataRepos.InitMemberList ();
				dataRepos.InitTournamentList ();}).Start();

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button showPlayers = FindViewById<Button> (Resource.Id.showPlayersButton);
			Button showTournaments = FindViewById<Button> (Resource.Id.showTournamentsButton);
			
			showPlayers.Click += ShowPlayersClick;
			showTournaments.Click += ShowTournamentsClick;
		}

		void ShowTournamentsClick (object sender, EventArgs e)
		{
			TextView displayView = FindViewById<TextView> (Resource.Id.displayTextView);
			
			String textToDisplay = "Upcoming Tournaments:\n\n";
			foreach(Tournament tournament in dataRepos.Tournaments)
			{
				textToDisplay += tournament.Name +"\n";
			}
			
			displayView.Text = textToDisplay;
		}

		void ShowPlayersClick (object sender, EventArgs e)
		{
			TextView displayView = FindViewById<TextView> (Resource.Id.displayTextView);

			String textToDisplay = "Knights of Rushmoar Members:\n\n";
			foreach(Member member in dataRepos.KorMembers)
			{
				textToDisplay += member.Name +", Aka "+member.Alias+"\n";
			}

			displayView.Text = textToDisplay;
		}


	}
}


