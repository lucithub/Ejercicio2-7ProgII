﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TurnoWebApi.Models;

public partial class turnos_db﻿Context : DbContext
{
    public turnos_db﻿Context(DbContextOptions<turnos_db﻿Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TDetallesTurno> TDetallesTurnos { get; set; }

    public virtual DbSet<TServicio> TServicios { get; set; }

    public virtual DbSet<TTurno> TTurnos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source = 172.16.10.196; Initial Catalog = turnos_db; Persist Security Info = True; User ID = alumno1w2; Trust Server Certificate = True");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TDetallesTurno>(entity =>
        {
            entity.HasKey(e => new { e.IdTurno, e.IdServicio });

            entity.ToTable("T_DETALLES_TURNO");

            entity.Property(e => e.IdTurno).HasColumnName("id_turno");
            entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AI")
                .HasColumnName("observaciones");
        });

        modelBuilder.Entity<TServicio>(entity =>
        {
            entity.ToTable("T_SERVICIOS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.EnPromocion)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AI")
                .HasColumnName("enPromocion");
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AI")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TTurno>(entity =>
        {
            entity.ToTable("T_TURNOS");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AI")
                .HasColumnName("cliente");
            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AI")
                .HasColumnName("fecha");
            entity.Property(e => e.Hora)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AI")
                .HasColumnName("hora");
            //entity.Property(e => e.FechaCancelacion)
            //    .HasColumnName("Fecha_Cancelacion");
            //entity.Property(e => e.MotivoCancelacion)
            //    .HasColumnName("Motivo_Cancelacion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}