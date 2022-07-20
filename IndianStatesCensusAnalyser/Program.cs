using System;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace IndianStatesCensusAnalyser
{
    class Program
    {
        // CSV Firl Paths 
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";

        static string indianStateCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaStateCensusData.csv";


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Indian State Census Analyser Problem ");

            IndianCensusAdapter indianCensusAdapter = new IndianCensusAdapter();

            // Loading the Census Data File
            indianCensusAdapter.LoadCensusData(indianStateCensusFilePath, indianStateCensusHeaders);
        }
    }
}
