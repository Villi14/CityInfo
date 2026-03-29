namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()  {
                            Id = 3,
                            Name = "Cathedral of Our Lady",
                            Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans."
                        },

                        new PointOfInterestDto()  {
                            Id = 4,
                            Name = "Antwerp Central Station",
                            Description = "The the finest example of railway architecture in Belgium."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Tokyo",
                    Description = "The one with the busiest crosswalk.",
                     PointsOfInterest = new List<PointOfInterestDto>() {
                        new PointOfInterestDto()  {
                            Id = 5,
                            Name = "Shibuya Crossing",
                            Description = "The busiest pedestrian crossing in the world."
                        },
                        new PointOfInterestDto()  {
                            Id = 6,
                            Name = "Meiji Shrine",
                            Description = "A Shinto shrine dedicated to the deified spirits of Emperor Meiji and his consort, Empress Shōken."
                        }
                     }
                },
                new CityDto()
                {
                    Id = 4,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                        PointsOfInterest = new List<PointOfInterestDto>() {
                            new PointOfInterestDto()  {
                                Id = 7,
                                Name = "Eiffel Tower",
                                Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel."
                            },
                            new PointOfInterestDto()  {
                                Id = 8,
                                Name = "The Louvre",
                                Description = "The world's largest museum."
                            }
                        }
                }
            };
        }
    }
}
