using Microsoft.AspNetCore.Mvc;

namespace ModelBinding1.Models
{
    public class StudentRouteModel
    {
        //[FromRoute]    // For Route it is optional.
        public int Id { get; set; }
        //[FromRoute]    // For Route it is optional.
        public string Name { get; set; }
        //[FromRoute]    // For Route it is optional.
        public string Address { get; set; }
    }
}
