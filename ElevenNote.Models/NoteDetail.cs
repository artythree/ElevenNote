﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteDetail
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name ="created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name ="modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
