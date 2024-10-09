namespace Project.Application.Catalogs.GetMenuItem
{
    public class MenuItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public List<MenuItemDto> Children { get; set; }
    }
}
