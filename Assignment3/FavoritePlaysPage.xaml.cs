using System;
using System.Collections.Generic;
using Assignment3.Models;

using Xamarin.Forms;

namespace Assignment3
{
    public partial class FavoritePlaysPage : ContentPage
    {
        public List<Play> GiannisPlays { get; set; } 

        // Initializes the Favorite Plays page with a list of my favorite Giannis plays.
        public FavoritePlaysPage()
        {
            GiannisPlays = new List<Play>
            {
                new Play
                {
                    Name = "Euro-Step",
                    Description = "Giannis' signature play. The high-speed Euro-Step, where he expertly dodges any defender.",
                    Url = "https://cdn.vox-cdn.com/thumbor/5KPlknPX-i8gSp3hcFvECrpiFKE=/1400x1050/filters:format(png)/cdn.vox-cdn.com/uploads/chorus_asset/file/10729197/eurostep_social.png"
                },
                new Play
                {
                    Name = "One-Handed Dunk",
                    Description = "The Greek Freak only needs one hand to embarrass your favorite player.",
                    Url = "https://media.newyorker.com/photos/5a7c6754f5535f085792ff9e/master/pass/Cunningham-Giannis-Porzingis-Two-Dunks-at-the-Garden.jpg"
                },
                new Play
                {
                    Name = "Chasedown Block",
                    Description = "Running the whole length of the court and sending the offensive player's shot into the 3rd row!",
                    Url = "https://www.si.com/.image/ar_1:1%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:good%2Cw_1200/MTgyNDQ1NDgwNjMyOTE5MTcx/giannis-deandre-ayton-suns-bucks.jpg"
                },
                new Play
                {
                    Name = "Pull-up Jumpshot",
                    Description = "The newest addition to Giannis' skillset. If he masters this shot then he'll be even more unstoppable!",
                    Url = "https://cdn.vox-cdn.com/thumbor/sNV2ElRjH0pLM1j-Z7yryyuOdAE=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/22926536/usa_today_16949592.jpg"
                }

            };

            InitializeComponent();

            GiannisList.ItemsSource = GiannisPlays;
        }
    }
}
