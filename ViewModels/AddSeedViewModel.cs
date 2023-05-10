using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tracker.Models;


namespace Tracker.ViewModels
{
    public class AddSeedViewModel
    {
        public int SeedId { get; set; }
        public int BedId { get; set; }
        //[Required(ErrorMessage = "Name is required ")]
        public string? Name { get; set; }
        public Bed? Bed { get; set; }

        //[Required(ErrorMessage = "Water Date is required ")]
        public DateTime DatePlanted { get; set; }

        //[Required(ErrorMessage = "Hardiness zone is required ")]
        public string? HardinessZone { get; set; }

        //[Required(ErrorMessage = "Water schedule is required ")]
        public string? WaterSchedule { get; set; }

        public List<SelectListItem>? Seeds { get; set; }


        public string? UserId { get; set; }

        public AddSeedViewModel(Bed theBed, List<Seed> possibleSeeds)
        {
            Seeds = new List<SelectListItem>();
            foreach (var seed in possibleSeeds)
            {
                Seeds.Add(new SelectListItem
                {
                    Value = seed.Id.ToString(),
                    Text = seed.Name,
                });
            }
            //why do we need this?
            Bed = theBed;
        }

        public AddSeedViewModel()
        {
        }

        
    }
}