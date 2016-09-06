using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;


public class DataParsing

{

	public static void Main()

	{  
        List<DateTime> OutputDates = new List<DateTime>();
	    DateTime today =  DateTime.Today;

        string pattern = @"(?<OutputDate>(0[1-9]|[10-12])(0[1-9]|[12][0-9]|3[01])(19|20)\d\d)";

        Regex reg = new Regex(pattern);
   

        //string fileContent = File.ReadAllText("C:/Users/Megha/Downloads/MarketingDataFileBI.txt");
		string fileContent = "0131201623765401171984";
           
     	MatchCollection matches = reg.Matches(fileContent);

            foreach (Match m in matches)

            {
				DateTime validDate;
				if(DateTime.TryParseExact(m.Value,"mmddyyyy", null, DateTimeStyles.None, out validDate))
				{
					if(validDate < today)				
					OutputDates.Add(validDate);
					Console.WriteLine("Valid date found: " + validDate.Date.ToString("d"));
				}
			}
	}

}
