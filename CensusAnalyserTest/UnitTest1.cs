using NUnit.Framework;
using IndianStatesCensusAnalyser;
using IndianStatesCensusAnalyser.POCO;
using Newtonsoft.Json;
using System.Collections.Generic;
using static IndianStatesCensusAnalyser.CensusAnalyser;

namespace CensusAnalyserTest
{
    public class Tests
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        static string indianStateCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaStateCensusData.csv";
        static string wrongHeaderIndianCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\WrongIndiaStateCensusData.csv";
        static string delimiterIndianCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndianStateCesusDelimeter.csv";
        static string wrongIndianStateCensusFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaData.csv";
        static string wrongIndianStateCensusFileType = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndianStateCensus.txt";
        static string indianStateCodeFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaStateCodes.csv";
        static string wrongIndianStateCodeFileType = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\IndiaStateCodes.txt";
        static string delimiterIndianStateCodeFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\DelimiterIndiaStateCodes.csv";
        static string wrongHeaderStateCodeFilePath = @"E:\BridgeLabz2\PraticeProblem\Day29-Indian-State-Census-Analyser\CensusAnalyserTest\CSVFiles\WrongHeaderIndiaStateCodes.csv";

        IndianStatesCensusAnalyser.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new IndianStatesCensusAnalyser.CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

   
        //TC 1.1
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(5, totalRecord.Count);
        }

    }
}