using System;
using System.Collections.Generic;
using System.Text;

namespace LogSentinel.Client
{
    public class Pair
    {
        private String name = "";
        private String value = "";

        public Pair(String name, String value)
        {
            setName(name);
            setValue(value);
        }

        private void setName(String name)
        {
            if (!isValidString(name)) return;

            this.name = name;
        }

        private void setValue(String value)
        {
            if (!isValidString(value)) return;

            this.value = value;
        }

        public String getName()
        {
            return this.name;
        }

        public String getValue()
        {
            return this.value;
        }

        private bool isValidString(String arg)
        {
            if (arg == null) return false;
            if (arg.Trim() == "") return false;
            return true;
        }
    }
}
