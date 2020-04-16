using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storeman.Models
{
    [Table("FIL_TAB")]
    public partial class FilTab
    {
        public int F1101 { get; set; }
        public string F1025 { get; set; }
        public string F1026 { get; set; }
        [MaxLength(13)]
        public string F1027 { get; set; }
        public string F1028 { get; set; }
    }
}
