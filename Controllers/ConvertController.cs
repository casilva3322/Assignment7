using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter7.Models;

namespace UnitConverter7.Controllers
{
    public class ConvertController: Controller 
    {
          public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DoConvert()  //test https://localhost:5001/Convert/DoConvert/
        {
          return View();
        }
        [HttpPost]
        public IActionResult ShowConvert(ConvertViewModels item)
        {
            
            switch(item.ConvertType)
            {   
                case "CelsiusToFahrenheit": //temperature conversions
                  item.ConvertVal = Math.Round(((item.ValToConvert * 1.8m) + 32.0m),2);
                  item.ConvertType = "Celsius To Fahrenheit";
                  break;
              
                case "CelsiusToKelvin":
                  item.ConvertVal = Math.Round((item.ValToConvert + 273.15m),2);
                  item.ConvertType = "Celcius To Kelvin";
                  break;
            
                case "FahrenheitToCelsius":
                  item.ConvertVal = Math.Round(((item.ValToConvert - 32.0m) / 1.8m),2);
                  item.ConvertType = "Fahrenheit To Celcius";
                  break;
               
                case "FahrenheitToKelvin": 
                  item.ConvertVal= Math.Round(((item.ValToConvert + 459.67m) * (5.0m / 9.0m)),2);
                  item.ConvertType = "Fahrenheit To Kelvin";
                  break;
             
                case "KelvinToCelsius":
                   item.ConvertVal = Math.Round((item.ValToConvert - 273.15m),2);
                   item.ConvertType = "Kelvin To Celcius";
                   break;
                  
                case "KelvinToFahrenheit":
                  item.ConvertVal = Math.Round(((item.ValToConvert * 1.8m) -459.67m),2);
                  item.ConvertType = "Kelvin To Fahrenheit";
                  break;
               
                case "MetersToFeet"://length conversions
                  item.ConvertVal = Math.Round((item.ValToConvert / 0.3048m),2);
                  item.ConvertType = "Meters To Feet";
                  break;
              
                case "MetersToYards":
                  item.ConvertVal = Math.Round((item.ValToConvert * 1.0936m),2);
                  item.ConvertType = "Meters To Yards";
                  break;
           
                case "FeetToMeters":
                  item.ConvertVal = Math.Round((item.ValToConvert * 0.3048m),2);
                  item.ConvertType = "Feet To Meters";
                  break;
              
                case "FeetToYards":
                  item.ConvertVal = Math.Round((item.ValToConvert * 0.3333m),2);
                  item.ConvertType = "Feet To Yards";
                  break;
            
                case "YardsToMeters":
                  item.ConvertVal = Math.Round((item.ValToConvert / 1.0936m),2);
                  item.ConvertType = "Yards To Meters";
                  break;
           
                case "YardsToFeet":
                  item.ConvertVal = Math.Round((item.ValToConvert * 3.0m),2);
                  item.ConvertType = "Yards to Feet";
                  break;
                //mass conversions
                case "OuncesToGrams":
                  item.ConvertVal = Math.Round((item.ValToConvert / 0.035274m),2);
                  item.ConvertType = "Ounces To Grams";
                  break;
          
                case "OuncesToPounds":
                  item.ConvertVal = Math.Round((item.ValToConvert * 0.0625m),2);
                  item.ConvertType = "Ounces To Pounds";
                  break;
                  
                case "OuncesToKilograms":
                  item.ConvertVal = Math.Round((item.ValToConvert / 35.274m),2);
                  item.ConvertType = "Ounces To Kilograms";
                  break;
              
                case "PoundsToOunces":
                  item.ConvertVal = Math.Round((item.ValToConvert * 16.00m),2);
                  item.ConvertType = "Pounds To Ounces";
                  break;
             
                case "PoundsToGrams":
                  item.ConvertVal = Math.Round((item.ValToConvert / 0.0022046m),2);
                  item.ConvertType = "Pounds To Grams";
                  break;

                case "PoundsToKilograms":
                  item.ConvertVal = Math.Round((item.ValToConvert / 2.2046m),2);
                  item.ConvertType = "Pounds To Kilograms";
                  break;
            
                case "GramsToOunces":
                  item.ConvertVal = Math.Round((item.ValToConvert / 28.3495m),2);
                  item.ConvertType = "Grams To Ounces";
                  break;
             
                case "GramsToPounds":
                  item.ConvertVal = Math.Round((item.ValToConvert / 453.59237m),2);
                  item.ConvertType = "Grams To Pounds";
                  break;
             
                case "GramsToKilograms":
                  item.ConvertVal = Math.Round((item.ValToConvert / 1000.0m),2);
                  item.ConvertType = "Grams To Kilograms";
                  break;
             
                case "KilogramsToOunces":
                  item.ConvertVal = Math.Round((item.ValToConvert / 0.02834952m),2);
                  item.ConvertType = "Kilograms To Ounces";
                  break;

                case "KilogramsToPounds":
                  item.ConvertVal = Math.Round((item.ValToConvert / 0.45359237m),2);
                  item.ConvertType = "Kilograms To Pounds";
                  break;
                case "KilogramsToGrams":
                  item.ConvertVal = Math.Round((item.ValToConvert * 1000.0m),2);
                  item.ConvertType = "Kilograms To Grams";
                  break;
                default:
                  Console.WriteLine("There has been an error");
                  break;
                }  
              return View(item);     
        }
    }
}