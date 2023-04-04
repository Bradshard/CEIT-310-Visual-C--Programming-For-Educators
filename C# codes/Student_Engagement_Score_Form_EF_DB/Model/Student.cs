using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Student_Engagement_Score_Form_EF_DB.Model
{
    [Table("StudentList")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [MinLength(2), MaxLength(25)]
        public string StudentName { get; set; }

        [MinLength(2), MaxLength(20)]
        public string StudentSurname
        {
            get; set;
        }
        [MinLength(4), MaxLength(45)]
        public string StudentFullName { get { return StudentName + " " + StudentSurname; } }
        [Column("Contact_Adress")]
        public string Email { get; set; }

        public List<Engagement> Engagements { get; set; }
    }
}
