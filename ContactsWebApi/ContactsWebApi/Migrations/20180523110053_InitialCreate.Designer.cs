﻿// <auto-generated />
using ContactsWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ContactsWebApi.Migrations
{
    [DbContext(typeof(ContactsDbContext))]
    [Migration("20180523110053_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactsWebApi.Models.Contact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("city");

                    b.Property<string>("emailAddress");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("phoneNumber");

                    b.Property<string>("postalCode");

                    b.Property<string>("streetAddress");

                    b.HasKey("id");

                    b.ToTable("Contact");
                });
#pragma warning restore 612, 618
        }
    }
}
