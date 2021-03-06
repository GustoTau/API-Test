using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharpFramework.Objects;
using TechTalk.SpecFlow;

namespace RestSharpFramework.Helpers
{
    
    public static class Data
    {

        public static string DogAPIRandomSearchURL => ConfigurationManager.AppSettings["DogAPIRandomSearchURL"];
        public static string DogAPIBreedListURL => ConfigurationManager.AppSettings["DogAPIBreedListURL"];
        public static string DogAPIBulldogSearch => ConfigurationManager.AppSettings["DogAPIBulldogSearch"];
        public static string PetAPIAvailableSearch => ConfigurationManager.AppSettings["PetAPIAvailableSearch"];
        public static string PetAPIAddPetURL => ConfigurationManager.AppSettings["PetAPIURL"];


        private static Random random = new Random();
        public static string AutoGeneratedName(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
