namespace TravelAgency.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Data;
    using Model;

    public class CreateSampleExcursions
    {
        private Random rand = new Random();

        private readonly string[] Names = new string[]{"Visit ", "Relax in ", "Enjoy ", "Be happy in "};

        public void AddFirstTenExcursions()
        {
            using (var travelAgency = new TravelAgencyDbContext())
            {
                var excursions = GetExcursions();

                foreach (var item in excursions)
                {
                    travelAgency.Excursions.Add(item);
                }

                travelAgency.SaveChanges();
            }
        }

        public void AddRandomNumberOfExcursion(int number)
        {
            var travelAgency = new TravelAgencyDbContext();

            var allDestinations = travelAgency.Destinations
                .Select(d => new
                {
                    ID = d.DestinationId,
                    Name = d.Country
                })
                .ToList();

            var allTransportIds = travelAgency.Transports
                .Select(d => d.TransportId)
                .ToList();

            var allGuideId = travelAgency.Guides
                .Select(d => d.GuideId)
                .ToList();

            for (int i = 0; i < number; i++)
            {
                if (i % 100 == 0)
                {
                    travelAgency.SaveChanges();
                    travelAgency.Dispose();
                    travelAgency = new TravelAgencyDbContext();
                }

                var startDate = new DateTime(2015, rand.Next(1, 13), rand.Next(1, 29));
                var endDate = startDate.AddDays(rand.Next(5, 15));
                var currentCountryObj = allDestinations[rand.Next(0, allDestinations.Count - 1)];

                var exursion = new Excursion
                {
                    Name = Names[rand.Next(0, Names.Length)] + currentCountryObj.Name,
                    StartDate = startDate,
                    EndDate = endDate,
                    DestinationId = currentCountryObj.ID,
                    Clients = rand.Next(0, 150),
                    PricePerClient = (decimal)rand.Next(500, 10000),
                    TransportId = allTransportIds[rand.Next(0, allTransportIds.Count-1)],
                    GuideId = allGuideId[rand.Next(0, allGuideId.Count-1)]
                };

                travelAgency.Excursions.Add(exursion);
            }

            travelAgency.SaveChanges();
            travelAgency.Dispose();
        }

        private List<Excursion> GetExcursions()
        {
            List<Excursion> list = new List<Excursion>()
                {
                new Excursion
                {
                    Name = "Sea Holiday",
                    StartDate = new DateTime(2015,08,10),
                    EndDate = new DateTime(2015,08,20),
                    DestinationId = 6,
                    Clients = 50,
                    PricePerClient = 895M,
                    TransportId = 9,
                    GuideId = 1
                },
                new Excursion
                {
                    Name = "Visit Monaco",
                    StartDate = new DateTime(2015,08,20),
                    EndDate = new DateTime(2015,08,24),
                    DestinationId = 1,
                    Clients = 15,
                    PricePerClient = 4500M,
                    TransportId = 1,
                    GuideId = 2
                },
                new Excursion
                {
                    Name = "Find the love in Paris",
                    StartDate = new DateTime(2015,08,15),
                    EndDate = new DateTime(2015,08,23),
                    DestinationId = 2,
                    Clients = 27,
                    PricePerClient = 1555M,
                    TransportId = 1,
                    GuideId = 4
                },
                new Excursion
                {
                    Name = "Surf in the Atlantic ocean",
                    StartDate = new DateTime(2015,08,21),
                    EndDate = new DateTime(2015,08,27),
                    DestinationId = 3,
                    Clients = 32,
                    PricePerClient = 2220M,
                    TransportId = 4,
                    GuideId = 1
                },
                new Excursion
                {
                    Name = "Sea Holiday",
                    StartDate = new DateTime(2015,09,01),
                    EndDate = new DateTime(2015,09,08),
                    DestinationId = 6,
                    Clients = 45,
                    PricePerClient = 875.5M,
                    TransportId = 9,
                    GuideId = 5
                },
                new Excursion
                {
                    Name = "Visit the Pyramids",
                    StartDate = new DateTime(2015,09,05),
                    EndDate = new DateTime(2015,09,13),
                    DestinationId = 5,
                    Clients = 75,
                    PricePerClient = 650M,
                    TransportId = 2,
                    GuideId = 8
                },
                new Excursion
                {
                    Name = "All Inclusive drinking",
                    StartDate = new DateTime(2015,09,11),
                    EndDate = new DateTime(2015,09,20),
                    DestinationId = 4,
                    Clients = 105,
                    PricePerClient = 777M,
                    TransportId = 25,
                    GuideId = 2
                },
                new Excursion
                {
                    Name = "Visit cote d'azur",
                    StartDate = new DateTime(2015,09,20),
                    EndDate = new DateTime(2015,09,27),
                    DestinationId = 2,
                    Clients = 66,
                    PricePerClient = 1200M,
                    TransportId = 26,
                    GuideId = 4
                },
                new Excursion
                {
                    Name = "Visit all Italian ports",
                    StartDate = new DateTime(2015,09,14),
                    EndDate = new DateTime(2015,09,24),
                    DestinationId = 7,
                    Clients = 150,
                    PricePerClient = 1050M,
                    TransportId = 15,
                    GuideId = 7
                },
                new Excursion
                {
                    Name = "Visit Lisbon",
                    StartDate = new DateTime(2015,09,23),
                    EndDate = new DateTime(2015,09,30),
                    DestinationId = 3,
                    Clients = 84,
                    PricePerClient = 1989M,
                    TransportId = 4,
                    GuideId = 1
                },
            };
            return list;
        }
    }
}
