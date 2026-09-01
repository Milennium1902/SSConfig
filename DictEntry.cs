using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSConfig
{
    public class DictEntry //this is needed because XmlSerializer is KEVIN and doesn't serialize dictionaries omgb
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public DictEntry()
        {

        }

        public DictEntry(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
