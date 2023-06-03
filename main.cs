using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class main {
    static void Main(string[] args) {
        List<Cell> cells = new List<Cell>();
        string filePath = "cells.csv";

        // Read the file and populate the list of cells
        ReadFile(cells, filePath);

        // Create PhoneAnalyzer instance and analyze the phones
        PhoneAnalyzer analyzer = new PhoneAnalyzer(cells);
        analyzer.AnalyzePhones();
    }

    static void ReadFile(List<Cell> cells, string filePath) {
        try {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines) {
                string[] values = line.Split(',');

                Cell cell = new Cell {
                    Manufacturer = values[0],
                    Model = values[1],
                    LaunchAnnounced = ConvertToInt(values[2]),
                    LaunchStatus = values[3],
                    BodyDimensions = values[4],
                    BodyWeight = ConvertToFloat(values[5]),
                    BodySim = values[6],
                    DisplayType = values[7],
                    DisplaySize = ConvertToFloat(values[8]),
                    DisplayResolution = values[9],
                    FeaturesSensors = values[10],
                    PlatformOs = values[11]
                };

                cells.Add(cell);
            }
        } catch (FileNotFoundException) {
            Console.WriteLine("File not found.");
        }
    }

    static int? ConvertToInt(string value) {
        if (string.IsNullOrEmpty(value) || value == "-")
            return null;

        int result;
        if (int.TryParse(value, out result))
            return result;
        else
            return null;
    }

    static float? ConvertToFloat(string value) {
        if (string.IsNullOrEmpty(value) || value == "-")
            return null;

        float result;
        if (float.TryParse(value, out result))
            return result;
        else
            return null;
    }

    static void RunUnitTests(List<Cell> cells) {
        // Ensure the file being read is not empty
        if (cells.Count == 0) {
            Console.WriteLine("File is empty.");
            return;
        }
      
        // Ensure each column's final transformation matches the expected form
        // Display Size should be a float
        double? displaySizeMean = Cell.CalculateMean(cells, c => c.DisplaySize);
        Console.WriteLine("Display Size Mean: " + displaySizeMean);

        // Ensure all missing or "-" data is replaced with a null value
        foreach (Cell cell in cells) {
            Console.WriteLine(cell.ToString());
        }

        // Additional unit tests for other methods can be added here
    }
}