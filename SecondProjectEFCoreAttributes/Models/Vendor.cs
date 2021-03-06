﻿using SecondProjectEFCoreAttributes.CustomAnnotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProjectEFCoreAttributes.Models
{
    [Table("Torfeh_vendor")]
    public class Vendor
    {
        public Vendor()
        {
            Tags = new HashSet<Tag>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [TagsIcollectionAnnotation]
        public ICollection<Tag> Tags { get; set; }
    }
}
