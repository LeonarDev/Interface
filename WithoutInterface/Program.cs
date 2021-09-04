﻿using System;
using System.Globalization;
using WithoutInterface.Entities;
using WithoutInterface.Services;

namespace WithoutInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();

            Vehicle vehicle = new Vehicle(carModel);

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finishtDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(startDate, finishtDate, vehicle);

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.Write(carRental.Invoice);
        }
    }
}