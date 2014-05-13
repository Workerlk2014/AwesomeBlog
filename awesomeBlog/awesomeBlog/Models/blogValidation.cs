using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace awesomeBlog.Models
{
    [MetadataType(typeof(ArticleMetadata))]
    public partial class Article
    {
 
    }
    public class ArticleMetadata
    {
        [Required(ErrorMessage = "you need to set a data")
        , Display(Name= "Article Title")]
        public string ArticleTitle;

        [Required(ErrorMessage = "you need to set a data")
        , Display(Name = "Your Message")]
        public string ArticleBody;

        [Required(ErrorMessage = "you need to set a data")
        , Display(Name = "Date")]
        public string ArticleDate;

        [Required(ErrorMessage = "you need to set a data")
        , Display(Name = "Your Name")]
        public string ArticleCreator;

        [Required(ErrorMessage = "you need to set a data")
        , Display(Name = "Positive Rating")]
        public string ArticlePositiveAppeal;

        [Required(ErrorMessage = "you need to set a data")
        , Display(Name = "Negative Rating")]
        public string ArticleNegativeAppeal;

        [Display(Name = "Picture Here or picture too long"), MaxLength(200)]
        public string ArticlePicture;

        [Display(Name = "Tags")]
        public string ArticleTags;

    }
}