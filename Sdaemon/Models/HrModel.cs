using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace Sdaemon.Models
{
    public class HrModel
    {

        public int Id { get; set; }
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
