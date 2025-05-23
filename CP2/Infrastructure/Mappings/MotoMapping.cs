﻿using CP2.Domain.Entity;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CP2.Infrastructure.Mappings
{
    public class MotoMapping : IEntityTypeConfiguration<Moto>
    {
    public void Configure(EntityTypeBuilder<Moto> builder)
        {
            builder.ToTable("Moto");
            builder.HasKey(moto => moto.Id);

            builder.Property(moto => moto.Id)
                .IsRequired()
                .HasColumnName("ID");

            builder.Property(moto => moto.Placa)
                .IsRequired()
                .HasColumnName("PLACA")
                .HasMaxLength(7);

            builder.Property(moto => moto.Marca)
                .IsRequired()
                .HasColumnName("MARCA")
                .HasMaxLength(50);

            builder.Property(moto => moto.Modelo)
                .IsRequired()
                .HasColumnName("MODELO")
                .HasMaxLength(15);
            
            builder.Property(moto => moto.Cor)
                .IsRequired()
                .HasColumnName("COR")
                .HasMaxLength(10);

            builder.Property(moto => moto.StatusMoto)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(15)
                .HasConversion<string>();
        }
    }
}

