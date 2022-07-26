﻿using System;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace IndianStatesCensusAnalyser
{
    class Program
    {
        // CSV Firl Paths 
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";

        static string indianStateCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaData.csv";
        static string wrongIndianStateCensusFileType = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndianStateCensus.txt";
        static string delimiterIndianCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndianStateCesusDelimeter.csv";
        static string wrongHeaderIndianCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\WrongIndiaStateCensusData.csv";
        
        static string indianStateCodeFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaStateCodes.csv";
        static string wrongIndianStateCodeFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\StateCodeData.csv";
        static string wrongIndianStateCodeFileType = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\IndiaStateCodes.txt";
        static string delimiterIndianStateCodeFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\DelimiterIndiaStateCodes.csv";
        static string wrongHeaderStateCodeFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\WrongHeaderIndiaStateCodes.csv";


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

            //2.1
            // Loading the State census Data File
            indianCensusAdapter.LoadCensusData(indianStateCodeFilePath, indianStateCodeHeaders);

            //2.2
            indianCensusAdapter.LoadCensusData(wrongIndianStateCodeFilePath, indianStateCodeHeaders);

            //2.3
            indianCensusAdapter.LoadCensusData(wrongIndianStateCodeFileType, indianStateCodeHeaders);

            //2.4
            indianCensusAdapter.LoadCensusData(delimiterIndianStateCodeFilePath, indianStateCodeHeaders);

            //2.5
            indianCensusAdapter.LoadCensusData(wrongHeaderStateCodeFilePath, indianStateCodeHeaders);

        }
    }
}
