using System;
using System.Collections.Generic;
using System.Linq;

class Cell {
    public string? Manufacturer { get; set; }
    public string? Model { get; set; }
    public int? LaunchAnnounced { get; set; }
    public string? LaunchStatus { get; set; }
    public string? BodyDimensions { get; set; }
    public float? BodyWeight { get; set; }
    public string? BodySim { get; set; }
    public string? DisplayType { get; set; }
    public float? DisplaySize { get; set; }
    public string? DisplayResolution { get; set; }
    public string? FeaturesSensors { get; set; }
    public string? PlatformOs { get; set; }

    public override string ToString() {
        return $"Manufacturer: {Manufacturer}\n" +
               $"Model: {Model}\n" +
               $"Launch Announced: {LaunchAnnounced}\n" +
               $"Launch Status: {LaunchStatus}\n" +
               $"Body Dimensions: {BodyDimensions}\n" +
               $"Body Weight: {BodyWeight}\n" +
               $"Body Sim: {BodySim}\n" +
               $"Display Type: {DisplayType}\n" +
               $"Display Size: {DisplaySize}\n" +
               $"Display Resolution: {DisplayResolution}\n" +
               $"Features Sensors: {FeaturesSensors}\n" +
               $"Platform OS: {PlatformOs}\n";
    }

    public static double? CalculateMean(List<Cell> cells, Func<Cell, double?> selector) {
        List<double?> values = cells.Select(selector).ToList();
        if (values.All(x => x != null))
            return values.Average();
        else
            return null;
    }

    public static double? CalculateMedian(List<Cell> cells, Func<Cell, double?> selector) {
        List<double?> values = cells.Select(selector).ToList();
        if (values.All(x => x != null)) {
            values.Sort();
            int count = values.Count;
            if (count % 2 == 0)
                return (values[count / 2 - 1] + values[count / 2]) / 2;
            else
                return values[count / 2];
        } else {
            return null;
        }
    }

    public static double? CalculateStandardDeviation(List<Cell> cells, Func<Cell, double?> selector) {
        List<double?> values = cells.Select(selector).ToList();
        if (values.All(x => x != null)) {
            double mean = values.Average() ?? 0;
            double sumOfSquares = values.Sum(x => Math.Pow((x ?? 0) - mean, 2));
            double variance = sumOfSquares / values.Count;
            return Math.Sqrt(variance);
        } else {
            return null;
        }
    }

    public static List<string> GetUniqueValues(List<Cell> cells, Func<Cell, string> selector) {
        return cells.Select(selector).Distinct().ToList();
    }

    public static void AddCell(List<Cell> cells, Cell cell) {
        cells.Add(cell);
    }

    public static void DeleteCell(List<Cell> cells, Cell cell) {
        cells.Remove(cell);
    }
}
