
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;
using WebApplication1.Database.Helpers;

namespace WebApplication1.Database.Configurations
{
    public class TeachingLoadConfiguration : IEntityTypeConfiguration<TeachingLoad>
    {
        private const string TableName = "cd_teaching_load";

        public void Configure(EntityTypeBuilder<TeachingLoad> builder)
        {
            builder
                .HasKey(t => t.TeachingLoadId)
                .HasName($"pk_{TableName}_teaching_load_id");

            builder.Property(t => t.TeachingLoadId)
                .ValueGeneratedOnAdd()
                .HasColumnName("teaching_load_id")
                .HasComment("Идентификатор нагрузки на преподавателя");

            builder.Property(t => t.Hours)
                .IsRequired()
                .HasColumnName("c_hours")
                .HasColumnType(ColumnType.Int)
                .HasComment("Количество часов");

            builder.ToTable(TableName);
        }
    }
}