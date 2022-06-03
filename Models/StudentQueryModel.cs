using Microsoft.AspNetCore.Mvc;

namespace ModelBinding1.Models
{
    public class StudentQueryModel
    {
        //[FromQuery]   // For Query it is optional.
        public int Id { get; set; }
        //[FromQuery]   // For Query it is optional.
        public string Name { get; set; }
        //[FromQuery]   // For Query it is optional.
        public string Address { get; set; }
    }
}
