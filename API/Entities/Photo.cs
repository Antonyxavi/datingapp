using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("photos")]
    public class Photo
    {

        public int Id { get; set; }

        public string Url { get; set; }

        public bool IsMain { get; set; }

        public string PublicId { get; set; }

        public Appuser Appuser{get;set;}

        public int AppUserId { get; set; }
        
    }
}