using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Children
    {
        private string name;
        private DateTime birthday;

        public Children(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
