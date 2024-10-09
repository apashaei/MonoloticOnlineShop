using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Admin.EndPoint.ViewModels.Catalog
{
    public class CatalogTypeViewModel
    {
        public int Id { get; set; }

        [DisplayName("نام دسته بندی")]
        [Required]
        [MaxLength(100,ErrorMessage ="نام دسته بندی حداکثر باید 100 حرف باشد.")]
        public string Type { get; set; }
        public int? ParentCatalogTypeId { get; set; }
    }
}
