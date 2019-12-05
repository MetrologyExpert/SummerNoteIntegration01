using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SummerNoteIntegration01.Models
{
    public class Post
    {

        public int Id { get; set; }

        [Display(Name = "Posts Title")]
        public string PostName { get; set; }

        [Display(Name = "Post Description")]
        public string PostDescription { get; set; }

        [Display(Name = "Post Content")]
        [AllowHtml]
        public string Content { get; set; }

        public DateTime TimeStamp { get; set; }

        public Post()
        {
            TimeStamp = DateTime.Now;
        }

    }

}