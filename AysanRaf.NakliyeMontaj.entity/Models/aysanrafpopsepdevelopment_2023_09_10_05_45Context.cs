using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models
{
    public partial class aysanrafpopsepdevelopment_2023_09_10_05_45Context : DbContext
    {
        public aysanrafpopsepdevelopment_2023_09_10_05_45Context()
        {
        }

        public aysanrafpopsepdevelopment_2023_09_10_05_45Context(DbContextOptions<aysanrafpopsepdevelopment_2023_09_10_05_45Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountingEtacurrentBalance> AccountingEtacurrentBalances { get; set; } = null!;
        public virtual DbSet<AccountingEtatrialBalance> AccountingEtatrialBalances { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<Asset> Assets { get; set; } = null!;
        public virtual DbSet<AssetUsedTaskType> AssetUsedTaskTypes { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<CurrencyParity> CurrencyParities { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employment> Employments { get; set; } = null!;
        public virtual DbSet<EmploymentTaskType> EmploymentTaskTypes { get; set; } = null!;
        public virtual DbSet<EnergyCost> EnergyCosts { get; set; } = null!;
        public virtual DbSet<ExpenseCategory> ExpenseCategories { get; set; } = null!;
        public virtual DbSet<ExpenseRecord> ExpenseRecords { get; set; } = null!;
        public virtual DbSet<ExpenseRecordGroup> ExpenseRecordGroups { get; set; } = null!;
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; } = null!;
        public virtual DbSet<Facility> Facilities { get; set; } = null!;
        public virtual DbSet<FacilityStorage> FacilityStorages { get; set; } = null!;
        public virtual DbSet<InAppNotification> InAppNotifications { get; set; } = null!;
        public virtual DbSet<InventoryItem> InventoryItems { get; set; } = null!;
        public virtual DbSet<InventoryItemMedia> InventoryItemMedias { get; set; } = null!;
        public virtual DbSet<InventoryItemTransaction> InventoryItemTransactions { get; set; } = null!;
        public virtual DbSet<InventoryPsstockLevelConstraint> InventoryPsstockLevelConstraints { get; set; } = null!;
        public virtual DbSet<OrganizationDetail> OrganizationDetails { get; set; } = null!;
        public virtual DbSet<Party> Parties { get; set; } = null!;
        public virtual DbSet<PlannedOfferForm> PlannedOfferForms { get; set; } = null!;
        public virtual DbSet<Plannedrealizedrelation> Plannedrealizedrelations { get; set; } = null!;
        public virtual DbSet<ProcurementPurchaseOrder> ProcurementPurchaseOrders { get; set; } = null!;
        public virtual DbSet<ProcurementPurchaseOrderItem> ProcurementPurchaseOrderItems { get; set; } = null!;
        public virtual DbSet<ProcurementPurchaseOrderWayBillDocument> ProcurementPurchaseOrderWayBillDocuments { get; set; } = null!;
        public virtual DbSet<ProcurementRequest> ProcurementRequests { get; set; } = null!;
        public virtual DbSet<ProcurementRequestMedia> ProcurementRequestMedias { get; set; } = null!;
        public virtual DbSet<ProcurementRfq> ProcurementRfqs { get; set; } = null!;
        public virtual DbSet<ProcurementRfqbid> ProcurementRfqbids { get; set; } = null!;
        public virtual DbSet<ProcurementRfqbidItem> ProcurementRfqbidItems { get; set; } = null!;
        public virtual DbSet<ProcurementUserNotificationSetting> ProcurementUserNotificationSettings { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Pscategory> Pscategories { get; set; } = null!;
        public virtual DbSet<PscategoryMedia> PscategoryMedias { get; set; } = null!;
        public virtual DbSet<PscategoryQccode> PscategoryQccodes { get; set; } = null!;
        public virtual DbSet<PscategoryQcmeasurementParameter> PscategoryQcmeasurementParameters { get; set; } = null!;
        public virtual DbSet<PscategoryQcmeasurementParameterMedia> PscategoryQcmeasurementParameterMedias { get; set; } = null!;
        public virtual DbSet<PscategoryTaskType> PscategoryTaskTypes { get; set; } = null!;
        public virtual DbSet<Pscomponent> Pscomponents { get; set; } = null!;
        public virtual DbSet<PscomponentTaskTypeExclude> PscomponentTaskTypeExcludes { get; set; } = null!;
        public virtual DbSet<Psfeature> Psfeatures { get; set; } = null!;
        public virtual DbSet<PsfeatureValue> PsfeatureValues { get; set; } = null!;
        public virtual DbSet<Psmedia> Psmedias { get; set; } = null!;
        public virtual DbSet<Psprice> Psprices { get; set; } = null!;
        public virtual DbSet<PspriceEnterRequest> PspriceEnterRequests { get; set; } = null!;
        public virtual DbSet<Pss> Psses { get; set; } = null!;
        public virtual DbSet<QualityAssuranceStandard> QualityAssuranceStandards { get; set; } = null!;
        public virtual DbSet<RealizedOfferForm> RealizedOfferForms { get; set; } = null!;
        public virtual DbSet<RelationCustomer> RelationCustomers { get; set; } = null!;
        public virtual DbSet<RelationCustomerContactPerson> RelationCustomerContactPersons { get; set; } = null!;
        public virtual DbSet<RelationPartyQascertificate> RelationPartyQascertificates { get; set; } = null!;
        public virtual DbSet<RelationPartyRegistry> RelationPartyRegistries { get; set; } = null!;
        public virtual DbSet<RelationPartySupplier> RelationPartySuppliers { get; set; } = null!;
        public virtual DbSet<RelationReseller> RelationResellers { get; set; } = null!;
        public virtual DbSet<RelationResellerContactPerson> RelationResellerContactPersons { get; set; } = null!;
        public virtual DbSet<RelationSupplierPscategory> RelationSupplierPscategories { get; set; } = null!;
        public virtual DbSet<RelationSupplierSalesPerson> RelationSupplierSalesPersons { get; set; } = null!;
        public virtual DbSet<ReminderNotificationLog> ReminderNotificationLogs { get; set; } = null!;
        public virtual DbSet<RentedEquipment> RentedEquipments { get; set; } = null!;
        public virtual DbSet<SalesCustomerMeetingForm> SalesCustomerMeetingForms { get; set; } = null!;
        public virtual DbSet<SalesCustomerMeetingFormFile> SalesCustomerMeetingFormFiles { get; set; } = null!;
        public virtual DbSet<SalesOffer> SalesOffers { get; set; } = null!;
        public virtual DbSet<SalesOfferCustomerFile> SalesOfferCustomerFiles { get; set; } = null!;
        public virtual DbSet<SalesOfferInternalFile> SalesOfferInternalFiles { get; set; } = null!;
        public virtual DbSet<SalesOfferItem> SalesOfferItems { get; set; } = null!;
        public virtual DbSet<SalesOfferNote> SalesOfferNotes { get; set; } = null!;
        public virtual DbSet<SalesOfferPaymentPlanStep> SalesOfferPaymentPlanSteps { get; set; } = null!;
        public virtual DbSet<SalesOfferTermsDefaultValue> SalesOfferTermsDefaultValues { get; set; } = null!;
        public virtual DbSet<SalesOrder> SalesOrders { get; set; } = null!;
        public virtual DbSet<SalesOrderCustomerFile> SalesOrderCustomerFiles { get; set; } = null!;
        public virtual DbSet<SalesOrderInternalFile> SalesOrderInternalFiles { get; set; } = null!;
        public virtual DbSet<SalesOrderInvoice> SalesOrderInvoices { get; set; } = null!;
        public virtual DbSet<SalesOrderItem> SalesOrderItems { get; set; } = null!;
        public virtual DbSet<SalesOrderItemComponent> SalesOrderItemComponents { get; set; } = null!;
        public virtual DbSet<SalesOrderNote> SalesOrderNotes { get; set; } = null!;
        public virtual DbSet<SalesOrderPaymentPlanStep> SalesOrderPaymentPlanSteps { get; set; } = null!;
        public virtual DbSet<SalesPersonRevenueGoal> SalesPersonRevenueGoals { get; set; } = null!;
        public virtual DbSet<Shipment> Shipments { get; set; } = null!;
        public virtual DbSet<ShipmentAmountBasedPlan> ShipmentAmountBasedPlans { get; set; } = null!;
        public virtual DbSet<ShipmentAmountBasedPlanItem> ShipmentAmountBasedPlanItems { get; set; } = null!;
        public virtual DbSet<ShipmentItem> ShipmentItems { get; set; } = null!;
        public virtual DbSet<ShipmentWayBillDocument> ShipmentWayBillDocuments { get; set; } = null!;
        public virtual DbSet<StockCountingActivity> StockCountingActivities { get; set; } = null!;
        public virtual DbSet<StockCountingActivityItem> StockCountingActivityItems { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<TaskActivity> TaskActivities { get; set; } = null!;
        public virtual DbSet<TaskActivityAsset> TaskActivityAssets { get; set; } = null!;
        public virtual DbSet<TaskActivityEmployee> TaskActivityEmployees { get; set; } = null!;
        public virtual DbSet<TaskActivityInventoryItem> TaskActivityInventoryItems { get; set; } = null!;
        public virtual DbSet<TaskActivityQcmeasurement> TaskActivityQcmeasurements { get; set; } = null!;
        public virtual DbSet<TaskActivityQcmeasurementMedia> TaskActivityQcmeasurementMedias { get; set; } = null!;
        public virtual DbSet<TaskNote> TaskNotes { get; set; } = null!;
        public virtual DbSet<TaskType> TaskTypes { get; set; } = null!;
        public virtual DbSet<Urundene2> Urundene2s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=192.168.1.32;Database=aysanrafpopsepdevelopment_2023_09_10_05_45;Username=postgres;Password=15051505");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

            modelBuilder.Entity<AccountingEtacurrentBalance>(entity =>
            {
                entity.ToTable("AccountingETACurrentBalances");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.BalanceForeignCurrency).HasPrecision(18, 6);

                entity.Property(e => e.CollectionDescription).HasMaxLength(128);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.CurrencyCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("CurrencyCodeISO3");

                entity.Property(e => e.DepthAmountForeignCurrency).HasPrecision(18, 6);

                entity.Property(e => e.DepthAmountTry)
                    .HasPrecision(18, 6)
                    .HasColumnName("DepthAmountTRY");

                entity.Property(e => e.Difference).HasPrecision(18, 6);

                entity.Property(e => e.DueDateAverage).HasMaxLength(10);

                entity.Property(e => e.PartyId).HasMaxLength(36);

                entity.Property(e => e.PartyName).HasMaxLength(256);

                entity.Property(e => e.ReceivableAmountForeignCurrency).HasPrecision(18, 6);

                entity.Property(e => e.ReceivableAmountTry)
                    .HasPrecision(18, 6)
                    .HasColumnName("ReceivableAmountTRY");

                entity.Property(e => e.SalesPersonCode).HasMaxLength(148);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<AccountingEtatrialBalance>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.Code, e.Year, e.Month });

                entity.ToTable("AccountingETATrialBalances");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.Code).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.CurrencyCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("CurrencyCodeISO3");

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.BirthDate).HasMaxLength(19);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(36);

                entity.Property(e => e.LastName).HasMaxLength(36);

                entity.Property(e => e.MarriageFamilyName).HasMaxLength(36);

                entity.Property(e => e.MidName).HasMaxLength(36);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PhoneNumber).HasMaxLength(36);

                entity.Property(e => e.PreviousUserId).HasMaxLength(20);

                entity.Property(e => e.PrimaryCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("PrimaryCountryCodeISO3");

                entity.Property(e => e.PrimaryLanguageCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("PrimaryLanguageCodeISO3");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(36);
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasIndex(e => e.InventoryItemId, "IX_Assets_InventoryItemId");

                entity.HasIndex(e => e.Psid, "IX_Assets_PSId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AmortizationPerHour).HasPrecision(18, 6);

                entity.Property(e => e.ChasisNumber).HasMaxLength(36);

                entity.Property(e => e.Code).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.ElectricityPerHour).HasPrecision(18, 6);

                entity.Property(e => e.EngineNumber).HasMaxLength(36);

                entity.Property(e => e.FuelPerHour).HasPrecision(18, 6);

                entity.Property(e => e.GasPerHour).HasPrecision(18, 6);

                entity.Property(e => e.InventoryItemId).HasMaxLength(36);

                entity.Property(e => e.LicenseNumber).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.PlateNumber).HasMaxLength(16);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.PurchaseLeaseTypeId).HasMaxLength(36);

                entity.Property(e => e.RegistrationNumber).HasMaxLength(36);

                entity.Property(e => e.SerialNumber).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.InventoryItem)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.InventoryItemId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.Psid);
            });

            modelBuilder.Entity<AssetUsedTaskType>(entity =>
            {
                entity.HasKey(e => new { e.AssetId, e.TaskTypeId });

                entity.HasIndex(e => e.TaskTypeId, "IX_AssetUsedTaskTypes_TaskTypeId");

                entity.Property(e => e.AssetId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetUsedTaskTypes)
                    .HasForeignKey(d => d.AssetId);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.AssetUsedTaskTypes)
                    .HasForeignKey(d => d.TaskTypeId);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_Brands_TenantId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Brands)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => e.ContactPersonId, "IX_Contacts_ContactPersonId");

                entity.HasIndex(e => e.PartyId, "IX_Contacts_PartyId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AccessUrl).HasMaxLength(2048);

                entity.Property(e => e.AddressBuilding).HasMaxLength(64);

                entity.Property(e => e.AddressCity).HasMaxLength(64);

                entity.Property(e => e.AddressCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("AddressCountryCodeISO3");

                entity.Property(e => e.AddressDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.AddressFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.AddressFloor).HasMaxLength(16);

                entity.Property(e => e.AddressPostalCode).HasMaxLength(16);

                entity.Property(e => e.AddressSite).HasMaxLength(64);

                entity.Property(e => e.AddressState).HasMaxLength(64);

                entity.Property(e => e.AddressStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.AddressStreetNo).HasMaxLength(16);

                entity.Property(e => e.AddressTown).HasMaxLength(64);

                entity.Property(e => e.ContactPersonId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.DateEnd).HasMaxLength(19);

                entity.Property(e => e.DateStart).HasMaxLength(19);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Fax).HasMaxLength(36);

                entity.Property(e => e.LandPhone).HasMaxLength(36);

                entity.Property(e => e.MobilePhone).HasMaxLength(36);

                entity.Property(e => e.PartyId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.Type).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.WebSiteUrl).HasMaxLength(1024);

                entity.HasOne(d => d.ContactPerson)
                    .WithMany(p => p.ContactContactPeople)
                    .HasForeignKey(d => d.ContactPersonId);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.ContactParties)
                    .HasForeignKey(d => d.PartyId);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(3);

                entity.Property(e => e.CapitalName).HasMaxLength(256);

                entity.Property(e => e.CodeIso2).HasMaxLength(2);

                entity.Property(e => e.CodeIso3).HasMaxLength(3);

                entity.Property(e => e.CodeIsoNumeric).HasMaxLength(4);

                entity.Property(e => e.ContinentCode2).HasMaxLength(2);

                entity.Property(e => e.ContinentName).HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.CurrencyCode3).HasMaxLength(3);

                entity.Property(e => e.CurrencyName).HasMaxLength(32);

                entity.Property(e => e.CurrencySymbolUnicode).HasMaxLength(16);

                entity.Property(e => e.FipsCode).HasMaxLength(2);

                entity.Property(e => e.GeonameId).HasMaxLength(16);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.OfficialName).HasMaxLength(256);

                entity.Property(e => e.PhoneCode).HasMaxLength(5);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.SubCurrencyName).HasMaxLength(32);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<CurrencyParity>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Parity });

                entity.Property(e => e.Date).HasMaxLength(10);

                entity.Property(e => e.Parity).HasMaxLength(7);

                entity.Property(e => e.Ratio).HasPrecision(18, 6);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.ManagerUserId, "IX_Departments_ManagerUserId");

                entity.HasIndex(e => e.OrganizationId, "IX_Departments_OrganizationId");

                entity.HasIndex(e => e.ParentDepartmentId, "IX_Departments_ParentDepartmentId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.ManagerUserId).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.OrganizationId).HasMaxLength(36);

                entity.Property(e => e.ParentDepartmentId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.ManagerUser)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ManagerUserId);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.OrganizationId);

                entity.HasOne(d => d.ParentDepartment)
                    .WithMany(p => p.InverseParentDepartment)
                    .HasForeignKey(d => d.ParentDepartmentId);
            });

            modelBuilder.Entity<Employment>(entity =>
            {
                entity.HasKey(e => new { e.EmployerId, e.EmployeeId });

                entity.HasIndex(e => e.DepartmentId, "IX_Employments_DepartmentId");

                entity.HasIndex(e => e.EmployeeId, "IX_Employments_EmployeeId");

                entity.Property(e => e.EmployerId).HasMaxLength(36);

                entity.Property(e => e.EmployeeId).HasMaxLength(36);

                entity.Property(e => e.Code).HasMaxLength(8);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.DateEnd).HasMaxLength(19);

                entity.Property(e => e.DateStart).HasMaxLength(19);

                entity.Property(e => e.DepartmentId).HasMaxLength(36);

                entity.Property(e => e.SalaryGrossMonthly).HasPrecision(18, 6);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employments)
                    .HasForeignKey(d => d.DepartmentId);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employments)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.Employer)
                    .WithMany(p => p.Employments)
                    .HasForeignKey(d => d.EmployerId);
            });

            modelBuilder.Entity<EmploymentTaskType>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.TaskTypeId });

                entity.HasIndex(e => e.TaskTypeId, "IX_EmploymentTaskTypes_TaskTypeId");

                entity.Property(e => e.EmployeeId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmploymentTaskTypes)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.EmploymentTaskTypes)
                    .HasForeignKey(d => d.TaskTypeId);
            });

            modelBuilder.Entity<EnergyCost>(entity =>
            {
                entity.HasKey(e => e.TenantId);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.ElectricityCostKwh)
                    .HasPrecision(18, 6)
                    .HasColumnName("ElectricityCostKWH");

                entity.Property(e => e.FuelCostLt)
                    .HasPrecision(18, 6)
                    .HasColumnName("FuelCostLT");

                entity.Property(e => e.GasCostM3).HasPrecision(18, 6);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<ExpenseCategory>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<ExpenseRecord>(entity =>
            {
                entity.HasIndex(e => e.AssetId, "IX_ExpenseRecords_AssetId");

                entity.HasIndex(e => e.BillPartyId, "IX_ExpenseRecords_BillPartyId");

                entity.HasIndex(e => e.EmployeeId, "IX_ExpenseRecords_EmployeeId");

                entity.HasIndex(e => e.ExpenseRecordGroupId, "IX_ExpenseRecords_ExpenseRecordGroupId");

                entity.HasIndex(e => e.ExpenseTypeId, "IX_ExpenseRecords_ExpenseTypeId");

                entity.HasIndex(e => e.InventoryItemId, "IX_ExpenseRecords_InventoryItemId");

                entity.HasIndex(e => e.ShipmentId, "IX_ExpenseRecords_ShipmentId");

                entity.HasIndex(e => e.TaskActivityId, "IX_ExpenseRecords_TaskActivityId");

                entity.HasIndex(e => e.TaskTypeId, "IX_ExpenseRecords_TaskTypeId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.An)
                    .HasMaxLength(64)
                    .HasColumnName("AN");

                entity.Property(e => e.AssetId).HasMaxLength(36);

                entity.Property(e => e.BillDate).HasMaxLength(25);

                entity.Property(e => e.BillNo).HasMaxLength(36);

                entity.Property(e => e.BillPartyId).HasMaxLength(36);

                entity.Property(e => e.BillPartyName).HasMaxLength(256);

                entity.Property(e => e.BillTypeId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(64);

                entity.Property(e => e.EmployeeId).HasMaxLength(36);

                entity.Property(e => e.ExpenseRecordGroupId).HasMaxLength(36);

                entity.Property(e => e.ExpenseTypeId).HasMaxLength(36);

                entity.Property(e => e.InventoryItemId).HasMaxLength(36);

                entity.Property(e => e.InvoiceFileName).HasMaxLength(128);

                entity.Property(e => e.Price).HasPrecision(18, 6);

                entity.Property(e => e.ProjectId).HasMaxLength(36);

                entity.Property(e => e.ProjectName).HasMaxLength(128);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderTitle).HasMaxLength(64);

                entity.Property(e => e.ShipmentId).HasMaxLength(36);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskActivityId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeTypeId).HasMaxLength(36);

                entity.Property(e => e.TaxRate).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.AssetId);

                entity.HasOne(d => d.BillParty)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.BillPartyId);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.ExpenseRecordGroup)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.ExpenseRecordGroupId);

                entity.HasOne(d => d.ExpenseType)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.ExpenseTypeId);

                entity.HasOne(d => d.InventoryItem)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.InventoryItemId);

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.ShipmentId);

                entity.HasOne(d => d.TaskActivity)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.TaskActivityId);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.ExpenseRecords)
                    .HasForeignKey(d => d.TaskTypeId);
            });

            modelBuilder.Entity<ExpenseRecordGroup>(entity =>
            {
                entity.HasIndex(e => e.EmployeeUserId, "IX_ExpenseRecordGroups_EmployeeUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.EmployeeUserId).HasMaxLength(36);

                entity.Property(e => e.EndDate).HasMaxLength(25);

                entity.Property(e => e.Price).HasPrecision(18, 6);

                entity.Property(e => e.SeqNo).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate).HasMaxLength(25);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.EmployeeUser)
                    .WithMany(p => p.ExpenseRecordGroups)
                    .HasForeignKey(d => d.EmployeeUserId);
            });

            modelBuilder.Entity<ExpenseType>(entity =>
            {
                entity.HasIndex(e => e.ExpenseCategoryId, "IX_ExpenseTypes_ExpenseCategoryId");

                entity.HasIndex(e => e.TaskTypeId, "IX_ExpenseTypes_TaskTypeId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.ExpenseCategoryId).HasMaxLength(36);

                entity.Property(e => e.IntegrationCode).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeTypeId).HasMaxLength(36);

                entity.Property(e => e.TaxRate).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.ExpenseCategory)
                    .WithMany(p => p.ExpenseTypes)
                    .HasForeignKey(d => d.ExpenseCategoryId);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.ExpenseTypes)
                    .HasForeignKey(d => d.TaskTypeId);
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "IX_Facilities_TenantId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AddressBuilding).HasMaxLength(64);

                entity.Property(e => e.AddressCity).HasMaxLength(64);

                entity.Property(e => e.AddressCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("AddressCountryCodeISO3");

                entity.Property(e => e.AddressDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.AddressFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.AddressFloor).HasMaxLength(16);

                entity.Property(e => e.AddressPostalCode).HasMaxLength(16);

                entity.Property(e => e.AddressSite).HasMaxLength(64);

                entity.Property(e => e.AddressState).HasMaxLength(64);

                entity.Property(e => e.AddressStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.AddressStreetNo).HasMaxLength(16);

                entity.Property(e => e.AddressTown).HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.Type).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Facilities)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<FacilityStorage>(entity =>
            {
                entity.HasIndex(e => e.FacilityId, "IX_FacilityStorages_FacilityId");

                entity.HasIndex(e => e.TenantId, "IX_FacilityStorages_TenantId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.FacilityId).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.Note).HasMaxLength(128);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.FacilityStorages)
                    .HasForeignKey(d => d.FacilityId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.FacilityStorages)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<InAppNotification>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_InAppNotifications_CreatedUserId");

                entity.HasIndex(e => e.ToUserId, "IX_InAppNotifications_ToUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.ActionName).HasMaxLength(36);

                entity.Property(e => e.AppServiceName).HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Message).HasMaxLength(128);

                entity.Property(e => e.ResourceUrl).HasMaxLength(256);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.Property(e => e.ToUserId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.Url).HasMaxLength(256);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.InAppNotificationCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.InAppNotificationToUsers)
                    .HasForeignKey(d => d.ToUserId);
            });

            modelBuilder.Entity<InventoryItem>(entity =>
            {
                entity.HasIndex(e => e.FacilityId, "IX_InventoryItems_FacilityId");

                entity.HasIndex(e => e.FacilityStorageId, "IX_InventoryItems_FacilityStorageId");

                entity.HasIndex(e => e.PscategoryId, "IX_InventoryItems_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_InventoryItems_PSId");

                entity.HasIndex(e => e.ProjectId, "IX_InventoryItems_ProjectId");

                entity.HasIndex(e => e.PurchaseOrderId, "IX_InventoryItems_PurchaseOrderId");

                entity.HasIndex(e => e.PurchaseOrderItemId, "IX_InventoryItems_PurchaseOrderItemId");

                entity.HasIndex(e => e.SalesOrderId, "IX_InventoryItems_SalesOrderId");

                entity.HasIndex(e => e.SalesOrderItemId, "IX_InventoryItems_SalesOrderItemId");

                entity.HasIndex(e => e.ShipmentTaskId, "IX_InventoryItems_ShipmentTaskId");

                entity.HasIndex(e => e.StockTaskId, "IX_InventoryItems_StockTaskId");

                entity.HasIndex(e => e.SupplierId, "IX_InventoryItems_SupplierId");

                entity.HasIndex(e => e.TenantId, "IX_InventoryItems_TenantId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.Column).HasMaxLength(16);

                entity.Property(e => e.ConditionId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CustomerName).HasMaxLength(256);

                entity.Property(e => e.Expiration).HasMaxLength(25);

                entity.Property(e => e.FacilityId).HasMaxLength(36);

                entity.Property(e => e.FacilityStorageId).HasMaxLength(36);

                entity.Property(e => e.Floor).HasMaxLength(16);

                entity.Property(e => e.Height)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Length)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LotId).HasMaxLength(36);

                entity.Property(e => e.No).HasMaxLength(16);

                entity.Property(e => e.Note).HasMaxLength(64);

                entity.Property(e => e.ParentId).HasMaxLength(36);

                entity.Property(e => e.ProjectId).HasMaxLength(36);

                entity.Property(e => e.ProjectName).HasMaxLength(128);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.Psn)
                    .HasMaxLength(512)
                    .HasColumnName("PSN");

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(36);

                entity.Property(e => e.PurchaseOrderItemId).HasMaxLength(36);

                entity.Property(e => e.PurchaseUnit).HasMaxLength(36);

                entity.Property(e => e.Received).HasMaxLength(25);

                entity.Property(e => e.Row).HasMaxLength(16);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderItemId).HasMaxLength(36);

                entity.Property(e => e.Section).HasMaxLength(16);

                entity.Property(e => e.Serial).HasMaxLength(36);

                entity.Property(e => e.Shelf).HasMaxLength(16);

                entity.Property(e => e.ShipmentTaskId).HasMaxLength(36);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.StockTaskId).HasMaxLength(36);

                entity.Property(e => e.SupplierBarCode).HasMaxLength(48);

                entity.Property(e => e.SupplierId).HasMaxLength(36);

                entity.Property(e => e.SupplierName).HasMaxLength(256);

                entity.Property(e => e.SupplierQccode)
                    .HasMaxLength(36)
                    .HasColumnName("SupplierQCCode");

                entity.Property(e => e.SupplierQcitemNo)
                    .HasMaxLength(36)
                    .HasColumnName("SupplierQCItemNo");

                entity.Property(e => e.SupplierQcmainNo)
                    .HasMaxLength(36)
                    .HasColumnName("SupplierQCMainNo");

                entity.Property(e => e.SupplierWayBillNo).HasMaxLength(36);

                entity.Property(e => e.TaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.Weight)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeightCase).HasPrecision(18, 6);

                entity.Property(e => e.WeightNet).HasPrecision(18, 6);

                entity.Property(e => e.Width)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.FacilityId);

                entity.HasOne(d => d.FacilityStorage)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.FacilityStorageId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.ProjectId);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.PurchaseOrderId);

                entity.HasOne(d => d.PurchaseOrderItem)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.PurchaseOrderItemId)
                    .HasConstraintName("FK_InventoryItems_ProcurementPurchaseOrderItems_PurchaseOrderIt");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.SalesOrderItem)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(d => d.SalesOrderItemId);

                entity.HasOne(d => d.ShipmentTask)
                    .WithMany(p => p.InventoryItemShipmentTasks)
                    .HasForeignKey(d => d.ShipmentTaskId);

                entity.HasOne(d => d.StockTask)
                    .WithMany(p => p.InventoryItemStockTasks)
                    .HasForeignKey(d => d.StockTaskId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.InventoryItemSuppliers)
                    .HasForeignKey(d => d.SupplierId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.InventoryItemTenants)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<InventoryItemMedia>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.ContentType).HasMaxLength(84);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.InventoryItemId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UsageType).HasMaxLength(36);
            });

            modelBuilder.Entity<InventoryItemTransaction>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_InventoryItemTransactions_CreatedUserId");

                entity.HasIndex(e => e.InventoryItemId, "IX_InventoryItemTransactions_InventoryItemId");

                entity.HasIndex(e => e.TenantId, "IX_InventoryItemTransactions_TenantId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.InventoryItemId).HasMaxLength(36);

                entity.Property(e => e.Note).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.InventoryItemTransactions)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.InventoryItem)
                    .WithMany(p => p.InventoryItemTransactions)
                    .HasForeignKey(d => d.InventoryItemId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.InventoryItemTransactions)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<InventoryPsstockLevelConstraint>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.Psid });

                entity.ToTable("InventoryPSStockLevelConstraints");

                entity.HasIndex(e => e.Psid, "IX_InventoryPSStockLevelConstraints_PSId");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Max).HasPrecision(18, 6);

                entity.Property(e => e.Min).HasPrecision(18, 6);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.Unit).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.InventoryPsstockLevelConstraints)
                    .HasForeignKey(d => d.Psid);
            });

            modelBuilder.Entity<OrganizationDetail>(entity =>
            {
                entity.HasKey(e => e.OrganizationId);

                entity.Property(e => e.OrganizationId).HasMaxLength(36);

                entity.Property(e => e.DateClosed).HasMaxLength(19);

                entity.Property(e => e.DateEstablished).HasMaxLength(19);

                entity.Property(e => e.NameOriginalLanguage).HasMaxLength(256);

                entity.Property(e => e.NameRegisteredTrademark).HasMaxLength(256);

                entity.HasOne(d => d.Organization)
                    .WithOne(p => p.OrganizationDetail)
                    .HasForeignKey<OrganizationDetail>(d => d.OrganizationId);
            });

            modelBuilder.Entity<Party>(entity =>
            {
                entity.ToTable("Party");

                entity.HasIndex(e => e.RegistrarIndustryId, "IX_Party_RegistrarIndustryId");

                entity.HasIndex(e => e.RegistrarTaxId, "IX_Party_RegistrarTaxId");

                entity.HasIndex(e => e.RegistrarTradeCommerceId, "IX_Party_RegistrarTradeCommerceId");

                entity.HasIndex(e => e.UserId, "IX_Party_UserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AccessUrl).HasMaxLength(2048);

                entity.Property(e => e.AddressBuilding).HasMaxLength(64);

                entity.Property(e => e.AddressCity).HasMaxLength(64);

                entity.Property(e => e.AddressCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("AddressCountryCodeISO3");

                entity.Property(e => e.AddressDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.AddressFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.AddressFloor).HasMaxLength(16);

                entity.Property(e => e.AddressPostalCode).HasMaxLength(16);

                entity.Property(e => e.AddressSite).HasMaxLength(64);

                entity.Property(e => e.AddressState).HasMaxLength(64);

                entity.Property(e => e.AddressStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.AddressStreetNo).HasMaxLength(16);

                entity.Property(e => e.AddressTown).HasMaxLength(64);

                entity.Property(e => e.BformContactEmail)
                    .HasMaxLength(256)
                    .HasColumnName("BFormContactEmail");

                entity.Property(e => e.BformContactPhone)
                    .HasMaxLength(36)
                    .HasColumnName("BFormContactPhone");

                entity.Property(e => e.BusinessCentralIdCode).HasMaxLength(16);

                entity.Property(e => e.BusinessIdCode).HasMaxLength(16);

                entity.Property(e => e.CitizenId).HasMaxLength(16);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.CurrentAccountEmail).HasMaxLength(256);

                entity.Property(e => e.CurrentAccountPhone).HasMaxLength(36);

                entity.Property(e => e.DateEnd).HasMaxLength(19);

                entity.Property(e => e.DateStart).HasMaxLength(19);

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.EinvoiceContactEmail)
                    .HasMaxLength(256)
                    .HasColumnName("EInvoiceContactEmail");

                entity.Property(e => e.EinvoiceContactPhone)
                    .HasMaxLength(36)
                    .HasColumnName("EInvoiceContactPhone");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmployerIdCode).HasMaxLength(36);

                entity.Property(e => e.Fax).HasMaxLength(36);

                entity.Property(e => e.IntegrationCode).HasMaxLength(36);

                entity.Property(e => e.LandPhone).HasMaxLength(36);

                entity.Property(e => e.LastName).HasMaxLength(36);

                entity.Property(e => e.MarriageFamilyName).HasMaxLength(36);

                entity.Property(e => e.MidName).HasMaxLength(36);

                entity.Property(e => e.MobilePhone).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.OrganizationSubTypeId).HasMaxLength(64);

                entity.Property(e => e.OrganizationTypeId).HasMaxLength(64);

                entity.Property(e => e.PrimaryLanguageCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("PrimaryLanguageCodeISO3");

                entity.Property(e => e.RegistrarIndustryId).HasMaxLength(36);

                entity.Property(e => e.RegistrarTaxCode).HasMaxLength(36);

                entity.Property(e => e.RegistrarTaxId).HasMaxLength(36);

                entity.Property(e => e.RegistrarTradeCommerceId).HasMaxLength(36);

                entity.Property(e => e.RegistrationIndustryId).HasMaxLength(16);

                entity.Property(e => e.RegistrationTaxId).HasMaxLength(16);

                entity.Property(e => e.RegistrationTradeCommerceId).HasMaxLength(16);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.Title).HasMaxLength(256);

                entity.Property(e => e.Type).HasMaxLength(64);

                entity.Property(e => e.UniversalId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.Property(e => e.WebSiteUrl).HasMaxLength(1024);

                entity.HasOne(d => d.RegistrarIndustry)
                    .WithMany(p => p.InverseRegistrarIndustry)
                    .HasForeignKey(d => d.RegistrarIndustryId);

                entity.HasOne(d => d.RegistrarTax)
                    .WithMany(p => p.InverseRegistrarTax)
                    .HasForeignKey(d => d.RegistrarTaxId);

                entity.HasOne(d => d.RegistrarTradeCommerce)
                    .WithMany(p => p.InverseRegistrarTradeCommerce)
                    .HasForeignKey(d => d.RegistrarTradeCommerceId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Parties)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<PlannedOfferForm>(entity =>
            {
                entity.ToTable("PlannedOfferForm");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CasualtyRate).HasDefaultValueSql("0.96");

                entity.Property(e => e.CustomerCity).HasMaxLength(36);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName).HasMaxLength(36);

                entity.Property(e => e.ExchangeRate).HasMaxLength(19);

                entity.Property(e => e.InstallationTotalCost).HasColumnName("InstallationTotalCost ");

                entity.Property(e => e.IsgexpertCost).HasColumnName("ISGExpertCost");

                entity.Property(e => e.RentedEquipmentId).HasMaxLength(36);

                entity.Property(e => e.RentedEquipmentName).HasMaxLength(36);

                entity.Property(e => e.RevisionNumber).HasColumnType("character varying");

                entity.Property(e => e.SalesOfferNumber).HasColumnType("character varying");

                entity.Property(e => e.StaffMealTotalPrice).HasColumnName("StaffMealTotalPrice ");

                entity.Property(e => e.StaffMealUnitPrice).HasColumnName("StaffMealUnitPrice ");

                entity.Property(e => e.TotalCarFuelCost).HasColumnName("TotalCarFuelCost ");
            });

            modelBuilder.Entity<Plannedrealizedrelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("plannedrealizedrelation");

                entity.Property(e => e.PlannedofferformId).HasColumnName("plannedofferform_id");

                entity.Property(e => e.RealizedofferformId).HasColumnName("realizedofferform_id");
            });

            modelBuilder.Entity<ProcurementPurchaseOrder>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_ProcurementPurchaseOrders_CreatedUserId");

                entity.HasIndex(e => e.ProcurementRfqbidId, "IX_ProcurementPurchaseOrders_ProcurementRFQBidId");

                entity.HasIndex(e => e.ProcurementRfqid, "IX_ProcurementPurchaseOrders_ProcurementRFQId");

                entity.HasIndex(e => e.SupplierId, "IX_ProcurementPurchaseOrders_SupplierId");

                entity.HasIndex(e => e.TenantId, "IX_ProcurementPurchaseOrders_TenantId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.DescriptionPurchaseOrder).HasMaxLength(128);

                entity.Property(e => e.DocumentName).HasMaxLength(64);

                entity.Property(e => e.ProcurementRfqbidId)
                    .HasMaxLength(36)
                    .HasColumnName("ProcurementRFQBidId");

                entity.Property(e => e.ProcurementRfqid)
                    .HasMaxLength(36)
                    .HasColumnName("ProcurementRFQId");

                entity.Property(e => e.PurposePurchaseOrder).HasMaxLength(128);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.SupplierId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ProcurementPurchaseOrders)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.ProcurementRfqbid)
                    .WithMany(p => p.ProcurementPurchaseOrders)
                    .HasForeignKey(d => d.ProcurementRfqbidId)
                    .HasConstraintName("FK_ProcurementPurchaseOrders_ProcurementRFQBids_ProcurementRFQB");

                entity.HasOne(d => d.ProcurementRfq)
                    .WithMany(p => p.ProcurementPurchaseOrders)
                    .HasForeignKey(d => d.ProcurementRfqid);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProcurementPurchaseOrderSuppliers)
                    .HasForeignKey(d => d.SupplierId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ProcurementPurchaseOrderTenants)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<ProcurementPurchaseOrderItem>(entity =>
            {
                entity.HasIndex(e => e.PscategoryId, "IX_ProcurementPurchaseOrderItems_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_ProcurementPurchaseOrderItems_PSId");

                entity.HasIndex(e => e.ProcurementPurchaseOrderId, "IX_ProcurementPurchaseOrderItems_ProcurementPurchaseOrderId");

                entity.HasIndex(e => e.ProcurementRfqbidItemId, "IX_ProcurementPurchaseOrderItems_ProcurementRFQBidItemId");

                entity.HasIndex(e => e.ProcurementRequestId, "IX_ProcurementPurchaseOrderItems_ProcurementRequestId");

                entity.HasIndex(e => e.SupplierId, "IX_ProcurementPurchaseOrderItems_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AmountOrder).HasPrecision(18, 6);

                entity.Property(e => e.AmountOrderRemaining).HasPrecision(18, 6);

                entity.Property(e => e.BrandName).HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CustomerName).HasMaxLength(256);

                entity.Property(e => e.DeadlineDateRequest).HasMaxLength(19);

                entity.Property(e => e.DeliveryAddress).HasMaxLength(128);

                entity.Property(e => e.DeliveryDatePossible).HasMaxLength(19);

                entity.Property(e => e.DescriptionPurchaseOrderItem).HasMaxLength(128);

                entity.Property(e => e.Model).HasMaxLength(64);

                entity.Property(e => e.ProcurementPurchaseOrderId).HasMaxLength(36);

                entity.Property(e => e.ProcurementRequestId).HasMaxLength(36);

                entity.Property(e => e.ProcurementRfqbidId)
                    .HasMaxLength(36)
                    .HasColumnName("ProcurementRFQBidId");

                entity.Property(e => e.ProcurementRfqbidItemId)
                    .HasMaxLength(36)
                    .HasColumnName("ProcurementRFQBidItemId");

                entity.Property(e => e.ProcurementRfqid)
                    .HasMaxLength(36)
                    .HasColumnName("ProcurementRFQId");

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.Psn)
                    .HasMaxLength(512)
                    .HasColumnName("PSN");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(36);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.SupplierId).HasMaxLength(36);

                entity.Property(e => e.SupplierName).HasMaxLength(256);

                entity.Property(e => e.TaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UnitPriceDiscounted).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.ProcurementPurchaseOrder)
                    .WithMany(p => p.ProcurementPurchaseOrderItems)
                    .HasForeignKey(d => d.ProcurementPurchaseOrderId)
                    .HasConstraintName("FK_ProcurementPurchaseOrderItems_ProcurementPurchaseOrders_Proc");

                entity.HasOne(d => d.ProcurementRequest)
                    .WithMany(p => p.ProcurementPurchaseOrderItems)
                    .HasForeignKey(d => d.ProcurementRequestId)
                    .HasConstraintName("FK_ProcurementPurchaseOrderItems_ProcurementRequests_Procuremen");

                entity.HasOne(d => d.ProcurementRfqbidItem)
                    .WithMany(p => p.ProcurementPurchaseOrderItems)
                    .HasForeignKey(d => d.ProcurementRfqbidItemId)
                    .HasConstraintName("FK_ProcurementPurchaseOrderItems_ProcurementRFQBidItems_Procure");

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.ProcurementPurchaseOrderItems)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.ProcurementPurchaseOrderItems)
                    .HasForeignKey(d => d.Psid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProcurementPurchaseOrderItems)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<ProcurementPurchaseOrderWayBillDocument>(entity =>
            {
                entity.ToTable("ProcurementPurchaseOrderWayBillDocument");

                entity.HasIndex(e => e.ProcurementPurchaseOrderId, "IX_ProcurementPurchaseOrderWayBillDocument_ProcurementPurchaseO");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.ProcurementPurchaseOrderId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.WayBillNumber).HasMaxLength(36);

                entity.HasOne(d => d.ProcurementPurchaseOrder)
                    .WithMany(p => p.ProcurementPurchaseOrderWayBillDocuments)
                    .HasForeignKey(d => d.ProcurementPurchaseOrderId)
                    .HasConstraintName("FK_ProcurementPurchaseOrderWayBillDocument_ProcurementPurchaseO");
            });

            modelBuilder.Entity<ProcurementRequest>(entity =>
            {
                entity.HasIndex(e => e.ApprovedUserId, "IX_ProcurementRequests_ApprovedUserId");

                entity.HasIndex(e => e.CanceledUserId, "IX_ProcurementRequests_CanceledUserId");

                entity.HasIndex(e => e.CreatedUserId, "IX_ProcurementRequests_CreatedUserId");

                entity.HasIndex(e => e.CustomerId, "IX_ProcurementRequests_CustomerId");

                entity.HasIndex(e => e.PscategoryId, "IX_ProcurementRequests_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_ProcurementRequests_PSId");

                entity.HasIndex(e => e.RejectedUserId, "IX_ProcurementRequests_RejectedUserId");

                entity.HasIndex(e => e.SalesOrderId, "IX_ProcurementRequests_SalesOrderId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_ProcurementRequests_UpdatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AddressRequest).HasMaxLength(128);

                entity.Property(e => e.AmountRequest).HasPrecision(18, 6);

                entity.Property(e => e.AmountRequestRemaining).HasPrecision(18, 6);

                entity.Property(e => e.ApprovedDate).HasMaxLength(19);

                entity.Property(e => e.ApprovedUserId).HasMaxLength(36);

                entity.Property(e => e.CanceledDate).HasMaxLength(19);

                entity.Property(e => e.CanceledUserId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName).HasMaxLength(256);

                entity.Property(e => e.DeadlineDateRequest).HasMaxLength(19);

                entity.Property(e => e.DescriptionRequest).HasMaxLength(128);

                entity.Property(e => e.ProjectOrderId).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.Purpose).HasMaxLength(36);

                entity.Property(e => e.RejectedDate).HasMaxLength(19);

                entity.Property(e => e.RejectedUserId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.ApprovedUser)
                    .WithMany(p => p.ProcurementRequestApprovedUsers)
                    .HasForeignKey(d => d.ApprovedUserId);

                entity.HasOne(d => d.CanceledUser)
                    .WithMany(p => p.ProcurementRequestCanceledUsers)
                    .HasForeignKey(d => d.CanceledUserId);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ProcurementRequestCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProcurementRequests)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.ProcurementRequests)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.ProcurementRequests)
                    .HasForeignKey(d => d.Psid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RejectedUser)
                    .WithMany(p => p.ProcurementRequestRejectedUsers)
                    .HasForeignKey(d => d.RejectedUserId);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.ProcurementRequests)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.ProcurementRequestUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);
            });

            modelBuilder.Entity<ProcurementRequestMedia>(entity =>
            {
                entity.HasIndex(e => e.ProcurementRequestId, "IX_ProcurementRequestMedias_ProcurementRequestId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.ContentType).HasMaxLength(84);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.ProcurementRequestId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UsageType).HasMaxLength(36);

                entity.HasOne(d => d.ProcurementRequest)
                    .WithMany(p => p.ProcurementRequestMedia)
                    .HasForeignKey(d => d.ProcurementRequestId)
                    .HasConstraintName("FK_ProcurementRequestMedias_ProcurementRequests_ProcurementRequ");
            });

            modelBuilder.Entity<ProcurementRfq>(entity =>
            {
                entity.ToTable("ProcurementRFQs");

                entity.HasIndex(e => e.CreatedUserId, "IX_ProcurementRFQs_CreatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.DeadlineDateRfq)
                    .HasMaxLength(19)
                    .HasColumnName("DeadlineDateRFQ");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.DocumentName).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ProcurementRfqs)
                    .HasForeignKey(d => d.CreatedUserId);
            });

            modelBuilder.Entity<ProcurementRfqbid>(entity =>
            {
                entity.ToTable("ProcurementRFQBids");

                entity.HasIndex(e => e.CreatedUserId, "IX_ProcurementRFQBids_CreatedUserId");

                entity.HasIndex(e => e.ProcurementRfqid, "IX_ProcurementRFQBids_ProcurementRFQId");

                entity.HasIndex(e => e.SupplierId, "IX_ProcurementRFQBids_SupplierId");

                entity.HasIndex(e => e.TenantId, "IX_ProcurementRFQBids_TenantId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AccessCode).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.DeadlineDateRfqbid)
                    .HasMaxLength(19)
                    .HasColumnName("DeadlineDateRFQBid");

                entity.Property(e => e.DescriptionRfqbid)
                    .HasMaxLength(4096)
                    .HasColumnName("DescriptionRFQBid");

                entity.Property(e => e.DocumentName).HasMaxLength(64);

                entity.Property(e => e.DocumentPurchaseContractName).HasMaxLength(64);

                entity.Property(e => e.PaymentAfterDeliveryPrice).HasPrecision(18, 6);

                entity.Property(e => e.PaymentAfterInvoicePrice).HasPrecision(18, 6);

                entity.Property(e => e.PaymentAfterOrderPrice).HasPrecision(18, 6);

                entity.Property(e => e.PaymentMethodType).HasMaxLength(36);

                entity.Property(e => e.PaymentMilestonePrice).HasPrecision(18, 6);

                entity.Property(e => e.PaymentModelType).HasMaxLength(36);

                entity.Property(e => e.PriceDiscount).HasPrecision(18, 6);

                entity.Property(e => e.PriceProductServiceTotal).HasPrecision(18, 6);

                entity.Property(e => e.PriceShipment).HasPrecision(18, 6);

                entity.Property(e => e.PriceTotal).HasPrecision(18, 6);

                entity.Property(e => e.ProcurementRfqid)
                    .HasMaxLength(36)
                    .HasColumnName("ProcurementRFQId");

                entity.Property(e => e.ProviderPersonEmail).HasMaxLength(256);

                entity.Property(e => e.ProviderPersonFirstName).HasMaxLength(36);

                entity.Property(e => e.ProviderPersonLastName).HasMaxLength(36);

                entity.Property(e => e.ProviderPersonPosition).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.SupplierId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.ValidityDeadlineDate).HasMaxLength(19);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ProcurementRfqbids)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.ProcurementRfq)
                    .WithMany(p => p.ProcurementRfqbids)
                    .HasForeignKey(d => d.ProcurementRfqid);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProcurementRfqbidSuppliers)
                    .HasForeignKey(d => d.SupplierId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ProcurementRfqbidTenants)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<ProcurementRfqbidItem>(entity =>
            {
                entity.ToTable("ProcurementRFQBidItems");

                entity.HasIndex(e => e.PscategoryId, "IX_ProcurementRFQBidItems_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_ProcurementRFQBidItems_PSId");

                entity.HasIndex(e => e.ProcurementRfqbidId, "IX_ProcurementRFQBidItems_ProcurementRFQBidId");

                entity.HasIndex(e => e.ProcurementRequestId, "IX_ProcurementRFQBidItems_ProcurementRequestId");

                entity.HasIndex(e => e.SupplierId, "IX_ProcurementRFQBidItems_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AmountAvailable).HasPrecision(18, 6);

                entity.Property(e => e.BrandName).HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(128);

                entity.Property(e => e.DeliveryDatePossible).HasMaxLength(19);

                entity.Property(e => e.DescriptionRfqbidItem)
                    .HasMaxLength(256)
                    .HasColumnName("DescriptionRFQBidItem");

                entity.Property(e => e.Model).HasMaxLength(64);

                entity.Property(e => e.PaymentMethodType).HasMaxLength(36);

                entity.Property(e => e.PaymentModelType).HasMaxLength(36);

                entity.Property(e => e.ProcurementRequestId).HasMaxLength(36);

                entity.Property(e => e.ProcurementRfqbidId)
                    .HasMaxLength(36)
                    .HasColumnName("ProcurementRFQBidId");

                entity.Property(e => e.ProcurementRfqid)
                    .HasMaxLength(36)
                    .HasColumnName("ProcurementRFQId");

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.SupplierId).HasMaxLength(36);

                entity.Property(e => e.TaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.ValidityDeadlineDate).HasMaxLength(19);

                entity.HasOne(d => d.ProcurementRequest)
                    .WithMany(p => p.ProcurementRfqbidItems)
                    .HasForeignKey(d => d.ProcurementRequestId)
                    .HasConstraintName("FK_ProcurementRFQBidItems_ProcurementRequests_ProcurementReques");

                entity.HasOne(d => d.ProcurementRfqbid)
                    .WithMany(p => p.ProcurementRfqbidItems)
                    .HasForeignKey(d => d.ProcurementRfqbidId)
                    .HasConstraintName("FK_ProcurementRFQBidItems_ProcurementRFQBids_ProcurementRFQBidI");

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.ProcurementRfqbidItems)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.ProcurementRfqbidItems)
                    .HasForeignKey(d => d.Psid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProcurementRfqbidItems)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<ProcurementUserNotificationSetting>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.UserId });

                entity.HasIndex(e => e.UserId, "IX_ProcurementUserNotificationSettings_UserId");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.Property(e => e.RfqbidProvided).HasColumnName("RFQBidProvided");

                entity.Property(e => e.RfqbidRequested).HasColumnName("RFQBidRequested");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ProcurementUserNotificationSettings)
                    .HasForeignKey(d => d.TenantId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcurementUserNotificationSettings)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasIndex(e => e.SalesOrderId, "IX_Projects_SalesOrderId");

                entity.HasIndex(e => e.TenantId, "IX_Projects_TenantId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Acost)
                    .HasPrecision(18, 6)
                    .HasColumnName("ACost");

                entity.Property(e => e.Aduration).HasColumnName("ADuration");

                entity.Property(e => e.Aend)
                    .HasMaxLength(25)
                    .HasColumnName("AEnd");

                entity.Property(e => e.Astart)
                    .HasMaxLength(25)
                    .HasColumnName("AStart");

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Pcost)
                    .HasPrecision(18, 6)
                    .HasColumnName("PCost");

                entity.Property(e => e.Pduration).HasColumnName("PDuration");

                entity.Property(e => e.Pend)
                    .HasMaxLength(25)
                    .HasColumnName("PEnd");

                entity.Property(e => e.Pstart)
                    .HasMaxLength(25)
                    .HasColumnName("PStart");

                entity.Property(e => e.RevParty).HasMaxLength(36);

                entity.Property(e => e.RevReason).HasMaxLength(36);

                entity.Property(e => e.RevType).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<Pscategory>(entity =>
            {
                entity.ToTable("PSCategories");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.IntegrationCode).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.PstypeDiscriminator)
                    .HasMaxLength(64)
                    .HasColumnName("PSTypeDiscriminator");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(36);

                entity.Property(e => e.PurchaseUnitSecondary).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UnitCc)
                    .HasPrecision(18, 6)
                    .HasColumnName("UnitCC");

                entity.Property(e => e.UniversalId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<PscategoryMedia>(entity =>
            {
                entity.ToTable("PSCategoryMedias");

                entity.HasIndex(e => e.PscategoryId, "IX_PSCategoryMedias_PSCategoryId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.ContentType).HasMaxLength(84);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UsageType).HasMaxLength(36);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.PscategoryMedia)
                    .HasForeignKey(d => d.PscategoryId);
            });

            modelBuilder.Entity<PscategoryQccode>(entity =>
            {
                entity.ToTable("PSCategoryQCCodes");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<PscategoryQcmeasurementParameter>(entity =>
            {
                entity.ToTable("PSCategoryQCMeasurementParameters");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(64);

                entity.Property(e => e.Instructions).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UnitId).HasMaxLength(16);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<PscategoryQcmeasurementParameterMedia>(entity =>
            {
                entity.ToTable("PSCategoryQCMeasurementParameterMedias");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.ContentType).HasMaxLength(84);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UsageType).HasMaxLength(36);
            });

            modelBuilder.Entity<PscategoryTaskType>(entity =>
            {
                entity.ToTable("PSCategoryTaskTypes");

                entity.HasIndex(e => e.PsfeatureId, "IX_PSCategoryTaskTypes_PSFeatureId");

                entity.HasIndex(e => e.TaskTypeId, "IX_PSCategoryTaskTypes_TaskTypeId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Condition).HasMaxLength(2);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.PsfeatureId)
                    .HasMaxLength(36)
                    .HasColumnName("PSFeatureId");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.Value).HasMaxLength(64);

                entity.HasOne(d => d.Psfeature)
                    .WithMany(p => p.PscategoryTaskTypes)
                    .HasForeignKey(d => d.PsfeatureId);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.PscategoryTaskTypes)
                    .HasForeignKey(d => d.TaskTypeId);
            });

            modelBuilder.Entity<Pscomponent>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.Psid, e.ComponentId });

                entity.ToTable("PSComponents");

                entity.HasIndex(e => e.ComponentId, "IX_PSComponents_ComponentId");

                entity.HasIndex(e => e.Psid, "IX_PSComponents_PSId");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.ComponentId).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TypeId).HasMaxLength(16);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.PscomponentComponents)
                    .HasForeignKey(d => d.ComponentId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.PscomponentPs)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Pscomponents)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<PscomponentTaskTypeExclude>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.Psid, e.TaskTypeId });

                entity.ToTable("PSComponentTaskTypeExcludes");

                entity.HasIndex(e => e.Psid, "IX_PSComponentTaskTypeExcludes_PSId");

                entity.HasIndex(e => e.TaskTypeId, "IX_PSComponentTaskTypeExcludes_TaskTypeId");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.PscomponentTaskTypeExcludes)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.PscomponentTaskTypeExcludes)
                    .HasForeignKey(d => d.TaskTypeId);
            });

            modelBuilder.Entity<Psfeature>(entity =>
            {
                entity.ToTable("PSFeatures");

                entity.HasIndex(e => e.PscategoryId, "IX_PSFeatures_PSCategoryId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.DataType).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(64);

                entity.Property(e => e.Max).HasPrecision(18, 6);

                entity.Property(e => e.Min).HasPrecision(18, 6);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.ShowInNameForCustomer)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.Step).HasPrecision(18, 6);

                entity.Property(e => e.UnitId).HasMaxLength(16);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.ValueType).HasMaxLength(36);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.Psfeatures)
                    .HasForeignKey(d => d.PscategoryId);
            });

            modelBuilder.Entity<PsfeatureValue>(entity =>
            {
                entity.HasKey(e => new { e.Psid, e.PsfeatureId });

                entity.ToTable("PSFeatureValues");

                entity.HasIndex(e => e.PsfeatureId, "IX_PSFeatureValues_PSFeatureId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.PsfeatureId)
                    .HasMaxLength(36)
                    .HasColumnName("PSFeatureId");

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.Value).HasMaxLength(64);

                entity.HasOne(d => d.Psfeature)
                    .WithMany(p => p.PsfeatureValues)
                    .HasForeignKey(d => d.PsfeatureId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.PsfeatureValues)
                    .HasForeignKey(d => d.Psid);
            });

            modelBuilder.Entity<Psmedia>(entity =>
            {
                entity.ToTable("PSMedias");

                entity.HasIndex(e => e.Psid, "IX_PSMedias_PSId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.ContentType).HasMaxLength(84);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UsageType).HasMaxLength(36);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.Psmedia)
                    .HasForeignKey(d => d.Psid);
            });

            modelBuilder.Entity<Psprice>(entity =>
            {
                entity.ToTable("PSPrices");

                entity.HasIndex(e => e.CustomerId, "IX_PSPrices_CustomerId");

                entity.HasIndex(e => e.SellerId, "IX_PSPrices_SellerId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.ChannelId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.SellerId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PspriceCustomers)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.Psprices)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.PspriceSellers)
                    .HasForeignKey(d => d.SellerId);
            });

            modelBuilder.Entity<PspriceEnterRequest>(entity =>
            {
                entity.ToTable("PSPriceEnterRequests");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.Psname)
                    .HasMaxLength(512)
                    .HasColumnName("PSName");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<Pss>(entity =>
            {
                entity.ToTable("PSs");

                entity.HasIndex(e => e.BrandId, "IX_PSs_BrandId");

                entity.HasIndex(e => e.ManufacturerId, "IX_PSs_ManufacturerId");

                entity.HasIndex(e => e.NameEntsVector, "IX_PSs_NameENTsVector")
                    .HasMethod("gin");

                entity.HasIndex(e => e.PscategoryId, "IX_PSs_PSCategoryId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AmountSecondUnit).HasPrecision(18, 6);

                entity.Property(e => e.BrandId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.DescriptionShort).HasMaxLength(512);

                entity.Property(e => e.Gtin)
                    .HasMaxLength(36)
                    .HasColumnName("GTIN");

                entity.Property(e => e.Height)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Length)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManufacturerId).HasMaxLength(36);

                entity.Property(e => e.ManufacturerPscode)
                    .HasMaxLength(36)
                    .HasColumnName("ManufacturerPSCode");

                entity.Property(e => e.ModelCode).HasMaxLength(64);

                entity.Property(e => e.ModelName).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(512);

                entity.Property(e => e.NameEn)
                    .HasMaxLength(512)
                    .HasColumnName("NameEN");

                entity.Property(e => e.NameEntsVector).HasColumnName("NameENTsVector");

                entity.Property(e => e.ProductionEndDate).HasMaxLength(19);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.PstypeDiscriminator)
                    .HasMaxLength(64)
                    .HasColumnName("PSTypeDiscriminator");

                entity.Property(e => e.ReleaseDate).HasMaxLength(19);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.SupportEndDate).HasMaxLength(19);

                entity.Property(e => e.Tags).HasMaxLength(512);

                entity.Property(e => e.UniversalId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UrlApi).HasMaxLength(2048);

                entity.Property(e => e.UrlLargeImage).HasMaxLength(2048);

                entity.Property(e => e.UrlMediumImage).HasMaxLength(2048);

                entity.Property(e => e.UrlMobile).HasMaxLength(2048);

                entity.Property(e => e.UrlSmallImage).HasMaxLength(2048);

                entity.Property(e => e.UrlWeb).HasMaxLength(2048);

                entity.Property(e => e.Weight)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeightNet)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Width)
                    .HasPrecision(18, 6)
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Psses)
                    .HasForeignKey(d => d.BrandId);

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Psses)
                    .HasForeignKey(d => d.ManufacturerId);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.Psses)
                    .HasForeignKey(d => d.PscategoryId);
            });

            modelBuilder.Entity<QualityAssuranceStandard>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.WebSiteUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<RealizedOfferForm>(entity =>
            {
                entity.ToTable("RealizedOfferForm");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CasualtyRate).HasDefaultValueSql("0.96");

                entity.Property(e => e.CustomerCity).HasMaxLength(36);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName).HasMaxLength(36);

                entity.Property(e => e.ExchangeRate).HasMaxLength(18);

                entity.Property(e => e.InstallationTotalCost).HasColumnName("InstallationTotalCost ");

                entity.Property(e => e.IsgexpertCost).HasColumnName("ISGExpertCost");

                entity.Property(e => e.RentedEquipmentId).HasMaxLength(36);

                entity.Property(e => e.RentedEquipmentName).HasMaxLength(36);

                entity.Property(e => e.SalesOfferNumber).HasMaxLength(18);

                entity.Property(e => e.StaffMealTotalPrice).HasColumnName("StaffMealTotalPrice ");

                entity.Property(e => e.StaffMealUnitPrice).HasColumnName("StaffMealUnitPrice ");

                entity.Property(e => e.TotalCarFuelCost).HasColumnName("TotalCarFuelCost ");
            });

            modelBuilder.Entity<RelationCustomer>(entity =>
            {
                entity.HasKey(e => new { e.PartyId, e.CustomerId });

                entity.HasIndex(e => e.CustomerId, "IX_RelationCustomers_CustomerId");

                entity.HasIndex(e => e.ReferenceId, "IX_RelationCustomers_ReferenceId");

                entity.Property(e => e.PartyId).HasMaxLength(36);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.AcquisitionChannelId).HasMaxLength(36);

                entity.Property(e => e.AcquisitionChannelName).HasMaxLength(64);

                entity.Property(e => e.AcquisitionChannelType).HasMaxLength(36);

                entity.Property(e => e.ActualEndDate).HasMaxLength(10);

                entity.Property(e => e.ContractDate).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.CurrencyContract).HasMaxLength(3);

                entity.Property(e => e.CurrencyOffer).HasMaxLength(3);

                entity.Property(e => e.PlannedEndDate).HasMaxLength(10);

                entity.Property(e => e.ReferenceId).HasMaxLength(36);

                entity.Property(e => e.RelationBreakReason).HasMaxLength(36);

                entity.Property(e => e.StartDate).HasMaxLength(10);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RelationCustomerCustomers)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.RelationCustomerParties)
                    .HasForeignKey(d => d.PartyId);

                entity.HasOne(d => d.Reference)
                    .WithMany(p => p.RelationCustomerReferences)
                    .HasForeignKey(d => d.ReferenceId);
            });

            modelBuilder.Entity<RelationCustomerContactPerson>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.CustomerId, e.ContactId });

                entity.HasIndex(e => e.ContactId, "IX_RelationCustomerContactPersons_ContactId");

                entity.HasIndex(e => e.CustomerId, "IX_RelationCustomerContactPersons_CustomerId");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.ContactId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.RelationCustomerContactPersonContacts)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RelationCustomerContactPersonCustomers)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.RelationCustomerContactPersonTenants)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<RelationPartyQascertificate>(entity =>
            {
                entity.ToTable("RelationPartyQASCertificates");

                entity.HasIndex(e => e.AccreditorId, "IX_RelationPartyQASCertificates_AccreditorId");

                entity.HasIndex(e => e.PartyId, "IX_RelationPartyQASCertificates_PartyId");

                entity.HasIndex(e => e.RegistrarId, "IX_RelationPartyQASCertificates_RegistrarId");

                entity.HasIndex(e => e.StandardId, "IX_RelationPartyQASCertificates_StandardId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AccreditorId).HasMaxLength(36);

                entity.Property(e => e.CertificateId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.EndDate).HasMaxLength(19);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PartyId).HasMaxLength(36);

                entity.Property(e => e.PublicationDate).HasMaxLength(19);

                entity.Property(e => e.RegistrarId).HasMaxLength(36);

                entity.Property(e => e.ScopeEnglish).HasMaxLength(1024);

                entity.Property(e => e.ScopePrimaryLanguage).HasMaxLength(1024);

                entity.Property(e => e.StandardId).HasMaxLength(36);

                entity.Property(e => e.StartedDate).HasMaxLength(19);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Accreditor)
                    .WithMany(p => p.RelationPartyQascertificateAccreditors)
                    .HasForeignKey(d => d.AccreditorId);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.RelationPartyQascertificateParties)
                    .HasForeignKey(d => d.PartyId);

                entity.HasOne(d => d.Registrar)
                    .WithMany(p => p.RelationPartyQascertificateRegistrars)
                    .HasForeignKey(d => d.RegistrarId);

                entity.HasOne(d => d.Standard)
                    .WithMany(p => p.RelationPartyQascertificates)
                    .HasForeignKey(d => d.StandardId)
                    .HasConstraintName("FK_RelationPartyQASCertificates_QualityAssuranceStandards_Stand");
            });

            modelBuilder.Entity<RelationPartyRegistry>(entity =>
            {
                entity.HasKey(e => new { e.PartyId, e.RegistrarId });

                entity.HasIndex(e => e.RegistrarId, "IX_RelationPartyRegistries_RegistrarId");

                entity.Property(e => e.PartyId).HasMaxLength(36);

                entity.Property(e => e.RegistrarId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.RegistrarCode).HasMaxLength(16);

                entity.Property(e => e.RegistrationIdCode).HasMaxLength(16);

                entity.Property(e => e.RegistrationValidatedUserId).HasMaxLength(36);

                entity.Property(e => e.RegistrationValidationDate).HasMaxLength(19);

                entity.Property(e => e.RegistrationValidationMethod).HasMaxLength(36);

                entity.Property(e => e.RegistrationValidationUrl).HasMaxLength(1024);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.RelationPartyRegistryParties)
                    .HasForeignKey(d => d.PartyId);

                entity.HasOne(d => d.Registrar)
                    .WithMany(p => p.RelationPartyRegistryRegistrars)
                    .HasForeignKey(d => d.RegistrarId);
            });

            modelBuilder.Entity<RelationPartySupplier>(entity =>
            {
                entity.HasKey(e => new { e.PartyId, e.SupplierId });

                entity.HasIndex(e => e.SupplierId, "IX_RelationPartySuppliers_SupplierId");

                entity.Property(e => e.PartyId).HasMaxLength(36);

                entity.Property(e => e.SupplierId).HasMaxLength(36);

                entity.Property(e => e.ActualEndDate).HasMaxLength(10);

                entity.Property(e => e.ContractDate).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.PlannedEndDate).HasMaxLength(10);

                entity.Property(e => e.RelationBreakReason).HasMaxLength(36);

                entity.Property(e => e.ScoreRfqparticipationRate).HasColumnName("ScoreRFQParticipationRate");

                entity.Property(e => e.StartDate).HasMaxLength(10);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.RelationPartySupplierParties)
                    .HasForeignKey(d => d.PartyId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.RelationPartySupplierSuppliers)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<RelationReseller>(entity =>
            {
                entity.HasKey(e => new { e.PartyId, e.ResellerId });

                entity.HasIndex(e => e.ResellerId, "IX_RelationResellers_ResellerId");

                entity.Property(e => e.PartyId).HasMaxLength(36);

                entity.Property(e => e.ResellerId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.RelationResellerParties)
                    .HasForeignKey(d => d.PartyId);

                entity.HasOne(d => d.Reseller)
                    .WithMany(p => p.RelationResellerResellers)
                    .HasForeignKey(d => d.ResellerId);
            });

            modelBuilder.Entity<RelationResellerContactPerson>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.ResellerId, e.ContactId });

                entity.HasIndex(e => e.ContactId, "IX_RelationResellerContactPersons_ContactId");

                entity.HasIndex(e => e.ResellerId, "IX_RelationResellerContactPersons_ResellerId");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.ResellerId).HasMaxLength(36);

                entity.Property(e => e.ContactId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.RelationResellerContactPersonContacts)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.Reseller)
                    .WithMany(p => p.RelationResellerContactPersonResellers)
                    .HasForeignKey(d => d.ResellerId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.RelationResellerContactPersonTenants)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<RelationSupplierPscategory>(entity =>
            {
                entity.HasKey(e => new { e.SupplierId, e.PscategoryId });

                entity.ToTable("RelationSupplierPSCategories");

                entity.HasIndex(e => e.PscategoryId, "IX_RelationSupplierPSCategories_PSCategoryId");

                entity.Property(e => e.SupplierId).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.RelationSupplierPscategories)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.RelationSupplierPscategories)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<RelationSupplierSalesPerson>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.SupplierId, e.EmployeeId });

                entity.HasIndex(e => e.EmployeeId, "IX_RelationSupplierSalesPersons_EmployeeId");

                entity.HasIndex(e => e.SupplierId, "IX_RelationSupplierSalesPersons_SupplierId");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.SupplierId).HasMaxLength(36);

                entity.Property(e => e.EmployeeId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.RelationSupplierSalesPersonEmployees)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.RelationSupplierSalesPersonSuppliers)
                    .HasForeignKey(d => d.SupplierId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.RelationSupplierSalesPersonTenants)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<ReminderNotificationLog>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.NotificationToUserId).HasMaxLength(36);

                entity.Property(e => e.NotificationTypeId).HasMaxLength(36);

                entity.Property(e => e.ReminderTypeId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<RentedEquipment>(entity =>
            {
                entity.ToTable("RentedEquipment");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.DailyCost).HasPrecision(18, 6);

                entity.Property(e => e.MonthlyCost).HasPrecision(18, 6);

                entity.Property(e => e.Name).HasMaxLength(36);

                entity.Property(e => e.TotalCost).HasPrecision(18, 6);
            });

            modelBuilder.Entity<SalesCustomerMeetingForm>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_SalesCustomerMeetingForms_CreatedUserId");

                entity.HasIndex(e => e.CustomerContactPersonId, "IX_SalesCustomerMeetingForms_CustomerContactPersonId");

                entity.HasIndex(e => e.CustomerId, "IX_SalesCustomerMeetingForms_CustomerId");

                entity.HasIndex(e => e.PscategoryId, "IX_SalesCustomerMeetingForms_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_SalesCustomerMeetingForms_PSId");

                entity.HasIndex(e => e.ProjectManagerUserId, "IX_SalesCustomerMeetingForms_ProjectManagerUserId");

                entity.HasIndex(e => e.ResellerContactPersonId, "IX_SalesCustomerMeetingForms_ResellerContactPersonId");

                entity.HasIndex(e => e.ResellerId, "IX_SalesCustomerMeetingForms_ResellerId");

                entity.HasIndex(e => e.SalesManagerUserId, "IX_SalesCustomerMeetingForms_SalesManagerUserId");

                entity.HasIndex(e => e.SalesPersonUserId, "IX_SalesCustomerMeetingForms_SalesPersonUserId");

                entity.HasIndex(e => e.TenantId, "IX_SalesCustomerMeetingForms_TenantId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_SalesCustomerMeetingForms_UpdatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AboveSafetyProfile).HasMaxLength(36);

                entity.Property(e => e.BarriersToRackingSystem).HasMaxLength(128);

                entity.Property(e => e.ContactChannelType).HasMaxLength(16);

                entity.Property(e => e.ContactSubjectType).HasMaxLength(16);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.CustomerContactPersonEmail)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CustomerContactPersonFullName).HasMaxLength(148);

                entity.Property(e => e.CustomerContactPersonId).HasMaxLength(36);

                entity.Property(e => e.CustomerContactPersonPhone)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.DeliveryBuilding).HasMaxLength(64);

                entity.Property(e => e.DeliveryCity).HasMaxLength(64);

                entity.Property(e => e.DeliveryCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("DeliveryCountryCodeISO3");

                entity.Property(e => e.DeliveryDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.DeliveryFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryFloor).HasMaxLength(16);

                entity.Property(e => e.DeliveryPostalCode).HasMaxLength(16);

                entity.Property(e => e.DeliverySite).HasMaxLength(64);

                entity.Property(e => e.DeliveryState).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryTown).HasMaxLength(64);

                entity.Property(e => e.DepotArchitectureProjectType).HasMaxLength(36);

                entity.Property(e => e.DepotFeature).HasMaxLength(36);

                entity.Property(e => e.DescriptionInstallationPlace).HasMaxLength(1024);

                entity.Property(e => e.EyeCapacity).HasMaxLength(36);

                entity.Property(e => e.FloorCondition).HasMaxLength(36);

                entity.Property(e => e.FloorRailType).HasMaxLength(16);

                entity.Property(e => e.FootProtectionType).HasMaxLength(36);

                entity.Property(e => e.ForkliftLiftingHeight).HasMaxLength(20);

                entity.Property(e => e.ForkliftTurnRadius).HasMaxLength(20);

                entity.Property(e => e.ForkliftTypeAndName).HasMaxLength(64);

                entity.Property(e => e.InvestmentType).HasMaxLength(32);

                entity.Property(e => e.MeetingDate).HasMaxLength(10);

                entity.Property(e => e.NoteRevisionRequest).HasMaxLength(128);

                entity.Property(e => e.PalletDimensions).HasMaxLength(64);

                entity.Property(e => e.PalletHeight).HasMaxLength(64);

                entity.Property(e => e.PalletLeaningProfile).HasMaxLength(36);

                entity.Property(e => e.PalletTasintilari).HasMaxLength(64);

                entity.Property(e => e.PalletWeight).HasMaxLength(64);

                entity.Property(e => e.ProjectDate).HasMaxLength(10);

                entity.Property(e => e.ProjectManagerUserId).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.RailTypeToInstall).HasMaxLength(36);

                entity.Property(e => e.ResellerContactPersonFullName).HasMaxLength(148);

                entity.Property(e => e.ResellerContactPersonId).HasMaxLength(36);

                entity.Property(e => e.ResellerId).HasMaxLength(36);

                entity.Property(e => e.ResellerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.RoofMaxHeight).HasMaxLength(20);

                entity.Property(e => e.SalesManagerUserId).HasMaxLength(36);

                entity.Property(e => e.SalesPersonUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.StaticCalculationType).HasMaxLength(32);

                entity.Property(e => e.SurfaceCoverType).HasMaxLength(36);

                entity.Property(e => e.SurfaceType).HasMaxLength(16);

                entity.Property(e => e.SystemType).HasMaxLength(16);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.ThirdTraverseHtype)
                    .HasMaxLength(36)
                    .HasColumnName("ThirdTraverseHType");

                entity.Property(e => e.UnderPalletSafetyProfile).HasMaxLength(36);

                entity.Property(e => e.UnderWoodSafetyPallet).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.SalesCustomerMeetingFormCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.CustomerContactPerson)
                    .WithMany(p => p.SalesCustomerMeetingFormCustomerContactPeople)
                    .HasForeignKey(d => d.CustomerContactPersonId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesCustomerMeetingFormCustomers)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ProjectManagerUser)
                    .WithMany(p => p.SalesCustomerMeetingFormProjectManagerUsers)
                    .HasForeignKey(d => d.ProjectManagerUserId);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.SalesCustomerMeetingForms)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.SalesCustomerMeetingForms)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.ResellerContactPerson)
                    .WithMany(p => p.SalesCustomerMeetingFormResellerContactPeople)
                    .HasForeignKey(d => d.ResellerContactPersonId);

                entity.HasOne(d => d.Reseller)
                    .WithMany(p => p.SalesCustomerMeetingFormResellers)
                    .HasForeignKey(d => d.ResellerId);

                entity.HasOne(d => d.SalesManagerUser)
                    .WithMany(p => p.SalesCustomerMeetingFormSalesManagerUsers)
                    .HasForeignKey(d => d.SalesManagerUserId);

                entity.HasOne(d => d.SalesPersonUser)
                    .WithMany(p => p.SalesCustomerMeetingFormSalesPersonUsers)
                    .HasForeignKey(d => d.SalesPersonUserId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SalesCustomerMeetingFormTenants)
                    .HasForeignKey(d => d.TenantId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.SalesCustomerMeetingFormUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);
            });

            modelBuilder.Entity<SalesCustomerMeetingFormFile>(entity =>
            {
                entity.HasIndex(e => e.SalesCustomerMeetingFormId, "IX_SalesCustomerMeetingFormFiles_SalesCustomerMeetingFormId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.SalesCustomerMeetingFormId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesCustomerMeetingForm)
                    .WithMany(p => p.SalesCustomerMeetingFormFiles)
                    .HasForeignKey(d => d.SalesCustomerMeetingFormId)
                    .HasConstraintName("FK_SalesCustomerMeetingFormFiles_SalesCustomerMeetingForms_Sale");
            });

            modelBuilder.Entity<SalesOffer>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_SalesOffers_CreatedUserId");

                entity.HasIndex(e => e.CustomerContactPersonId, "IX_SalesOffers_CustomerContactPersonId");

                entity.HasIndex(e => e.CustomerId, "IX_SalesOffers_CustomerId");

                entity.HasIndex(e => e.PscategoryId, "IX_SalesOffers_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_SalesOffers_PSId");

                entity.HasIndex(e => e.ProjectDesignerUserId, "IX_SalesOffers_ProjectDesignerUserId");

                entity.HasIndex(e => e.ProjectManagerUserId, "IX_SalesOffers_ProjectManagerUserId");

                entity.HasIndex(e => e.ResellerContactPersonId, "IX_SalesOffers_ResellerContactPersonId");

                entity.HasIndex(e => e.ResellerId, "IX_SalesOffers_ResellerId");

                entity.HasIndex(e => e.SalesCustomerMeetingFormId, "IX_SalesOffers_SalesCustomerMeetingFormId");

                entity.HasIndex(e => e.SalesManagerUserId, "IX_SalesOffers_SalesManagerUserId");

                entity.HasIndex(e => e.SalesPersonUserId, "IX_SalesOffers_SalesPersonUserId");

                entity.HasIndex(e => e.TenantId, "IX_SalesOffers_TenantId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_SalesOffers_UpdatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AccessCode).HasMaxLength(36);

                entity.Property(e => e.CancellationDate).HasMaxLength(25);

                entity.Property(e => e.CancellationDescription).HasMaxLength(128);

                entity.Property(e => e.CancellationTypeId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CurrencyServices).HasMaxLength(3);

                entity.Property(e => e.CustomerContactPersonEmail)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CustomerContactPersonFullName).HasMaxLength(148);

                entity.Property(e => e.CustomerContactPersonId).HasMaxLength(36);

                entity.Property(e => e.CustomerContactPersonPhone)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CustomerResponse).HasMaxLength(1024);

                entity.Property(e => e.CustomerResponseTypeId).HasMaxLength(36);

                entity.Property(e => e.DeliveryBuilding).HasMaxLength(64);

                entity.Property(e => e.DeliveryCity).HasMaxLength(64);

                entity.Property(e => e.DeliveryCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("DeliveryCountryCodeISO3");

                entity.Property(e => e.DeliveryDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.DeliveryFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryFloor).HasMaxLength(16);

                entity.Property(e => e.DeliveryPostalCode).HasMaxLength(16);

                entity.Property(e => e.DeliverySite).HasMaxLength(64);

                entity.Property(e => e.DeliveryState).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryTown).HasMaxLength(64);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.DescriptionColor).HasMaxLength(128);

                entity.Property(e => e.DescriptionDeliveryAddress).HasMaxLength(512);

                entity.Property(e => e.DescriptionDeliveryDate).HasMaxLength(256);

                entity.Property(e => e.DescriptionInstallation).HasMaxLength(512);

                entity.Property(e => e.DescriptionPayment).HasMaxLength(1024);

                entity.Property(e => e.DescriptionSalesTerms).HasMaxLength(1024);

                entity.Property(e => e.DescriptionStandarts).HasMaxLength(1024);

                entity.Property(e => e.DescriptionTax).HasMaxLength(128);

                entity.Property(e => e.DescriptionWarranty).HasMaxLength(1024);

                entity.Property(e => e.DescriptionWeight).HasMaxLength(256);

                entity.Property(e => e.DocumentSalesContractCustomerSignedFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentSalesContractTenantSignedFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentSalesOfferCustomerSignedFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentSalesOfferTenantSignedFileName).HasMaxLength(128);

                entity.Property(e => e.Eurtryparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("EURTRYParity");

                entity.Property(e => e.Eurusdparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("EURUSDParity");

                entity.Property(e => e.ExchangeDate).HasMaxLength(25);

                entity.Property(e => e.FixedParityTypeId).HasMaxLength(8);

                entity.Property(e => e.Gbptryparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("GBPTRYParity");

                entity.Property(e => e.Gbpusdparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("GBPUSDParity");

                entity.Property(e => e.InvoiceBuilding).HasMaxLength(64);

                entity.Property(e => e.InvoiceCity).HasMaxLength(64);

                entity.Property(e => e.InvoiceCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("InvoiceCountryCodeISO3");

                entity.Property(e => e.InvoiceDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.InvoiceFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.InvoiceFloor).HasMaxLength(16);

                entity.Property(e => e.InvoicePostalCode).HasMaxLength(16);

                entity.Property(e => e.InvoiceSite).HasMaxLength(64);

                entity.Property(e => e.InvoiceState).HasMaxLength(64);

                entity.Property(e => e.InvoiceStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.InvoiceStreetNo).HasMaxLength(16);

                entity.Property(e => e.InvoiceTown).HasMaxLength(64);

                entity.Property(e => e.PaymentPlanType).HasMaxLength(36);

                entity.Property(e => e.PriceDiscount).HasPrecision(18, 6);

                entity.Property(e => e.PriceDiscountRate).HasPrecision(18, 6);

                entity.Property(e => e.PriceDiscountType).HasMaxLength(8);

                entity.Property(e => e.PriceInstallation).HasPrecision(18, 6);

                entity.Property(e => e.PriceProductServiceTotal).HasPrecision(18, 6);

                entity.Property(e => e.PriceShipment).HasPrecision(18, 6);

                entity.Property(e => e.PriceStaticCalculation).HasPrecision(18, 6);

                entity.Property(e => e.PriceTotal).HasPrecision(18, 6);

                entity.Property(e => e.PriceTotalWithoutShipmentInstallation).HasPrecision(18, 6);

                entity.Property(e => e.PriceUnInstallation).HasPrecision(18, 6);

                entity.Property(e => e.ProformaInvoiceId).HasMaxLength(36);

                entity.Property(e => e.ProjectDesignerUserId).HasMaxLength(36);

                entity.Property(e => e.ProjectManagerUserId).HasMaxLength(36);

                entity.Property(e => e.ProjectNames).HasMaxLength(512);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.ResellerContactPersonFullName).HasMaxLength(148);

                entity.Property(e => e.ResellerContactPersonId).HasMaxLength(36);

                entity.Property(e => e.ResellerId).HasMaxLength(36);

                entity.Property(e => e.ResellerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.RootSalesOfferId).HasMaxLength(36);

                entity.Property(e => e.SalesCustomerMeetingFormId).HasMaxLength(36);

                entity.Property(e => e.SalesManagerUserId).HasMaxLength(36);

                entity.Property(e => e.SalesOfferNumber).HasMaxLength(16);

                entity.Property(e => e.SalesOfferNumberPrevious).HasMaxLength(16);

                entity.Property(e => e.SalesPersonUserId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.TaxWitholding).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.ThanksToCustomer).HasMaxLength(128);

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.Usdtryparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("USDTRYParity");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.SalesOfferCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.CustomerContactPerson)
                    .WithMany(p => p.SalesOfferCustomerContactPeople)
                    .HasForeignKey(d => d.CustomerContactPersonId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOfferCustomers)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ProjectDesignerUser)
                    .WithMany(p => p.SalesOfferProjectDesignerUsers)
                    .HasForeignKey(d => d.ProjectDesignerUserId);

                entity.HasOne(d => d.ProjectManagerUser)
                    .WithMany(p => p.SalesOfferProjectManagerUsers)
                    .HasForeignKey(d => d.ProjectManagerUserId);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.SalesOffers)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.SalesOffers)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.ResellerContactPerson)
                    .WithMany(p => p.SalesOfferResellerContactPeople)
                    .HasForeignKey(d => d.ResellerContactPersonId);

                entity.HasOne(d => d.Reseller)
                    .WithMany(p => p.SalesOfferResellers)
                    .HasForeignKey(d => d.ResellerId);

                entity.HasOne(d => d.SalesCustomerMeetingForm)
                    .WithMany(p => p.SalesOffers)
                    .HasForeignKey(d => d.SalesCustomerMeetingFormId)
                    .HasConstraintName("FK_SalesOffers_SalesCustomerMeetingForms_SalesCustomerMeetingFo");

                entity.HasOne(d => d.SalesManagerUser)
                    .WithMany(p => p.SalesOfferSalesManagerUsers)
                    .HasForeignKey(d => d.SalesManagerUserId);

                entity.HasOne(d => d.SalesPersonUser)
                    .WithMany(p => p.SalesOfferSalesPersonUsers)
                    .HasForeignKey(d => d.SalesPersonUserId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SalesOfferTenants)
                    .HasForeignKey(d => d.TenantId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.SalesOfferUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);
            });

            modelBuilder.Entity<SalesOfferCustomerFile>(entity =>
            {
                entity.HasIndex(e => e.SalesOfferId, "IX_SalesOfferCustomerFiles_SalesOfferId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.SalesOfferId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesOffer)
                    .WithMany(p => p.SalesOfferCustomerFiles)
                    .HasForeignKey(d => d.SalesOfferId);
            });

            modelBuilder.Entity<SalesOfferInternalFile>(entity =>
            {
                entity.HasIndex(e => e.SalesOfferId, "IX_SalesOfferInternalFiles_SalesOfferId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.SalesOfferId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesOffer)
                    .WithMany(p => p.SalesOfferInternalFiles)
                    .HasForeignKey(d => d.SalesOfferId);
            });

            modelBuilder.Entity<SalesOfferItem>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_SalesOfferItems_CustomerId");

                entity.HasIndex(e => e.PscategoryId, "IX_SalesOfferItems_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_SalesOfferItems_PSId");

                entity.HasIndex(e => e.SalesOfferId, "IX_SalesOfferItems_SalesOfferId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CurrencyDefault).HasMaxLength(3);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(64);

                entity.Property(e => e.ExchangeDate).HasMaxLength(25);

                entity.Property(e => e.ProjectName).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.SalesOfferId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UnitPriceDefault).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOfferItems)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.SalesOfferItems)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.SalesOfferItems)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.SalesOffer)
                    .WithMany(p => p.SalesOfferItems)
                    .HasForeignKey(d => d.SalesOfferId);
            });

            modelBuilder.Entity<SalesOfferNote>(entity =>
            {
                entity.HasIndex(e => e.SalesOfferId, "IX_SalesOfferNotes_SalesOfferId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserEmail).HasMaxLength(256);

                entity.Property(e => e.CreatedUserFullName).HasMaxLength(148);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Note).HasMaxLength(128);

                entity.Property(e => e.SalesOfferId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesOffer)
                    .WithMany(p => p.SalesOfferNotes)
                    .HasForeignKey(d => d.SalesOfferId);
            });

            modelBuilder.Entity<SalesOfferPaymentPlanStep>(entity =>
            {
                entity.HasIndex(e => e.SalesOfferId, "IX_SalesOfferPaymentPlanSteps_SalesOfferId");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Note).HasMaxLength(64);

                entity.Property(e => e.Percent).HasPrecision(18, 6);

                entity.Property(e => e.SalesOfferId).HasMaxLength(36);

                entity.HasOne(d => d.SalesOffer)
                    .WithMany(p => p.SalesOfferPaymentPlanSteps)
                    .HasForeignKey(d => d.SalesOfferId);
            });

            modelBuilder.Entity<SalesOfferTermsDefaultValue>(entity =>
            {
                entity.HasKey(e => e.TenantId);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserEmail).HasMaxLength(256);

                entity.Property(e => e.CreatedUserFullName).HasMaxLength(148);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.DescriptionColor).HasMaxLength(128);

                entity.Property(e => e.DescriptionDeliveryAddress).HasMaxLength(512);

                entity.Property(e => e.DescriptionDeliveryDate).HasMaxLength(256);

                entity.Property(e => e.DescriptionInstallation).HasMaxLength(512);

                entity.Property(e => e.DescriptionPayment).HasMaxLength(1024);

                entity.Property(e => e.DescriptionSalesTerms).HasMaxLength(1024);

                entity.Property(e => e.DescriptionStandarts).HasMaxLength(1024);

                entity.Property(e => e.DescriptionTax).HasMaxLength(128);

                entity.Property(e => e.DescriptionWarranty).HasMaxLength(1024);

                entity.Property(e => e.DescriptionWeight).HasMaxLength(256);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.ThanksToCustomer).HasMaxLength(128);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserEmail).HasMaxLength(256);

                entity.Property(e => e.UpdatedUserFullName).HasMaxLength(148);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_SalesOrders_CreatedUserId");

                entity.HasIndex(e => e.CustomerContactPersonId, "IX_SalesOrders_CustomerContactPersonId");

                entity.HasIndex(e => e.CustomerId, "IX_SalesOrders_CustomerId");

                entity.HasIndex(e => e.PscategoryId, "IX_SalesOrders_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_SalesOrders_PSId");

                entity.HasIndex(e => e.ProductionDirectorUserId, "IX_SalesOrders_ProductionDirectorUserId");

                entity.HasIndex(e => e.ProductionManagerUserId, "IX_SalesOrders_ProductionManagerUserId");

                entity.HasIndex(e => e.ProductionPlannerUserId, "IX_SalesOrders_ProductionPlannerUserId");

                entity.HasIndex(e => e.ProjectDesignerUserId, "IX_SalesOrders_ProjectDesignerUserId");

                entity.HasIndex(e => e.ProjectManagerUserId, "IX_SalesOrders_ProjectManagerUserId");

                entity.HasIndex(e => e.ResellerContactPersonId, "IX_SalesOrders_ResellerContactPersonId");

                entity.HasIndex(e => e.ResellerId, "IX_SalesOrders_ResellerId");

                entity.HasIndex(e => e.SalesManagerUserId, "IX_SalesOrders_SalesManagerUserId");

                entity.HasIndex(e => e.SalesOfferId, "IX_SalesOrders_SalesOfferId");

                entity.HasIndex(e => e.SalesPersonUserId, "IX_SalesOrders_SalesPersonUserId");

                entity.HasIndex(e => e.TenantId, "IX_SalesOrders_TenantId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_SalesOrders_UpdatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AccessCode).HasMaxLength(36);

                entity.Property(e => e.CancellationDate).HasMaxLength(25);

                entity.Property(e => e.CancellationDescription).HasMaxLength(128);

                entity.Property(e => e.CancellationTypeId).HasMaxLength(36);

                entity.Property(e => e.CompletedDate).HasMaxLength(25);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CurrencyServices).HasMaxLength(3);

                entity.Property(e => e.CustomerContactPersonEmail)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CustomerContactPersonFullName).HasMaxLength(148);

                entity.Property(e => e.CustomerContactPersonId).HasMaxLength(36);

                entity.Property(e => e.CustomerContactPersonName).HasMaxLength(148);

                entity.Property(e => e.CustomerContactPersonPhone)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CustomerPurchaseOrderId).HasMaxLength(36);

                entity.Property(e => e.DateEndDeliveryEstimated).HasMaxLength(25);

                entity.Property(e => e.DateEndInstallationEstimated).HasMaxLength(25);

                entity.Property(e => e.DateEndProductionEstimated).HasMaxLength(25);

                entity.Property(e => e.DateEndUnInstallationEstimated).HasMaxLength(25);

                entity.Property(e => e.DateStartDeliveryEstimated).HasMaxLength(25);

                entity.Property(e => e.DateStartInstallationEstimated).HasMaxLength(25);

                entity.Property(e => e.DateStartProductionEstimated).HasMaxLength(25);

                entity.Property(e => e.DateStartUnInstallationEstimated).HasMaxLength(25);

                entity.Property(e => e.DeliveryAddressDescription).HasMaxLength(128);

                entity.Property(e => e.DeliveryBuilding).HasMaxLength(64);

                entity.Property(e => e.DeliveryCity).HasMaxLength(64);

                entity.Property(e => e.DeliveryCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("DeliveryCountryCodeISO3");

                entity.Property(e => e.DeliveryDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.DeliveryFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryFloor).HasMaxLength(16);

                entity.Property(e => e.DeliveryPostalCode).HasMaxLength(16);

                entity.Property(e => e.DeliverySite).HasMaxLength(64);

                entity.Property(e => e.DeliveryState).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryTown).HasMaxLength(64);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.DescriptionColor).HasMaxLength(128);

                entity.Property(e => e.DescriptionDeliveryAddress).HasMaxLength(512);

                entity.Property(e => e.DescriptionDeliveryDate).HasMaxLength(256);

                entity.Property(e => e.DescriptionInstallation).HasMaxLength(512);

                entity.Property(e => e.DescriptionPayment).HasMaxLength(1024);

                entity.Property(e => e.DescriptionSalesTerms).HasMaxLength(1024);

                entity.Property(e => e.DescriptionStandarts).HasMaxLength(1024);

                entity.Property(e => e.DescriptionTax).HasMaxLength(128);

                entity.Property(e => e.DescriptionWarranty).HasMaxLength(1024);

                entity.Property(e => e.DescriptionWeight).HasMaxLength(256);

                entity.Property(e => e.DocumentCompletionCustomerApprovalFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentInvoiceFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentSalesContractCustomerSignedFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentSalesContractTenantSignedFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentSalesOfferCustomerSignedFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentSalesOfferTenantSignedFileName).HasMaxLength(128);

                entity.Property(e => e.Eurtryparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("EURTRYParity");

                entity.Property(e => e.Eurusdparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("EURUSDParity");

                entity.Property(e => e.ExchangeDate).HasMaxLength(25);

                entity.Property(e => e.FixedParityTypeId).HasMaxLength(8);

                entity.Property(e => e.Gbptryparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("GBPTRYParity");

                entity.Property(e => e.Gbpusdparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("GBPUSDParity");

                entity.Property(e => e.InvoiceBuilding).HasMaxLength(64);

                entity.Property(e => e.InvoiceCity).HasMaxLength(64);

                entity.Property(e => e.InvoiceCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("InvoiceCountryCodeISO3");

                entity.Property(e => e.InvoiceDate).HasMaxLength(25);

                entity.Property(e => e.InvoiceDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.InvoiceFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.InvoiceFloor).HasMaxLength(16);

                entity.Property(e => e.InvoiceNo).HasMaxLength(36);

                entity.Property(e => e.InvoicePostalCode).HasMaxLength(16);

                entity.Property(e => e.InvoiceSite).HasMaxLength(64);

                entity.Property(e => e.InvoiceState).HasMaxLength(64);

                entity.Property(e => e.InvoiceStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.InvoiceStreetNo).HasMaxLength(16);

                entity.Property(e => e.InvoiceTown).HasMaxLength(64);

                entity.Property(e => e.PaymentPlanType).HasMaxLength(36);

                entity.Property(e => e.PlannedDate).HasMaxLength(25);

                entity.Property(e => e.PriceDiscount).HasPrecision(18, 6);

                entity.Property(e => e.PriceDiscountRate).HasPrecision(18, 6);

                entity.Property(e => e.PriceDiscountType).HasMaxLength(8);

                entity.Property(e => e.PriceInstallation).HasPrecision(18, 6);

                entity.Property(e => e.PriceProductServiceTotal).HasPrecision(18, 6);

                entity.Property(e => e.PriceShipment).HasPrecision(18, 6);

                entity.Property(e => e.PriceStaticCalculation).HasPrecision(18, 6);

                entity.Property(e => e.PriceTotal).HasPrecision(18, 6);

                entity.Property(e => e.PriceTotalWithoutShipmentInstallation).HasPrecision(18, 6);

                entity.Property(e => e.PriceUnInstallation).HasPrecision(18, 6);

                entity.Property(e => e.ProductionDirectorUserId).HasMaxLength(36);

                entity.Property(e => e.ProductionManagerUserId).HasMaxLength(36);

                entity.Property(e => e.ProductionPlannerUserId).HasMaxLength(36);

                entity.Property(e => e.ProjectDesignerUserId).HasMaxLength(36);

                entity.Property(e => e.ProjectManagerUserId).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.ResellerContactPersonFullName).HasMaxLength(148);

                entity.Property(e => e.ResellerContactPersonId).HasMaxLength(36);

                entity.Property(e => e.ResellerId).HasMaxLength(36);

                entity.Property(e => e.ResellerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.RootSalesOrderId).HasMaxLength(36);

                entity.Property(e => e.SalesManagerUserId).HasMaxLength(36);

                entity.Property(e => e.SalesOfferId).HasMaxLength(36);

                entity.Property(e => e.SalesOfferNumber).HasMaxLength(16);

                entity.Property(e => e.SalesOrderNumber).HasMaxLength(16);

                entity.Property(e => e.SalesOrderNumberPrevious).HasMaxLength(16);

                entity.Property(e => e.SalesPersonUserId).HasMaxLength(36);

                entity.Property(e => e.SeqNo).ValueGeneratedOnAdd();

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.TaxWitholding).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.ThanksToCustomer).HasMaxLength(128);

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.Usdtryparity)
                    .HasPrecision(18, 6)
                    .HasColumnName("USDTRYParity");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.SalesOrderCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.CustomerContactPerson)
                    .WithMany(p => p.SalesOrderCustomerContactPeople)
                    .HasForeignKey(d => d.CustomerContactPersonId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOrderCustomers)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ProductionDirectorUser)
                    .WithMany(p => p.SalesOrderProductionDirectorUsers)
                    .HasForeignKey(d => d.ProductionDirectorUserId);

                entity.HasOne(d => d.ProductionManagerUser)
                    .WithMany(p => p.SalesOrderProductionManagerUsers)
                    .HasForeignKey(d => d.ProductionManagerUserId);

                entity.HasOne(d => d.ProductionPlannerUser)
                    .WithMany(p => p.SalesOrderProductionPlannerUsers)
                    .HasForeignKey(d => d.ProductionPlannerUserId);

                entity.HasOne(d => d.ProjectDesignerUser)
                    .WithMany(p => p.SalesOrderProjectDesignerUsers)
                    .HasForeignKey(d => d.ProjectDesignerUserId);

                entity.HasOne(d => d.ProjectManagerUser)
                    .WithMany(p => p.SalesOrderProjectManagerUsers)
                    .HasForeignKey(d => d.ProjectManagerUserId);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.ResellerContactPerson)
                    .WithMany(p => p.SalesOrderResellerContactPeople)
                    .HasForeignKey(d => d.ResellerContactPersonId);

                entity.HasOne(d => d.Reseller)
                    .WithMany(p => p.SalesOrderResellers)
                    .HasForeignKey(d => d.ResellerId);

                entity.HasOne(d => d.SalesManagerUser)
                    .WithMany(p => p.SalesOrderSalesManagerUsers)
                    .HasForeignKey(d => d.SalesManagerUserId);

                entity.HasOne(d => d.SalesOffer)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.SalesOfferId);

                entity.HasOne(d => d.SalesPersonUser)
                    .WithMany(p => p.SalesOrderSalesPersonUsers)
                    .HasForeignKey(d => d.SalesPersonUserId);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SalesOrderTenants)
                    .HasForeignKey(d => d.TenantId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.SalesOrderUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);
            });

            modelBuilder.Entity<SalesOrderCustomerFile>(entity =>
            {
                entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderCustomerFiles_SalesOrderId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderCustomerFiles)
                    .HasForeignKey(d => d.SalesOrderId);
            });

            modelBuilder.Entity<SalesOrderInternalFile>(entity =>
            {
                entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderInternalFiles_SalesOrderId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderInternalFiles)
                    .HasForeignKey(d => d.SalesOrderId);
            });

            modelBuilder.Entity<SalesOrderInvoice>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_SalesOrderInvoices_CreatedUserId");

                entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderInvoices_SalesOrderId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Date).HasMaxLength(25);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.No).HasMaxLength(36);

                entity.Property(e => e.Note).HasMaxLength(64);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.SalesOrderInvoices)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderInvoices)
                    .HasForeignKey(d => d.SalesOrderId);
            });

            modelBuilder.Entity<SalesOrderItem>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_SalesOrderItems_CustomerId");

                entity.HasIndex(e => e.PscategoryId, "IX_SalesOrderItems_PSCategoryId");

                entity.HasIndex(e => e.Psid, "IX_SalesOrderItems_PSId");

                entity.HasIndex(e => e.ProjectId, "IX_SalesOrderItems_ProjectId");

                entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderItems_SalesOrderId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.AmountInvoice).HasPrecision(18, 6);

                entity.Property(e => e.AmountRevision).HasPrecision(18, 6);

                entity.Property(e => e.AmountRevisionInvoice).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CurrencyDefault).HasMaxLength(3);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(64);

                entity.Property(e => e.ExchangeDate).HasMaxLength(25);

                entity.Property(e => e.ProjectId).HasMaxLength(36);

                entity.Property(e => e.PscategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("PSCategoryId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.RevParty).HasMaxLength(36);

                entity.Property(e => e.RevReason).HasMaxLength(36);

                entity.Property(e => e.RevType).HasMaxLength(36);

                entity.Property(e => e.RevisionPriceExchangeTypeId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UnitPriceDefault).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOrderItems)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SalesOrderItems)
                    .HasForeignKey(d => d.ProjectId);

                entity.HasOne(d => d.Pscategory)
                    .WithMany(p => p.SalesOrderItems)
                    .HasForeignKey(d => d.PscategoryId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.SalesOrderItems)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderItems)
                    .HasForeignKey(d => d.SalesOrderId);
            });

            modelBuilder.Entity<SalesOrderItemComponent>(entity =>
            {
                entity.HasIndex(e => e.ComponentId, "IX_SalesOrderItemComponents_ComponentId");

                entity.HasIndex(e => e.ProjectId, "IX_SalesOrderItemComponents_ProjectId");

                entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderItemComponents_SalesOrderId");

                entity.HasIndex(e => e.SalesOrderItemId, "IX_SalesOrderItemComponents_SalesOrderItemId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AmountDefective).HasPrecision(18, 6);

                entity.Property(e => e.AmountFulfilled).HasPrecision(18, 6);

                entity.Property(e => e.AmountInStock).HasPrecision(18, 6);

                entity.Property(e => e.AmountInstalled).HasPrecision(18, 6);

                entity.Property(e => e.AmountRequired).HasPrecision(18, 6);

                entity.Property(e => e.AmountSent).HasPrecision(18, 6);

                entity.Property(e => e.ComponentId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.ProjectId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderItemId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.SalesOrderItemComponents)
                    .HasForeignKey(d => d.ComponentId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SalesOrderItemComponents)
                    .HasForeignKey(d => d.ProjectId);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderItemComponents)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.SalesOrderItem)
                    .WithMany(p => p.SalesOrderItemComponents)
                    .HasForeignKey(d => d.SalesOrderItemId);
            });

            modelBuilder.Entity<SalesOrderNote>(entity =>
            {
                entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderNotes_SalesOrderId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserEmail).HasMaxLength(256);

                entity.Property(e => e.CreatedUserFullName).HasMaxLength(148);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Note).HasMaxLength(128);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderNotes)
                    .HasForeignKey(d => d.SalesOrderId);
            });

            modelBuilder.Entity<SalesOrderPaymentPlanStep>(entity =>
            {
                entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderPaymentPlanSteps_SalesOrderId");

                entity.HasIndex(e => e.SalesUserId, "IX_SalesOrderPaymentPlanSteps_SalesUserId");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CustomerName).HasMaxLength(256);

                entity.Property(e => e.DueDate).HasMaxLength(25);

                entity.Property(e => e.Note).HasMaxLength(64);

                entity.Property(e => e.Paid).HasPrecision(18, 6);

                entity.Property(e => e.Percent).HasPrecision(18, 6);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.SalesUserId).HasMaxLength(36);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderPaymentPlanSteps)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.SalesUser)
                    .WithMany(p => p.SalesOrderPaymentPlanSteps)
                    .HasForeignKey(d => d.SalesUserId);
            });

            modelBuilder.Entity<SalesPersonRevenueGoal>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.SalesPersonUserId, e.Year });

                entity.HasIndex(e => e.SalesPersonUserId, "IX_SalesPersonRevenueGoals_SalesPersonUserId");

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.SalesPersonUserId).HasMaxLength(36);

                entity.Property(e => e.Achieved).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Goal).HasPrecision(18, 6);

                entity.Property(e => e.Note).HasMaxLength(64);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.SalesPersonUser)
                    .WithMany(p => p.SalesPersonRevenueGoals)
                    .HasForeignKey(d => d.SalesPersonUserId);
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_Shipments_CreatedUserId");

                entity.HasIndex(e => e.DriverPersonId, "IX_Shipments_DriverPersonId");

                entity.HasIndex(e => e.ExporterImporterPartyId, "IX_Shipments_ExporterImporterPartyId");

                entity.HasIndex(e => e.FromPartyId, "IX_Shipments_FromPartyId");

                entity.HasIndex(e => e.PurchaseOrderId, "IX_Shipments_PurchaseOrderId");

                entity.HasIndex(e => e.SalesOrderId, "IX_Shipments_SalesOrderId");

                entity.HasIndex(e => e.ShipmentManagerUserId, "IX_Shipments_ShipmentManagerUserId");

                entity.HasIndex(e => e.ShipmentPersonUserId, "IX_Shipments_ShipmentPersonUserId");

                entity.HasIndex(e => e.ShipmentPlannerUserId, "IX_Shipments_ShipmentPlannerUserId");

                entity.HasIndex(e => e.ShipperPartyId, "IX_Shipments_ShipperPartyId");

                entity.HasIndex(e => e.ToPartyId, "IX_Shipments_ToPartyId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_Shipments_UpdatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.DateEndActual).HasMaxLength(25);

                entity.Property(e => e.DateEndEstimated).HasMaxLength(25);

                entity.Property(e => e.DateStartActual).HasMaxLength(25);

                entity.Property(e => e.DateStartEstimated).HasMaxLength(25);

                entity.Property(e => e.DeliveryAddressDescription).HasMaxLength(128);

                entity.Property(e => e.DeliveryBuilding).HasMaxLength(64);

                entity.Property(e => e.DeliveryCity).HasMaxLength(64);

                entity.Property(e => e.DeliveryCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("DeliveryCountryCodeISO3");

                entity.Property(e => e.DeliveryDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.DeliveryFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryFloor).HasMaxLength(16);

                entity.Property(e => e.DeliveryPostalCode).HasMaxLength(16);

                entity.Property(e => e.DeliverySite).HasMaxLength(64);

                entity.Property(e => e.DeliveryState).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryTown).HasMaxLength(64);

                entity.Property(e => e.DescriptionHandling).HasMaxLength(128);

                entity.Property(e => e.DocumentExportImportFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentExporterImporterInvoiceFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentShipperInvoiceFileName).HasMaxLength(128);

                entity.Property(e => e.DocumentWayBillFileName).HasMaxLength(128);

                entity.Property(e => e.DriverCitizenId).HasMaxLength(16);

                entity.Property(e => e.DriverFirstName).HasMaxLength(36);

                entity.Property(e => e.DriverLastName).HasMaxLength(36);

                entity.Property(e => e.DriverPersonId).HasMaxLength(36);

                entity.Property(e => e.ExporterImporterCostActual).HasPrecision(18, 6);

                entity.Property(e => e.ExporterImporterPartyId).HasMaxLength(36);

                entity.Property(e => e.ExporterImporterTaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.FromPartyId).HasMaxLength(36);

                entity.Property(e => e.FromPartyName).HasMaxLength(256);

                entity.Property(e => e.ProformaInvoiceId).HasMaxLength(36);

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.ShipmentManagerUserId).HasMaxLength(36);

                entity.Property(e => e.ShipmentPersonUserId).HasMaxLength(36);

                entity.Property(e => e.ShipmentPlannerUserId).HasMaxLength(36);

                entity.Property(e => e.ShipperCostActual).HasPrecision(18, 6);

                entity.Property(e => e.ShipperCostCurrency).HasMaxLength(3);

                entity.Property(e => e.ShipperInvoiceDate).HasMaxLength(25);

                entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(36);

                entity.Property(e => e.ShipperPartyId).HasMaxLength(36);

                entity.Property(e => e.ShipperPartyName).HasMaxLength(256);

                entity.Property(e => e.ShipperTaxPercent).HasPrecision(18, 6);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.ToPartyId).HasMaxLength(36);

                entity.Property(e => e.ToPartyName).HasMaxLength(256);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(16);

                entity.Property(e => e.WayBillNo).HasMaxLength(36);

                entity.Property(e => e.Weight).HasPrecision(18, 6);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ShipmentCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.DriverPerson)
                    .WithMany(p => p.ShipmentDriverPeople)
                    .HasForeignKey(d => d.DriverPersonId);

                entity.HasOne(d => d.ExporterImporterParty)
                    .WithMany(p => p.ShipmentExporterImporterParties)
                    .HasForeignKey(d => d.ExporterImporterPartyId);

                entity.HasOne(d => d.FromParty)
                    .WithMany(p => p.ShipmentFromParties)
                    .HasForeignKey(d => d.FromPartyId);

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.PurchaseOrderId);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.ShipmentManagerUser)
                    .WithMany(p => p.ShipmentShipmentManagerUsers)
                    .HasForeignKey(d => d.ShipmentManagerUserId);

                entity.HasOne(d => d.ShipmentPersonUser)
                    .WithMany(p => p.ShipmentShipmentPersonUsers)
                    .HasForeignKey(d => d.ShipmentPersonUserId);

                entity.HasOne(d => d.ShipmentPlannerUser)
                    .WithMany(p => p.ShipmentShipmentPlannerUsers)
                    .HasForeignKey(d => d.ShipmentPlannerUserId);

                entity.HasOne(d => d.ShipperParty)
                    .WithMany(p => p.ShipmentShipperParties)
                    .HasForeignKey(d => d.ShipperPartyId);

                entity.HasOne(d => d.ToParty)
                    .WithMany(p => p.ShipmentToParties)
                    .HasForeignKey(d => d.ToPartyId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.ShipmentUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);
            });

            modelBuilder.Entity<ShipmentAmountBasedPlan>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_ShipmentAmountBasedPlans_CreatedUserId");

                entity.HasIndex(e => e.FromPartyId, "IX_ShipmentAmountBasedPlans_FromPartyId");

                entity.HasIndex(e => e.PurchaseOrderId, "IX_ShipmentAmountBasedPlans_PurchaseOrderId");

                entity.HasIndex(e => e.SalesOrderId, "IX_ShipmentAmountBasedPlans_SalesOrderId");

                entity.HasIndex(e => e.ShipperPartyId, "IX_ShipmentAmountBasedPlans_ShipperPartyId");

                entity.HasIndex(e => e.ToPartyId, "IX_ShipmentAmountBasedPlans_ToPartyId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_ShipmentAmountBasedPlans_UpdatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.DateEndEstimated).HasMaxLength(25);

                entity.Property(e => e.DateStartEstimated).HasMaxLength(25);

                entity.Property(e => e.DeliveryAddressDescription).HasMaxLength(128);

                entity.Property(e => e.DeliveryBuilding).HasMaxLength(64);

                entity.Property(e => e.DeliveryCity).HasMaxLength(64);

                entity.Property(e => e.DeliveryCountryCodeIso3)
                    .HasMaxLength(3)
                    .HasColumnName("DeliveryCountryCodeISO3");

                entity.Property(e => e.DeliveryDistrictNeighborhoodVillage).HasMaxLength(64);

                entity.Property(e => e.DeliveryFlatIndoorNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryFloor).HasMaxLength(16);

                entity.Property(e => e.DeliveryPostalCode).HasMaxLength(16);

                entity.Property(e => e.DeliverySite).HasMaxLength(64);

                entity.Property(e => e.DeliveryState).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetBlvAveName).HasMaxLength(64);

                entity.Property(e => e.DeliveryStreetNo).HasMaxLength(16);

                entity.Property(e => e.DeliveryTown).HasMaxLength(64);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.FromPartyId).HasMaxLength(36);

                entity.Property(e => e.FromPartyName).HasMaxLength(256);

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.ShipperPartyId).HasMaxLength(36);

                entity.Property(e => e.ShipperPartyName).HasMaxLength(256);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.ToPartyId).HasMaxLength(36);

                entity.Property(e => e.ToPartyName).HasMaxLength(256);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.Weight).HasPrecision(18, 6);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ShipmentAmountBasedPlanCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.FromParty)
                    .WithMany(p => p.ShipmentAmountBasedPlanFromParties)
                    .HasForeignKey(d => d.FromPartyId);

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.ShipmentAmountBasedPlans)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_ShipmentAmountBasedPlans_ProcurementPurchaseOrders_PurchaseO");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.ShipmentAmountBasedPlans)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.ShipperParty)
                    .WithMany(p => p.ShipmentAmountBasedPlanShipperParties)
                    .HasForeignKey(d => d.ShipperPartyId);

                entity.HasOne(d => d.ToParty)
                    .WithMany(p => p.ShipmentAmountBasedPlanToParties)
                    .HasForeignKey(d => d.ToPartyId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.ShipmentAmountBasedPlanUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);
            });

            modelBuilder.Entity<ShipmentAmountBasedPlanItem>(entity =>
            {
                entity.HasKey(e => new { e.ShipmentAmountBasedPlanId, e.Psid });

                entity.Property(e => e.ShipmentAmountBasedPlanId).HasMaxLength(36);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.AmountInStorage).HasPrecision(18, 6);

                entity.Property(e => e.AmountRequired).HasPrecision(18, 6);

                entity.Property(e => e.AmountSent).HasPrecision(18, 6);

                entity.Property(e => e.AmountToDo).HasPrecision(18, 6);

                entity.Property(e => e.AmountToSend).HasPrecision(18, 6);

                entity.Property(e => e.AmountUnit).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Psn)
                    .HasMaxLength(512)
                    .HasColumnName("PSN");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.WeightInStorage).HasPrecision(18, 6);

                entity.Property(e => e.WeightRequired).HasPrecision(18, 6);

                entity.Property(e => e.WeightSent).HasPrecision(18, 6);

                entity.Property(e => e.WeightToDo).HasPrecision(18, 6);

                entity.Property(e => e.WeightToSend).HasPrecision(18, 6);

                entity.HasOne(d => d.ShipmentAmountBasedPlan)
                    .WithMany(p => p.ShipmentAmountBasedPlanItems)
                    .HasForeignKey(d => d.ShipmentAmountBasedPlanId)
                    .HasConstraintName("FK_ShipmentAmountBasedPlanItems_ShipmentAmountBasedPlans_Shipme");
            });

            modelBuilder.Entity<ShipmentItem>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_ShipmentItems_CreatedUserId");

                entity.HasIndex(e => e.FromPartyId, "IX_ShipmentItems_FromPartyId");

                entity.HasIndex(e => e.InventoryItemId, "IX_ShipmentItems_InventoryItemId");

                entity.HasIndex(e => e.Psid, "IX_ShipmentItems_PSId");

                entity.HasIndex(e => e.ProjectId, "IX_ShipmentItems_ProjectId");

                entity.HasIndex(e => e.SalesOrderId, "IX_ShipmentItems_SalesOrderId");

                entity.HasIndex(e => e.ShipmentId, "IX_ShipmentItems_ShipmentId");

                entity.HasIndex(e => e.TaskId, "IX_ShipmentItems_TaskId");

                entity.HasIndex(e => e.ToPartyId, "IX_ShipmentItems_ToPartyId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_ShipmentItems_UpdatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.AmountAccepted).HasPrecision(18, 6);

                entity.Property(e => e.AmountDamaged).HasPrecision(18, 6);

                entity.Property(e => e.AmountRejected).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.DamageReasonTypeId).HasMaxLength(36);

                entity.Property(e => e.FromPartyId).HasMaxLength(36);

                entity.Property(e => e.InventoryItemId).HasMaxLength(36);

                entity.Property(e => e.MismatchReasonTypeId).HasMaxLength(36);

                entity.Property(e => e.ProjectId).HasMaxLength(36);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.PurchaseUnit).HasMaxLength(36);

                entity.Property(e => e.RejectionReasonTypeId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.ShipmentId).HasMaxLength(36);

                entity.Property(e => e.ShipmentItemNumber).HasMaxLength(16);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.ToPartyId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ShipmentItemCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.FromParty)
                    .WithMany(p => p.ShipmentItemFromParties)
                    .HasForeignKey(d => d.FromPartyId);

                entity.HasOne(d => d.InventoryItem)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.InventoryItemId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ProjectId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ShipmentId);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.TaskId);

                entity.HasOne(d => d.ToParty)
                    .WithMany(p => p.ShipmentItemToParties)
                    .HasForeignKey(d => d.ToPartyId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.ShipmentItemUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);
            });

            modelBuilder.Entity<ShipmentWayBillDocument>(entity =>
            {
                entity.HasIndex(e => e.ShipmentId, "IX_ShipmentWayBillDocuments_ShipmentId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.ShipmentId).HasMaxLength(36);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.WayBillNumber).HasMaxLength(36);

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentWayBillDocuments)
                    .HasForeignKey(d => d.ShipmentId);
            });

            modelBuilder.Entity<StockCountingActivity>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_StockCountingActivities_CreatedUserId");

                entity.HasIndex(e => e.FacilityId, "IX_StockCountingActivities_FacilityId");

                entity.HasIndex(e => e.FacilityStorageId, "IX_StockCountingActivities_FacilityStorageId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_StockCountingActivities_UpdatedUserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.EndDate).HasMaxLength(25);

                entity.Property(e => e.FacilityId).HasMaxLength(36);

                entity.Property(e => e.FacilityStorageId).HasMaxLength(36);

                entity.Property(e => e.StartDate).HasMaxLength(25);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.StockCountingActivityCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.StockCountingActivities)
                    .HasForeignKey(d => d.FacilityId);

                entity.HasOne(d => d.FacilityStorage)
                    .WithMany(p => p.StockCountingActivities)
                    .HasForeignKey(d => d.FacilityStorageId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.StockCountingActivityUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);
            });

            modelBuilder.Entity<StockCountingActivityItem>(entity =>
            {
                entity.HasKey(e => new { e.StockCountingActivityId, e.InventoryItemId });

                entity.HasIndex(e => e.InventoryItemId, "IX_StockCountingActivityItems_InventoryItemId");

                entity.Property(e => e.StockCountingActivityId).HasMaxLength(36);

                entity.Property(e => e.InventoryItemId).HasMaxLength(36);

                entity.Property(e => e.AmountFinal).HasPrecision(18, 6);

                entity.Property(e => e.AmountInitial).HasPrecision(18, 6);

                entity.Property(e => e.CheckedDate).HasMaxLength(25);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.InventoryItemNo).HasMaxLength(16);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.InventoryItem)
                    .WithMany(p => p.StockCountingActivityItems)
                    .HasForeignKey(d => d.InventoryItemId);

                entity.HasOne(d => d.StockCountingActivity)
                    .WithMany(p => p.StockCountingActivityItems)
                    .HasForeignKey(d => d.StockCountingActivityId)
                    .HasConstraintName("FK_StockCountingActivityItems_StockCountingActivities_StockCoun");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasIndex(e => e.AssetId, "IX_Tasks_AssetId");

                entity.HasIndex(e => e.PscomponentId, "IX_Tasks_PSComponentId");

                entity.HasIndex(e => e.Psid, "IX_Tasks_PSId");

                entity.HasIndex(e => e.ProjectId, "IX_Tasks_ProjectId");

                entity.HasIndex(e => e.SalesOrderId, "IX_Tasks_SalesOrderId");

                entity.HasIndex(e => e.SalesOrderItemComponentId, "IX_Tasks_SalesOrderItemComponentId");

                entity.HasIndex(e => e.SalesOrderItemId, "IX_Tasks_SalesOrderItemId");

                entity.HasIndex(e => e.TaskId, "IX_Tasks_TaskId");

                entity.HasIndex(e => e.TaskTypeId, "IX_Tasks_TaskTypeId");

                entity.HasIndex(e => e.UserId, "IX_Tasks_UserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.Acost)
                    .HasPrecision(18, 6)
                    .HasColumnName("ACost");

                entity.Property(e => e.Aduration).HasColumnName("ADuration");

                entity.Property(e => e.Aend)
                    .HasMaxLength(25)
                    .HasColumnName("AEnd");

                entity.Property(e => e.AmountDefective).HasPrecision(18, 6);

                entity.Property(e => e.AmountDone).HasPrecision(18, 6);

                entity.Property(e => e.AmountRequired).HasPrecision(18, 6);

                entity.Property(e => e.AmountToDo).HasPrecision(18, 6);

                entity.Property(e => e.An)
                    .HasMaxLength(64)
                    .HasColumnName("AN");

                entity.Property(e => e.AssetId).HasMaxLength(36);

                entity.Property(e => e.Astart)
                    .HasMaxLength(25)
                    .HasColumnName("AStart");

                entity.Property(e => e.City).HasMaxLength(64);

                entity.Property(e => e.Country).HasMaxLength(3);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.No).HasMaxLength(16);

                entity.Property(e => e.Pcost)
                    .HasPrecision(18, 6)
                    .HasColumnName("PCost");

                entity.Property(e => e.Pduration).HasColumnName("PDuration");

                entity.Property(e => e.Pend)
                    .HasMaxLength(25)
                    .HasColumnName("PEnd");

                entity.Property(e => e.ProjectId).HasMaxLength(36);

                entity.Property(e => e.ProjectName).HasMaxLength(128);

                entity.Property(e => e.Pscn)
                    .HasMaxLength(512)
                    .HasColumnName("PSCN");

                entity.Property(e => e.PscomponentId)
                    .HasMaxLength(36)
                    .HasColumnName("PSComponentId");

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.Psn)
                    .HasMaxLength(512)
                    .HasColumnName("PSN");

                entity.Property(e => e.Pstart)
                    .HasMaxLength(25)
                    .HasColumnName("PStart");

                entity.Property(e => e.RevParty).HasMaxLength(36);

                entity.Property(e => e.RevReason).HasMaxLength(36);

                entity.Property(e => e.RevType).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderItemComponentId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderItemId).HasMaxLength(36);

                entity.Property(e => e.Sno).HasColumnName("SNo");

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.Title).HasMaxLength(512);

                entity.Property(e => e.Town).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.AssetId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ProjectId);

                entity.HasOne(d => d.Pscomponent)
                    .WithMany(p => p.TaskPscomponents)
                    .HasForeignKey(d => d.PscomponentId);

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.TaskPs)
                    .HasForeignKey(d => d.Psid);

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.SalesOrderItemComponent)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.SalesOrderItemComponentId);

                entity.HasOne(d => d.SalesOrderItem)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.SalesOrderItemId);

                entity.HasOne(d => d.TaskNavigation)
                    .WithMany(p => p.InverseTaskNavigation)
                    .HasForeignKey(d => d.TaskId);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.TaskTypeId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TaskActivity>(entity =>
            {
                entity.HasIndex(e => e.ApprovedUserId, "IX_TaskActivities_ApprovedUserId");

                entity.HasIndex(e => e.CreatedUserId, "IX_TaskActivities_CreatedUserId");

                entity.HasIndex(e => e.Machine2Id, "IX_TaskActivities_Machine2Id");

                entity.HasIndex(e => e.Machine3Id, "IX_TaskActivities_Machine3Id");

                entity.HasIndex(e => e.Machine4Id, "IX_TaskActivities_Machine4Id");

                entity.HasIndex(e => e.MachineId, "IX_TaskActivities_MachineId");

                entity.HasIndex(e => e.TaskId, "IX_TaskActivities_TaskId");

                entity.HasIndex(e => e.TaskTypeId, "IX_TaskActivities_TaskTypeId");

                entity.HasIndex(e => e.UpdatedUserId, "IX_TaskActivities_UpdatedUserId");

                entity.HasIndex(e => e.User2Id, "IX_TaskActivities_User2Id");

                entity.HasIndex(e => e.User3Id, "IX_TaskActivities_User3Id");

                entity.HasIndex(e => e.User4Id, "IX_TaskActivities_User4Id");

                entity.HasIndex(e => e.User5Id, "IX_TaskActivities_User5Id");

                entity.HasIndex(e => e.User6Id, "IX_TaskActivities_User6Id");

                entity.HasIndex(e => e.UserId, "IX_TaskActivities_UserId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AmortisationCost).HasPrecision(18, 6);

                entity.Property(e => e.AmountDefective).HasPrecision(18, 6);

                entity.Property(e => e.AmountDone).HasPrecision(18, 6);

                entity.Property(e => e.ApprovedUserId).HasMaxLength(36);

                entity.Property(e => e.City).HasMaxLength(64);

                entity.Property(e => e.CostTypeId).HasMaxLength(36);

                entity.Property(e => e.Country).HasMaxLength(3);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.CustomerId).HasMaxLength(36);

                entity.Property(e => e.CustomerName).HasMaxLength(256);

                entity.Property(e => e.DefectReasonTypeId).HasMaxLength(36);

                entity.Property(e => e.DefectResponsibleTypeId).HasMaxLength(36);

                entity.Property(e => e.ElectricityCost).HasPrecision(18, 6);

                entity.Property(e => e.EndDate).HasMaxLength(25);

                entity.Property(e => e.ExpenseRecordGroupId).HasMaxLength(36);

                entity.Property(e => e.FuelCost).HasPrecision(18, 6);

                entity.Property(e => e.GasCost).HasPrecision(18, 6);

                entity.Property(e => e.LaborCost).HasPrecision(18, 6);

                entity.Property(e => e.Machine2Id).HasMaxLength(36);

                entity.Property(e => e.Machine3Id).HasMaxLength(36);

                entity.Property(e => e.Machine4Id).HasMaxLength(36);

                entity.Property(e => e.MachineId).HasMaxLength(36);

                entity.Property(e => e.MaterialCost).HasPrecision(18, 6);

                entity.Property(e => e.Note).HasMaxLength(64);

                entity.Property(e => e.ProjectId).HasMaxLength(36);

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StartDate).HasMaxLength(25);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.TaskNo).HasMaxLength(16);

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.Town).HasMaxLength(64);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.User2Id).HasMaxLength(36);

                entity.Property(e => e.User3Id).HasMaxLength(36);

                entity.Property(e => e.User4Id).HasMaxLength(36);

                entity.Property(e => e.User5Id).HasMaxLength(36);

                entity.Property(e => e.User6Id).HasMaxLength(36);

                entity.Property(e => e.UserId).HasMaxLength(36);

                entity.HasOne(d => d.ApprovedUser)
                    .WithMany(p => p.TaskActivityApprovedUsers)
                    .HasForeignKey(d => d.ApprovedUserId);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.TaskActivityCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.Machine2)
                    .WithMany(p => p.TaskActivityMachine2s)
                    .HasForeignKey(d => d.Machine2Id);

                entity.HasOne(d => d.Machine3)
                    .WithMany(p => p.TaskActivityMachine3s)
                    .HasForeignKey(d => d.Machine3Id);

                entity.HasOne(d => d.Machine4)
                    .WithMany(p => p.TaskActivityMachine4s)
                    .HasForeignKey(d => d.Machine4Id);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TaskActivityMachines)
                    .HasForeignKey(d => d.MachineId);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskActivities)
                    .HasForeignKey(d => d.TaskId);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.TaskActivities)
                    .HasForeignKey(d => d.TaskTypeId);

                entity.HasOne(d => d.UpdatedUser)
                    .WithMany(p => p.TaskActivityUpdatedUsers)
                    .HasForeignKey(d => d.UpdatedUserId);

                entity.HasOne(d => d.User2)
                    .WithMany(p => p.TaskActivityUser2s)
                    .HasForeignKey(d => d.User2Id);

                entity.HasOne(d => d.User3)
                    .WithMany(p => p.TaskActivityUser3s)
                    .HasForeignKey(d => d.User3Id);

                entity.HasOne(d => d.User4)
                    .WithMany(p => p.TaskActivityUser4s)
                    .HasForeignKey(d => d.User4Id);

                entity.HasOne(d => d.User5)
                    .WithMany(p => p.TaskActivityUser5s)
                    .HasForeignKey(d => d.User5Id);

                entity.HasOne(d => d.User6)
                    .WithMany(p => p.TaskActivityUser6s)
                    .HasForeignKey(d => d.User6Id);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TaskActivityUsers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TaskActivityAsset>(entity =>
            {
                entity.HasKey(e => new { e.TaskActivityId, e.AssetId });

                entity.HasIndex(e => e.AssetId, "IX_TaskActivityAssets_AssetId");

                entity.HasIndex(e => e.TaskId, "IX_TaskActivityAssets_TaskId");

                entity.Property(e => e.TaskActivityId).HasMaxLength(36);

                entity.Property(e => e.AssetId).HasMaxLength(36);

                entity.Property(e => e.Cost).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.EndDate).HasMaxLength(25);

                entity.Property(e => e.StartDate).HasMaxLength(25);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.TaskActivityAssets)
                    .HasForeignKey(d => d.AssetId);

                entity.HasOne(d => d.TaskActivity)
                    .WithMany(p => p.TaskActivityAssets)
                    .HasForeignKey(d => d.TaskActivityId);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskActivityAssets)
                    .HasForeignKey(d => d.TaskId);
            });

            modelBuilder.Entity<TaskActivityEmployee>(entity =>
            {
                entity.HasKey(e => new { e.TaskActivityId, e.EmployeeId });

                entity.HasIndex(e => e.EmployeeId, "IX_TaskActivityEmployees_EmployeeId");

                entity.HasIndex(e => e.TaskId, "IX_TaskActivityEmployees_TaskId");

                entity.Property(e => e.TaskActivityId).HasMaxLength(36);

                entity.Property(e => e.EmployeeId).HasMaxLength(36);

                entity.Property(e => e.Cost).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.EndDate).HasMaxLength(25);

                entity.Property(e => e.StartDate).HasMaxLength(25);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TaskActivityEmployees)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.TaskActivity)
                    .WithMany(p => p.TaskActivityEmployees)
                    .HasForeignKey(d => d.TaskActivityId);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskActivityEmployees)
                    .HasForeignKey(d => d.TaskId);
            });

            modelBuilder.Entity<TaskActivityInventoryItem>(entity =>
            {
                entity.HasKey(e => new { e.TaskActivityId, e.InventoryItemId });

                entity.HasIndex(e => e.InventoryItemId, "IX_TaskActivityInventoryItems_InventoryItemId");

                entity.HasIndex(e => e.TaskId, "IX_TaskActivityInventoryItems_TaskId");

                entity.Property(e => e.TaskActivityId).HasMaxLength(36);

                entity.Property(e => e.InventoryItemId).HasMaxLength(36);

                entity.Property(e => e.Amount).HasPrecision(18, 6);

                entity.Property(e => e.Cost).HasPrecision(18, 6);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.UnitPrice).HasPrecision(18, 6);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.InventoryItem)
                    .WithMany(p => p.TaskActivityInventoryItems)
                    .HasForeignKey(d => d.InventoryItemId);

                entity.HasOne(d => d.TaskActivity)
                    .WithMany(p => p.TaskActivityInventoryItems)
                    .HasForeignKey(d => d.TaskActivityId);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskActivityInventoryItems)
                    .HasForeignKey(d => d.TaskId);
            });

            modelBuilder.Entity<TaskActivityQcmeasurement>(entity =>
            {
                entity.ToTable("TaskActivityQCMeasurements");

                entity.HasIndex(e => e.CreatedUserId, "IX_TaskActivityQCMeasurements_CreatedUserId");

                entity.HasIndex(e => e.TaskActivityId, "IX_TaskActivityQCMeasurements_TaskActivityId");

                entity.HasIndex(e => e.TaskTypeId, "IX_TaskActivityQCMeasurements_TaskTypeId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.An)
                    .HasMaxLength(64)
                    .HasColumnName("AN");

                entity.Property(e => e.AssetId).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.CustomerName).HasMaxLength(256);

                entity.Property(e => e.Pms)
                    .HasMaxLength(512)
                    .HasColumnName("PMs");

                entity.Property(e => e.ProjectId).HasMaxLength(36);

                entity.Property(e => e.ProjectName).HasMaxLength(128);

                entity.Property(e => e.Psid)
                    .HasMaxLength(36)
                    .HasColumnName("PSId");

                entity.Property(e => e.Psn)
                    .HasMaxLength(512)
                    .HasColumnName("PSN");

                entity.Property(e => e.SalesOrderId).HasMaxLength(36);

                entity.Property(e => e.Sono)
                    .HasMaxLength(16)
                    .HasColumnName("SONo");

                entity.Property(e => e.SorevNo).HasColumnName("SORevNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskActivityId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeId).HasMaxLength(36);

                entity.Property(e => e.TaskTypeTypeId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.TaskActivityQcmeasurements)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.TaskActivity)
                    .WithMany(p => p.TaskActivityQcmeasurements)
                    .HasForeignKey(d => d.TaskActivityId);

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.TaskActivityQcmeasurements)
                    .HasForeignKey(d => d.TaskTypeId);
            });

            modelBuilder.Entity<TaskActivityQcmeasurementMedia>(entity =>
            {
                entity.ToTable("TaskActivityQCMeasurementMedias");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.ContentType).HasMaxLength(84);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(128);

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskActivityId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.Property(e => e.UsageType).HasMaxLength(36);
            });

            modelBuilder.Entity<TaskNote>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_TaskNotes_CreatedUserId");

                entity.HasIndex(e => e.TaskId, "IX_TaskNotes_TaskId");

                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Note).HasMaxLength(128);

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TaskId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.TaskNotes)
                    .HasForeignKey(d => d.CreatedUserId);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskNotes)
                    .HasForeignKey(d => d.TaskId);
            });

            modelBuilder.Entity<TaskType>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(36);

                entity.Property(e => e.AddAutoPsc).HasColumnName("AddAutoPSC");

                entity.Property(e => e.AddAutoSo).HasColumnName("AddAutoSO");

                entity.Property(e => e.CreatedDate).HasMaxLength(19);

                entity.Property(e => e.CreatedUserId).HasMaxLength(36);

                entity.Property(e => e.Description).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(36);

                entity.Property(e => e.ReverseId).HasMaxLength(36);

                entity.Property(e => e.SiteId).HasMaxLength(36);

                entity.Property(e => e.Sno).HasColumnName("SNo");

                entity.Property(e => e.StateId).HasMaxLength(36);

                entity.Property(e => e.TenantId).HasMaxLength(36);

                entity.Property(e => e.TypeId).HasMaxLength(36);

                entity.Property(e => e.UpdatedDate).HasMaxLength(19);

                entity.Property(e => e.UpdatedUserId).HasMaxLength(36);
            });

            modelBuilder.Entity<Urundene2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("urundene2");

                entity.Property(e => e.Psid)
                    .HasColumnType("character varying")
                    .HasColumnName("psid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
