
using ConsoleApp.Models.Entities;
using ConsoleApp.Services;

var addressService = new AddressService();
var result = await addressService.GetAsync(1);


Console.WriteLine($"{result.StreetName},{result.PostalCode},{result.City}");

Console.ReadKey();