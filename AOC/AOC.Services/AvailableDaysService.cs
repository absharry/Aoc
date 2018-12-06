using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using AOC.Domain.Models;
using Newtonsoft.Json;
using System.Linq;

namespace AOC.Services
{
    public class AvailableDaysService : IAvailableDaysService
    {
        private List<AvailableYear> AvailableYears { get; set; }

        public AvailableDaysService()
        {


            //var assembly = Assembly.GetExecutingAssembly();
            //Stream stream = assembly.GetManifestResourceStream("AvailableDays.json");

            //string text = string.Empty;
            //using (var reader = new System.IO.StreamReader(stream))
            //{
            //    text = reader.ReadToEnd();
            //}

            //this.AvailableYears = JsonConvert.DeserializeObject<AvailableYears>(text).Years;
        }

        public int GetAvailableYears()
        {
            return this.processedInputs.Min(x => x.Length);
        }


    }
}
