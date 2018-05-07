﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skywolf.MarketDataGrabber;
using Skywolf.DatabaseRepository;
using HtmlAgilityPack;
using ServiceStack.Text;
using Skywolf.Utility;
using System.Data;
using Skywolf.Contracts.DataContracts.MarketData;

namespace MarketDataGrabberTest
{
    class Program
    {
        static void Main(string[] args)
        {
            testAVBatchQuote();
 
        }

        static void testHttpGet()
        {
            BaseMarketDataGrabber marketData = new AVMarketDataGrabber();
            string result = marketData.HttpGet("https://www.alphavantage.co/query?function=DIGITAL_CURRENCY_WEEKLY&symbol=BTC&market=CNY&apikey=apikey=GCN17TO8N1K4JU9G&datatype=csv");
            DataTable dt = TextUtility.ConvertCSVToTable(result, "prices");

            Console.Write(dt);
        }

        static void testHtmlGet()
        {
            BaseMarketDataGrabber marketData = new AVMarketDataGrabber();
            HtmlDocument doc = marketData.HtmlGet("https://www.investing.com/");
            string result = doc.ToString();
            Console.Write(result);
        }

        #region Stock List
        static string[] _stockList = new string[] {
                "AAPL",
"MSFT",
"AMZN",
"BRKB",
"FB",
"JPM",
"JNJ",
"XOM",
"GOOG",
"GOOGL",
"BAC",
"INTC",
"WFC",
"T",
"CVX",
"V",
"PFE",
"HD",
"UNH",
"CSCO",
"PG",
"VZ",
"BA",
"C",
"KO",
"MA",
"CMCSA",
"PEP",
"PM",
"DIS",
"ABBV",
"DWDP",
"MRK",
"NVDA",
"ORCL",
"IBM",
"MMM",
"WMT",
"NFLX",
"MCD",
"MO",
"GE",
"AMGN",
"MDT",
"HON",
"ADBE",
"UNP",
"ABT",
"BMY",
"TXN",
"BKNG",
"GILD",
"AVGO",
"ACN",
"UTX",
"SLB",
"GS",
"CAT",
"NKE",
"PYPL",
"LMT",
"TMO",
"COST",
"QCOM",
"SBUX",
"CRM",
"USB",
"NEE",
"LLY",
"MS",
"TWX",
"LOW",
"UPS",
"PNC",
"COP",
"AXP",
"CELG",
"BLK",
"AMT",
"CB",
"CVS",
"CL",
"SCHW",
"RTN",
"MDLZ",
"GD",
"EOG",
"NOC",
"MU",
"DHR",
"FDX",
"AMAT",
"BIIB",
"CHTR",
"BDX",
"ANTM",
"WBA",
"AGN",
"AET",
"CME",
"DUK",
"BK",
"SYK",
"MON",
"TJX",
"ATVI",
"DE",
"ADP",
"OXY",
"CSX",
"AIG",
"SPGI",
"ITW",
"SPG",
"MET",
"CTSH",
"COF",
"ISRG",
"GM",
"CCI",
"SO",
"D",
"PRU",
"EMR",
"F",
"ICE",
"INTU",
"MMC",
"PX",
"VRTX",
"MAR",
"HAL",
"CI",
"ZTS",
"BBT",
"VLO",
"PSX",
"STZ",
"ESRX",
"KMB",
"NSC",
"FOXA",
"EBAY",
"EXC",
"TRV",
"TGT",
"BSX",
"EA",
"KHC",
"HUM",
"STT",
"HPQ",
"DAL",
"ECL",
"PGR",
"ETN",
"TEL",
"APD",
"ILMN",
"MPC",
"AON",
"LYB",
"AFL",
"ADI",
"ALL",
"EL",
"AEP",
"PLD",
"WM",
"EQIX",
"LRCX",
"APC",
"JCI",
"SHW",
"BAX",
"FIS",
"STI",
"LUV",
"PSA",
"USD",
"ROST",
"FISV",
"EW",
"PXD",
"MCK",
"ROP",
"SYY",
"DXC",
"KMI",
"SRE",
"PPG",
"YUM",
"ADSK",
"MTB",
"WDC",
"HPE",
"HCA",
"MCO",
"CCL",
"REGN",
"RHT",
"WY",
"TROW",
"APH",
"GIS",
"DFS",
"PEG",
"CMI",
"ALXN",
"VFC",
"ADM",
"GLW",
"ED",
"DG",
"SYF",
"FTV",
"MNST",
"FCX",
"SWK",
"OKE",
"PCAR",
"XEL",
"AVB",
"PH",
"APTV",
"PCG",
"EQR",
"DLTR",
"CXO",
"COL",
"ROK",
"IP",
"ZBH",
"FITB",
"AAL",
"NTRS",
"TSN",
"DLR",
"AMP",
"A",
"MCHP",
"IR",
"DPS",
"MYL",
"KR",
"NEM",
"RF",
"EIX",
"KEY",
"ORLY",
"WMB",
"CFG",
"WELL",
"WLTW",
"RCL",
"SBAC",
"CAH",
"WEC",
"PAYX",
"PPL",
"NUE",
"BXP",
"HRS",
"DTE",
"ES",
"CNC",
"XLNX",
"CERN",
"HIG",
"SWKS",
"ALGN",
"MGM",
"GPN",
"BBY",
"CBS",
"AZO",
"VTR",
"AME",
"INFO",
"NKTR",
"CLX",
"MSI",
"KLAC",
"DVN",
"UAL",
"IDXX",
"OMC",
"HBAN",
"LH",
"STX",
"CMA",
"PFG",
"NTAP",
"WRK",
"LEN",
"LLL",
"VRSK",
"K",
"CTL",
"SYMC",
"HLT",
"FOX",
"LNC",
"ESS",
"FAST",
"WAT",
"TXT",
"VMC",
"FE",
"DHI",
"EMN",
"DOV",
"NBL",
"TPR",
"TDG",
"O",
"RSG",
"APA",
"CAG",
"ETFC",
"CTAS",
"MHK",
"AWK",
"INCY",
"WYNN",
"MTD",
"URI",
"GWW",
"IQV",
"ANDV",
"CBRE",
"BFB",
"ETR",
"TSS",
"XL",
"RMD",
"NOV",
"EFX",
"SJM",
"TAP",
"ABC",
"XYL",
"HSY",
"BLL",
"AEE",
"MRO",
"HST",
"HES",
"DGX",
"EXPE",
"L",
"CHRW",
"IVZ",
"GPC",
"ANSS",
"GGP",
"MLM",
"MKC",
"FTI",
"CBOE",
"SIVB",
"CMS",
"MAS",
"ARE",
"AJG",
"NWL",
"SNPS",
"CHD",
"AKAM",
"CTXS",
"ULTA",
"VNO",
"LKQ",
"BHGE",
"EQT",
"CNP",
"HII",
"RJF",
"PVH",
"XRAY",
"WYN",
"KSU",
"TTWO",
"COO",
"PNR",
"BEN",
"EXR",
"VAR",
"EXPD",
"KMX",
"PRGO",
"KSS",
"CINF",
"COG",
"HCP",
"NCLH",
"WHR",
"VIAB",
"PKG",
"IFF",
"IT",
"DRI",
"CA",
"CDNS",
"NLSN",
"BLKFDS",
"RE",
"HOLX",
"MAA",
"UNM",
"HSIC",
"UHS",
"ADS",
"ZION",
"AMG",
"ALB",
"JBHT",
"FMC",
"NDAQ",
"BWA",
"TIF",
"ARNC",
"VRSN",
"DRE",
"DVA",
"HRL",
"LNT",
"HAS",
"LB",
"UDR",
"KORS",
"AVY",
"IRM",
"NRG",
"AOS",
"WU",
"CF",
"IPGP",
"M",
"FBHS",
"XEC",
"IPG",
"QRVO",
"TMK",
"FFIV",
"PNW",
"SLG",
"REG",
"DISH",
"AAP",
"COTY",
"FRT",
"PKI",
"MOS",
"JNPR",
"AMD",
"CPB",
"SNA",
"ALLE",
"NI",
"CMG",
"FLR",
"ALK",
"TSCO",
"PHM",
"AES",
"LUK",
"RHI",
"SEE",
"JEC",
"HP",
"HOG",
"FLIR",
"GPS",
"CSRA",
"HBI",
"PBCT",
"AIV",
"GRMN",
"XRX",
"GT",
"NWSA",
"MAC",
"KIM",
"DISCK",
"RL",
"LEG",
"AYI",
"JWN",
"FLS",
"FL",
"SCG",
"HRB",
"SRCL",
"PWR",
"BHF",
"NFX",
"AIZ",
"EVHC",
"TRIP",
"MAT",
"NAVI",
"RRC",
"DISCA",
"UAA",
"UA",
"NWS",
"UBFUT",
"ESM8"};

        #endregion

        static void testAVBatchQuote()
        {
            AVMarketDataGrabber av = new AVMarketDataGrabber();
            MarketDataDatabase marketData = new MarketDataDatabase();
            av.UpdateAPIKeys(marketData.VA_GetAvailableAPIKey(1));
            Quote[] quotes = av.StockBatchQuote(_stockList);
            Console.Write(quotes);
            
        }
    }
}
