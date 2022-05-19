using System;
using System.Collections.Generic;
using Assignment3.Models;

using Xamarin.Forms;

namespace Assignment3
{
    public partial class GalleryPage : ContentPage
    {
        public List<GalleryImage> GiannisGallery { get; set; }

        // Initializes the Gallery Page with a list of Giannis Images.
        public GalleryPage()
        {
            GiannisGallery = new List<GalleryImage>
            {
                new GalleryImage
                {
                    Name = "Giannis Mean-Mug",
                    ImageUrl = "https://onmilwaukee.com/images/articles/bu/bucks-celtics-game-4-playoffs-images/bucks-celtics-game-4-playoffs-images_fullsize_story1.jpg"
                },
                new GalleryImage
                {
                    Name = "Giannis When the bucks won the 2021 NBA championship",
                    ImageUrl = "https://e0.365dm.com/21/07/2048x1152/skysports-nba-milwaukee-bucks_5453772.jpg"
                },
                new GalleryImage
                {
                    Name = "Giannis pulling a prank on a rookie",
                    ImageUrl = "https://i.ytimg.com/vi/ShalZ7QfWQA/maxresdefault.jpg"
                },
                new GalleryImage
                {
                    Name = "Giannis was named GQ's athlete of the year",
                    ImageUrl = "https://pbs.twimg.com/media/FEUwtMAWUAAIz3L?format=jpg&name=small"
                }

            };

            InitializeComponent();

            GalleryList.ItemsSource = GiannisGallery;
        }
    }
}
