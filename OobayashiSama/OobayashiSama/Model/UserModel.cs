using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OobayashiSama.Model
{
    public class UserModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public DateTime? UpdDate { get; set; }
    }
}