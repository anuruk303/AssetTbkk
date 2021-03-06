﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tbkk_AC.Models;

namespace tbkk_AC.Migrations
{
    [DbContext(typeof(tbkk_ACContext))]
    [Migration("20200327185005_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tbkk_AC.Models.Asset", b =>
                {
                    b.Property<int>("AssetID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetName");

                    b.Property<int>("Category");

                    b.Property<int>("Company_CompanyID");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<string>("Image");

                    b.Property<DateTime>("InstallDate");

                    b.Property<int>("Location_LocationID");

                    b.Property<string>("MACAddr");

                    b.Property<int>("Model_ModelID");

                    b.Property<string>("Note");

                    b.Property<string>("PONumber")
                        .IsRequired();

                    b.Property<string>("Price");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("SerailNumber");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("Supplier_SupplierID");

                    b.Property<int>("Warranty");

                    b.HasKey("AssetID");

                    b.ToTable("Asset");
                });

            modelBuilder.Entity("tbkk_AC.Models.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("BrandID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("tbkk_AC.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Image");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("tbkk_AC.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("Image");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("CompanyID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("tbkk_AC.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("DepartmentID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("tbkk_AC.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addr");

                    b.Property<string>("Call");

                    b.Property<int>("Company_CompanyID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<string>("Email");

                    b.Property<int>("EmployeeType_EmployeeTypeID");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("Image");

                    b.Property<string>("LastName");

                    b.Property<string>("Line");

                    b.Property<int>("Location_LocationID");

                    b.Property<int>("Position_PositionID");

                    b.Property<string>("Status");

                    b.HasKey("EmployeeID");

                    b.HasIndex("Company_CompanyID");

                    b.HasIndex("Department_DepartmentID");

                    b.HasIndex("EmployeeType_EmployeeTypeID");

                    b.HasIndex("Location_LocationID");

                    b.HasIndex("Position_PositionID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("tbkk_AC.Models.EmployeeType", b =>
                {
                    b.Property<int>("EmployeeTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeTypeName");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("EmployeeTypeID");

                    b.ToTable("EmployeeType");
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_Asset_Asset", b =>
                {
                    b.Property<int>("JoinAsAsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetSon");

                    b.Property<int>("Asset_AssetID");

                    b.Property<string>("Note");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("JoinAsAsID");

                    b.ToTable("Join_Asset_Asset");
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_Asset_Emp", b =>
                {
                    b.Property<int>("JoinAsEmpID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Asset_AssetID");

                    b.Property<int>("Employee_EmployeeID");

                    b.Property<string>("Note");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("JoinAsEmpID");

                    b.HasIndex("Asset_AssetID");

                    b.ToTable("Join_Asset_Emp");
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_License_Asset", b =>
                {
                    b.Property<int>("JoinLiAsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssetID");

                    b.Property<int>("Asset_AssetID");

                    b.Property<int>("License_LicenseID");

                    b.Property<string>("Note");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("JoinLiAsID");

                    b.HasIndex("AssetID");

                    b.HasIndex("License_LicenseID");

                    b.ToTable("Join_License_Asset");
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_Network_Asset", b =>
                {
                    b.Property<int>("JoinNetAsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Asset_AssetID");

                    b.Property<int>("Network_NetworkID");

                    b.Property<string>("Note");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("JoinNetAsID");

                    b.HasIndex("Asset_AssetID");

                    b.HasIndex("Network_NetworkID");

                    b.ToTable("Join_Network_Asset");
                });

            modelBuilder.Entity("tbkk_AC.Models.License", b =>
                {
                    b.Property<int>("LicenseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachfiles");

                    b.Property<int>("Company_CompanyID");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<DateTime>("InstallDate");

                    b.Property<string>("LicenseName")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<string>("PONumber")
                        .IsRequired();

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("SoftewareName");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("Supplier_SupplierID");

                    b.HasKey("LicenseID");

                    b.ToTable("License");
                });

            modelBuilder.Entity("tbkk_AC.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("LocationID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("tbkk_AC.Models.Model", b =>
                {
                    b.Property<int>("ModelID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Brand_BrandID");

                    b.Property<string>("ModelName");

                    b.Property<string>("Note");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("ModelID");

                    b.HasIndex("Brand_BrandID");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("tbkk_AC.Models.Network", b =>
                {
                    b.Property<int>("NetworkID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IpAddr");

                    b.Property<string>("NetworkName")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<string>("Password");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("NetworkID");

                    b.ToTable("Network");
                });

            modelBuilder.Entity("tbkk_AC.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("PositionID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("tbkk_AC.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("ContactName");

                    b.Property<string>("Email");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("SupplierName")
                        .IsRequired();

                    b.Property<string>("URL");

                    b.HasKey("SupplierID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("tbkk_AC.Models.Update_Asset", b =>
                {
                    b.Property<int>("UpdateAssetID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Asset_AssetID");

                    b.Property<int>("Category");

                    b.Property<int>("Company_CompanyID");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<int>("Employee_EmpID");

                    b.Property<int>("Location_LocationID");

                    b.Property<int>("Model_ModelID");

                    b.Property<int>("Supplier_SupplierID");

                    b.Property<string>("UpdateAssetName")
                        .IsRequired();

                    b.Property<DateTime>("UpdateDate");

                    b.Property<DateTime>("UpdateExpireDate");

                    b.Property<string>("UpdateImage")
                        .IsRequired();

                    b.Property<DateTime>("UpdateInstallDate");

                    b.Property<string>("UpdateMACAddr")
                        .IsRequired();

                    b.Property<string>("UpdateNote")
                        .IsRequired();

                    b.Property<string>("UpdatePONumber")
                        .IsRequired();

                    b.Property<string>("UpdatePrice")
                        .IsRequired();

                    b.Property<DateTime>("UpdatePurchaseDate");

                    b.Property<string>("UpdateSerailNumber")
                        .IsRequired();

                    b.Property<string>("UpdateStatus")
                        .IsRequired();

                    b.Property<int>("UpdateWarranty");

                    b.HasKey("UpdateAssetID");

                    b.ToTable("Update_Asset");
                });

            modelBuilder.Entity("tbkk_AC.Models.Update_License", b =>
                {
                    b.Property<int>("UpdateLicenseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachfiles")
                        .IsRequired();

                    b.Property<int>("Company_CompanyID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Department_DepartmentID");

                    b.Property<int>("Employee");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<DateTime>("InstallDate");

                    b.Property<string>("LicenseName")
                        .IsRequired();

                    b.Property<int>("License_LicenseID");

                    b.Property<int>("Model_ModelID");

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("PONumber")
                        .IsRequired();

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("SoftewareName")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("Supplier_SupplierID");

                    b.HasKey("UpdateLicenseID");

                    b.ToTable("Update_License");
                });

            modelBuilder.Entity("tbkk_AC.Models.Update_Network", b =>
                {
                    b.Property<int>("NetworkUpdateID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("Employee_EmpID");

                    b.Property<string>("IpAddr")
                        .IsRequired();

                    b.Property<string>("NetworkName")
                        .IsRequired();

                    b.Property<int>("Network_NetworkID");

                    b.Property<string>("Note")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("NetworkUpdateID");

                    b.ToTable("Update_Network");
                });

            modelBuilder.Entity("tbkk_AC.Models.Employee", b =>
                {
                    b.HasOne("tbkk_AC.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("Company_CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeType_EmployeeTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("Location_LocationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("Position_PositionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_Asset_Emp", b =>
                {
                    b.HasOne("tbkk_AC.Models.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("Asset_AssetID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_License_Asset", b =>
                {
                    b.HasOne("tbkk_AC.Models.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetID");

                    b.HasOne("tbkk_AC.Models.License", "License")
                        .WithMany()
                        .HasForeignKey("License_LicenseID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tbkk_AC.Models.Join_Network_Asset", b =>
                {
                    b.HasOne("tbkk_AC.Models.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("Asset_AssetID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tbkk_AC.Models.Network", "Network")
                        .WithMany()
                        .HasForeignKey("Network_NetworkID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tbkk_AC.Models.Model", b =>
                {
                    b.HasOne("tbkk_AC.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("Brand_BrandID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
