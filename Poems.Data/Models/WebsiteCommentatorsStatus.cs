using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class WebsiteCommentatorsStatus
    {
        public int? WebsiteCommentatorId { get; set; }
        public int UserRoleId { get; set; }
        public int CommentatorId { get; set; }
        public bool Blocked { get; set; }
        public string Reason { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
