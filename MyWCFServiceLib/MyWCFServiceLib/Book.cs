using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFServiceLib
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId { get; set; }

        [DataMember]
        private string _title;

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        [DataMember]
        public string Publisher { get; set; }
    }
}
