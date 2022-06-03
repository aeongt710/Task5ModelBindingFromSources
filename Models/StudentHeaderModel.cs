using Microsoft.AspNetCore.Mvc;

namespace ModelBinding1.Models
{
    public class StudentHeaderModel
    {
        [FromHeader]    // For Header it is not optional.
        public int Id { get; set; }
        [FromHeader]    // For Header it is not optional.
        public string Name { get; set; }
        [FromHeader]    // For Header it is not optional.
        public string Address { get; set; }
    }
}
