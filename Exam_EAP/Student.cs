using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Exam_EAP
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string StudentID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Email { get; set; }

        public Student() { }
        public Student(string student, string firstName, string lastName, string phoneNumber, string email)
        {
            StudentID = student;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}