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
        static string wrongIndianStateCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaData.csv";
        static string wrongIndianStateCensusFileType = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndianStateCensus.txt";
        static string delimiterIndianCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndianStateCesusDelimeter.csv";
        static string wrongHeaderIndianCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\WrongIndiaStateCensusData.csv";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Indian State Census Analyser Problem ");

            IndianCensusAdapter indianCensusAdapter = new IndianCensusAdapter();

            // Loading the Census Data File
            indianCensusAdapter.LoadCensusData(indianStateCensusFilePath, indianStateCensusHeaders);

            //1.2
            indianCensusAdapter.LoadCensusData(wrongIndianStateCensusFilePath, indianStateCensusHeaders);

            //1.3
            indianCensusAdapter.LoadCensusData(wrongIndianStateCensusFileType, indianStateCensusHeaders);

            //1.4
            indianCensusAdapter.LoadCensusData(delimiterIndianCensusFilePath, indianStateCensusHeaders);

            //1.5
            indianCensusAdapter.LoadCensusData(wrongHeaderIndianCensusFilePath, indianStateCensusHeaders);
        }
    }
}
