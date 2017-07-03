using System.Collections.Generic;

namespace ExpandPanel.Models
{
    public class Users : List<User>
    {
        public int TeamId { get; set; }
    }
}