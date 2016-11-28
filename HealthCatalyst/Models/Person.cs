
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/*The application accepts search input in a text box and then displays in a pleasing style a list of
 *   whose first or last name matches what was typed in the search box
 *   (displaying at least name, address, age, interests, and a picture). 
Solution should either seed data or provide a way to enter new users or both*/
namespace HealthCatalyst.Models
{
    public class Person
    {
        [Key]
        public int personID { get; set; }
        [DisplayName("First Name")]
        public string firstName { get; set; }
        [DisplayName("Last Name")]
        public string lastName { get; set; }
        [DisplayName("Address")]
        public string streetAddress { get; set; }
        [DisplayName("Zip Code")]
        public string zip { get; set; }
        [DisplayName("City")]
        public string city { get; set; }
        [DisplayName("State")]
        public string state { get; set; }
        [DisplayName("Age")]
        public int age { get; set; }
        [DisplayName("Interests")]
        public string interests { get; set; }
        [DisplayName("Image Path")]
        public string personImgPath { get; set; }
    }
}
