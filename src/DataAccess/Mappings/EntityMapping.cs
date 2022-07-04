﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Business.Models;

namespace DataAccess.Mappings;

public class EntityMapping<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
{
    private readonly string _tableName;
    public EntityMapping(string tableName = "") => _tableName = tableName;
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        if (!string.IsNullOrEmpty(_tableName))
            builder.ToTable(_tableName);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
    }
}
