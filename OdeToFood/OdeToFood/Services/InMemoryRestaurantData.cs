﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> _restaurants;

        public InMemoryRestaurantData() {

            _restaurants = new List<Restaurant> {

                new Restaurant{
                    Id = 1,
                    Name = "MyGuuuchi Alpha"
                },
                new Restaurant{
                    Id = 2,
                    Name = "MyGuuuchi Boochi"
                },
                new Restaurant{
                    Id = 3,
                    Name = "MyGuuuchi Hoochi"
                },
                new Restaurant{
                    Id = 4,
                    Name = "MySmoocchi Guuuchi"
                }

            };

        }

        //List an be turned into IEnumerable
        public IEnumerable<Restaurant> GetAll() {

            return _restaurants.OrderBy(r => r.Name);

        }

        public Restaurant Get(int id) {

            return _restaurants.FirstOrDefault(r => r.Id == id);

        }

        public Restaurant Add(Restaurant restaurant) {

            restaurant.Id = _restaurants.Max(r => r.Id) + 1;

            _restaurants.Add(restaurant);

            return restaurant;

        }

        public Restaurant Update(Restaurant restaurant) {
            throw new NotImplementedException();
        }
    }
}
