﻿namespace SyncPoint365.Core.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<City> Cities { get; set; } = default!;
        public ICollection<Competency> Competencies { get; set; } = default!;

    }
}
