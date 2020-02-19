﻿using System;
using System.Collections.Generic;

namespace ixnChatbot
{
    public class projectResultsContainer
    {
        List<List<String>> contents = new List<List<String>>();
        private Dictionary<string, int> fieldNames = new Dictionary<string, int>();

        public projectResultsContainer(List<List<String>> contents, List<string> fieldNames)
        {
            this.contents = contents;
            
            for (int i = 0; i < fieldNames.Count; i++)
            {
                this.fieldNames.Add(fieldNames[i], i);
            }
        }
        
        public string getValue(int id, int field)
        {
            if (id < getNumberOfRecords())
            { 
                return contents[id][field];
            }
            return null;
        }

        public int getNumberOfRecords()
        {
            return contents.Count;
        }
    }
}