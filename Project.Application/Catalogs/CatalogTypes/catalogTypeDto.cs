﻿namespace Project.Application.Catalogs.CatalogTypes
{
    public class catalogTypeDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? ParentCatalogTypeId { get; set; }

    }
}
