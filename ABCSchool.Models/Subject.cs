﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCSchool.Models
{
    public partial class Subject : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 1)]
        public string Name { get; set; }

        public Subject()
        {
            StudentsSubjects = new HashSet<StudentsSubjects>();
        }
        public virtual ICollection<StudentsSubjects> StudentsSubjects { get; set; }
    }
}
