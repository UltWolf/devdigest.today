﻿using System;
using System.Collections.Generic;

namespace DAL
{
    public partial class Publication
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CategoryId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public DateTime DateTime { get; set; }
        public string Comment { get; set; }
        public string EmbededPlayerCode { get; set; }
        public int? LanguageId { get; set; }

        public Category Category { get; set; }
        public Language Language { get; set; }
        public User User { get; set; }
    }
}
