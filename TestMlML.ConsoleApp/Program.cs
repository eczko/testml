// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using TestMlML.Model;

namespace TestMlML.ConsoleApp
{
    class Program
    {
        //Dataset to use for predictions 
        private const string DATA_FILEPATH = @"C:\Users\rfran\AppData\Local\Temp\0652595d-d44b-4ec0-b4e2-ad8e3a892fd9.tsv";

        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            //ModelInput sampleData = CreateSingleDataSample(DATA_FILEPATH);

            ModelBuilder.CreateModel();

                        // Make a single prediction on the sample data and print results
            //            ModelOutput predictionResult = ConsumeModel.Predict(sampleData);

            //Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");
            //Console.WriteLine($"id: {sampleData.Id}");
            //Console.WriteLine($"x_pos: {sampleData.X_pos}");
            //Console.WriteLine($"y_pos: {sampleData.Y_pos}");
            //Console.WriteLine($"\n\nActual Label: {sampleData.Label} \nPredicted Label value {predictionResult.Prediction} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            //Console.WriteLine("=============== End of process, hit any key to finish ===============");
            //Console.ReadKey();
        }

        // Change this code to create your own sample data
        #region CreateSingleDataSample
        // Method to load single row of dataset to try a single prediction
        private static ModelInput CreateSingleDataSample(string dataFilePath)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            // Load dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: dataFilePath,
                                            hasHeader: true,
                                            separatorChar: '\t',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Use first line of dataset as model input
            // You can replace this with new test data (hardcoded or from end-user application)
            ModelInput sampleForPrediction = mlContext.Data.CreateEnumerable<ModelInput>(dataView, false)
                                                                        .First();
            return sampleForPrediction;
        }
        #endregion
    }
}
