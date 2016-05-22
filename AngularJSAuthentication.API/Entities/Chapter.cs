using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJSAuthentication.API.Entities
{
    public class Chapter
    {
        [Key]
        public int CId { set; get; }
        public int ChapterNumber { set; get; }
        public string ChapterTitle { set; get; }
    }
}