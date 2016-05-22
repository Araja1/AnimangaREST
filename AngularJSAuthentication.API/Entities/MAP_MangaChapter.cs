using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJSAuthentication.API.Entities
{
    public class MAP_MangaChapter
    {
        [Key]
        public int MId { get; set; }
        [Key]
        public int CId { get; set; }
    }
}