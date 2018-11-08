using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robots : IId
    {
        private string model;
        public string Id { get; set; }
        public string Model { get; set; }

        public Robots(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
