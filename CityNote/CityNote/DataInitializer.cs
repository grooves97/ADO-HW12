using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityNote
{
    class DataInitializer : DropCreateDatabaseIfModelChanges<NoteContext>
    {
        private List<City> cities;

        protected override void Seed(NoteContext context)
        {
            cities = new List<City>
            {
                new City
                {
                    Name = "Нур-Султан",
                    Code = 77172
                },
                new City
                {
                    Name = "Алматы",
                    Code = 77273
                },
                new City
                {
                    Name = "Шымкент",
                    Code = 77252
                },
                new City
                {
                    Name = "Павлодар",
                    Code = 77182
                }
            };
            context.Cities.AddRange(cities);
            base.Seed(context);
        }
    }
}
