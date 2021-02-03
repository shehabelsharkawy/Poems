using System;
using System.Collections.Generic;

#nullable disable

namespace Poems.Data.Models
{
    public partial class RofoufStatus
    {
        public RofoufStatus()
        {
            RofoufAuthors = new HashSet<RofoufAuthor>();
            RofoufPublishers = new HashSet<RofoufPublisher>();
        }

        public int RofoufFileId { get; set; }
        public int FileId { get; set; }
        public string FileMd5 { get; set; }
        public string DropBoxFileStatus { get; set; }
        public string Title { get; set; }
        public bool? IsBook { get; set; }
        public string SubTitle { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int? PageCount { get; set; }
        public string Isbn { get; set; }
        public string TxtPublicationDate { get; set; }
        public int? DataUserRoleId { get; set; }
        public DateTime? DataUpdateDate { get; set; }
        public int? CoverUserRoleId { get; set; }
        public DateTime? CoverUploadDate { get; set; }

        public virtual UserRole CoverUserRole { get; set; }
        public virtual UserRole DataUserRole { get; set; }
        public virtual ICollection<RofoufAuthor> RofoufAuthors { get; set; }
        public virtual ICollection<RofoufPublisher> RofoufPublishers { get; set; }
    }
}
