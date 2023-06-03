// using System;
// using System.Collections.Generic;
// using System.Linq;

// class PhoneAnalyzer {
//     private List<Cell> cells;

//     public PhoneAnalyzer(List<Cell> cells) {
//         this.cells = cells;
//     }

//     public void AnalyzePhones() {
//         // What company (oem) has the highest average weight of the phone body?
//         string highestWeightManufacturer = GetCompanyWithHighestAverageWeight();
//         Console.WriteLine("Company with highest average weight: " + highestWeightManufacturer);

//         // Was there any phones that were announced in one year and released in another? What are they? Give me the oem and models.
//         List<Cell> phonesWithDifferentAnnouncementAndReleaseYears = GetPhonesWithDifferentAnnouncementAndReleaseYears();
//         Console.WriteLine("Phones with different announcement and release years:");
//         foreach (Cell phone in phonesWithDifferentAnnouncementAndReleaseYears) {
//             Console.WriteLine($"OEM: {phone.Manufacturer}, Model: {phone.Model}");
//         }

//         // How many phones have only one feature sensor?
//         int countPhonesWithOneFeatureSensor = GetCountPhonesWithOneFeatureSensor();
//         Console.WriteLine("Phones with one feature sensor: " + countPhonesWithOneFeatureSensor);

//         // What year had the most phones launched in the 2000s?
//         int yearWithMostPhonesIn2000s = GetYearWithMostPhonesIn2000s();
//         Console.WriteLine("Year with the most phones launched in the 2000s: " + yearWithMostPhonesIn2000s);
//     }

//     private string? GetCompanyWithHighestAverageWeight() {
//         var averageWeights = cells
//             .GroupBy(c => c.Manufacturer)
//             .Select(g => new {
//                 Manufacturer = g.Key,
//                 AverageWeight = Cell.CalculateMean(g.ToList(), c => c.BodyWeight)
//             })
//             .ToList();

//         return averageWeights.OrderByDescending(a => a.AverageWeight).FirstOrDefault()?.Manufacturer;
//     }

//     private List<Cell> GetPhonesWithDifferentAnnouncementAndReleaseYears() {
//         return cells.Where(c => c.LaunchAnnounced.HasValue && c.LaunchAnnounced != GetReleaseYear(c)).ToList();
//     }

//     private int? GetReleaseYear(Cell cell) {
//         if (cell.LaunchStatus == "Released" && !string.IsNullOrEmpty(cell.Model)) {
//             string[] parts = cell.Model.Split(' ');
//             if (parts.Length > 0 && int.TryParse(parts[0], out int year)) {
//                 return year;
//             }
//         }
//         return null;
//     }

//     private int GetCountPhonesWithOneFeatureSensor() {
//         return cells.Count(c => !string.IsNullOrEmpty(c.FeaturesSensors) && c.FeaturesSensors.Split(';').Length == 1);
//     }

//     private int GetYearWithMostPhonesIn2000s() {
//         var phonesByYear = cells
//             .Where(c => c.LaunchAnnounced.HasValue && c.LaunchAnnounced >= 2000 && c.LaunchAnnounced <= 2009)
//             .GroupBy(c => c.LaunchAnnounced.Value)
//             .Select(g => new {
//                 Year = g.Key,
//                 Count = g.Count()
//             })
//             .ToList();

//         return phonesByYear.OrderByDescending(p => p.Count).FirstOrDefault()?.Year ?? 0;
//     }
// }