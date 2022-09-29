using System;
using System.IO;
using System.Collections.Generic;
using System.Data.OleDb;

namespace SshLink
{
    class CsvFile
    {
        //Properties
        private string url;

        //Constructor: sets the url
        public CsvFile(string FileLocation)
        {
            url = FileLocation;
        }

        public CsvFile()
        { }


        //Removes record at specific index - adapted for this but may be helpful in future
        public void RemoveRecordAt(int removeIndex)
        {
            string[][] recs = ReadRecords();
            int index = 0;
            List<string[]> newRecords = new List<string[]>();
            foreach(string[] record in recs)
            {
                if (index != removeIndex) newRecords.Add(record);
                index++;
            }
            File.WriteAllText(url, "");
            foreach(string[] record in newRecords)
            {
                WriteRecord(record);
            }
        }

        public void SetFileLocation(string FileLocation)
        {
            url = FileLocation;
        }

        //Read all records from the file
        public string[][] ReadRecords()
        {
            List<string[]> OutputList = new List<string[]>();
            try
            {
                using (var reader = new StreamReader(url))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        OutputList.Add(values);
                    }
                    reader.Close();
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("ReadRecords(): File does not exist");
            }
            catch(Exception ex)
            {
                Console.WriteLine("ReadRecords(): An unknown error has occured!");
            }
            return OutputList.ToArray();
        }

        //Append a record to a file
        public void WriteRecord(string[] Record)
        {
            string output = formString(Record);
            File.AppendAllText(url, output + Environment.NewLine);
        }

        //Ensure that the user is warned if entries with commas in them are written to the file
        private void validateField(string field)
        {
            foreach(char c in field)
            {
                if(c == ',')
                {
                    Console.WriteLine("WriteRecord(): Entry contains a comma! This will split the field if written to the file!");
                }
            }
        }

        //Form the string that will be written to the file
        private string formString(string[] Record)
        {
            string output = "";
            int len = Record.Length;
            string field;
            for (int i = 0; i < len; i++)
            {
                field = Record[i];
                validateField(field);
                output += field;
                if(i<len-1)
                {
                    output += ",";
                }
            }
            return output;
        }

        //Count the number of records in our file
        public int CountRecords()
        {
                using (var reader = new StreamReader(url))
                {
                    int count = 0;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        count++;
                    }
                    reader.Close();
                    return count;
                }
            
        }

        public void AmendRecord(int index, string[] record)
        {
            string[][] records = ReadRecords();
            List<string[]> newRecords = new List<string[]>();

            int numRecs = CountRecords();

            File.WriteAllText(url, "");

            for (int i = 0; i < numRecs; i++)
            {
                
                if (i != index)
                {
                    WriteRecord(records[i]);
                }
                else
                {
                    WriteRecord(record);
                }
            }

        }
    }
}
