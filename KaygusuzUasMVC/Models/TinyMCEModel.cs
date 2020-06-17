using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace KaygusuzUasMVC.Models {

    public class TinyMCEModel {

        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Content { get; set; }

    }
}