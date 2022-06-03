using Microsoft.AspNetCore.Mvc;

namespace ModelBinding1.Models
{
    public class StudentFormModel
    {
        [FromForm]    // For Header it is not optional.
        public int Id { get; set; }
        [FromForm]    // For Header it is not optional.
        public string Name { get; set; }
        [FromForm]    // For Header it is not optional.
        public string Address { get; set; }
    }
}
