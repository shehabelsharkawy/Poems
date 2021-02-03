using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poems.Data.Models
{
    public class ExceptionLog 
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// The method which had exception
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Method { get; set; }

        /// <summary>
        /// Parameters used if any
        /// </summary>
        [Required]
        public string Data { get; set; }

        /// <summary>
        /// Exception Details
        /// </summary>
        [Required]
        public string Exception { get; set; }


        /// <summary>
        /// Record's Creation Date
        /// For Audit Purpose
        /// </summary>
        public DateTime? CreationDate { get; set; }

    }

}
