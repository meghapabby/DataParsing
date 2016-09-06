Program Logic and Assumptions
1. I have created a regular expression to find matches for MMDDYYYY format. Assuming that the year is not earlier than 1900.
2. Hard-coded input string for development purpose and applied regular expression to it.
3. If a match is found, check whether it is a valid date using TryParseExact() method.
4. If  valid date, then check if it is less than today, since we want only dates prior to today in our output.
5. If all these criteria are met, the valid date is added to the final output list.

My next steps would be:
1. To read the input file into a string.
2. Iterate through the whole file, to find all matches

