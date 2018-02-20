using five.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace five.Services
{
    public static class OrderDataService
    {
        private static IEnumerable<Order> AllOrders()
        {            
            var data = new ObservableCollection<Order>
            {
                new Order
                {
                    Datum = new DateTime(2017, 05, 24),
                    Kategorie = Kategorie.Bremsbelag,
                    Detail = "V-Brake",
                    Referent = Referent.Jr,
                    Menge = 2,
                    Einzelpreis = 2,
                    Gesamtpreis = 4
                },
                new Order
                {
                    Datum = new DateTime(2017, 05, 24),
                    Kategorie = Kategorie.Reifen,
                    Detail = "Schwalbe Roadcruiser",
                    Referent = Referent.Jc,
                    Menge = 1,
                    Einzelpreis = 10,
                    Gesamtpreis = 10
                },                
            };
            return data;
        }

        public static ObservableCollection<Order> GetOrderData()
        {
            return new ObservableCollection<Order>(AllOrders());
        }
    }
}
