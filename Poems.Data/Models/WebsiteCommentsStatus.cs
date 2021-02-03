using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class WebsiteCommentsStatus
    {
        public int WebsiteCommentsId { get; set; }
        public int UserRoleId { get; set; }
        public int CommentId { get; set; }
        public int ApprovalVote { get; set; }
        public int DisapprovalVote { get; set; }
        public string DisapprovalReason { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
