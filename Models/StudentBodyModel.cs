using Microsoft.AspNetCore.Mvc;

namespace ModelBinding1.Models
{
    public class StudentBodyModel
    {
        [FromBody]    // For Body it is not optional.
        public int Id { get; set; }
        [FromBody]    // For Body it is not optional.
        public string Name { get; set; }
        [FromBody]    // For Body it is not optional.
        public string Address { get; set; }
    }
}
