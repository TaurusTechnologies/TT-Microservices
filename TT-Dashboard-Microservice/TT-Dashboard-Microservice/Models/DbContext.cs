using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext()
        {
        }

        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
        public virtual DbSet<AspNetSqlCacheTablesForChangeNotification> AspNetSqlCacheTablesForChangeNotifications { get; set; }
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRole> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }
        public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<CreditCardChargeQueue> CreditCardChargeQueues { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerDocumentTracking> CustomerDocumentTrackings { get; set; }
        public virtual DbSet<CustomerSalesperson> CustomerSalespeople { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeExpirationItem> EmployeeExpirationItems { get; set; }
        public virtual DbSet<EmployeeLoad> EmployeeLoads { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseFile> ExpenseFiles { get; set; }
        public virtual DbSet<ExpenseJournalEntryQueue> ExpenseJournalEntryQueues { get; set; }
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<ExpensesToPushToQb> ExpensesToPushToQbs { get; set; }
        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<Htmltext> Htmltexts { get; set; }
        public virtual DbSet<IndustryType> IndustryTypes { get; set; }
        public virtual DbSet<ItemComment> ItemComments { get; set; }
        public virtual DbSet<ItemFile> ItemFiles { get; set; }
        public virtual DbSet<ItemFollowUp> ItemFollowUps { get; set; }
        public virtual DbSet<ItemFollower> ItemFollowers { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobParameter> JobParameters { get; set; }
        public virtual DbSet<JobQueue> JobQueues { get; set; }
        public virtual DbSet<JournalEntryQueue> JournalEntryQueues { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<LeadAssignment> LeadAssignments { get; set; }
        public virtual DbSet<LeadQuote> LeadQuotes { get; set; }
        public virtual DbSet<LeadQuoteRevision> LeadQuoteRevisions { get; set; }
        public virtual DbSet<LeadQuoteRevisionAssignment> LeadQuoteRevisionAssignments { get; set; }
        public virtual DbSet<LeadStartStopDate> LeadStartStopDates { get; set; }
        public virtual DbSet<LeadType> LeadTypes { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PriceCalculation> PriceCalculations { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectAccountingStatus> ProjectAccountingStatuses { get; set; }
        public virtual DbSet<ProjectAssignment> ProjectAssignments { get; set; }
        public virtual DbSet<ProjectMclproduct> ProjectMclproducts { get; set; }
        public virtual DbSet<ProjectProduct> ProjectProducts { get; set; }
        public virtual DbSet<ProjectProductReceived> ProjectProductReceiveds { get; set; }
        public virtual DbSet<ProjectRoom> ProjectRooms { get; set; }
        public virtual DbSet<ProjectStartStopDate> ProjectStartStopDates { get; set; }
        public virtual DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public virtual DbSet<ProjectTask> ProjectTasks { get; set; }
        public virtual DbSet<ProjectTaskAssignment> ProjectTaskAssignments { get; set; }
        public virtual DbSet<Ptorequest> Ptorequests { get; set; }
        public virtual DbSet<PtorequestDay> PtorequestDays { get; set; }
        public virtual DbSet<Ptostatus> Ptostatuses { get; set; }
        public virtual DbSet<Qbaccount> Qbaccounts { get; set; }
        public virtual DbSet<QbaccountStg> QbaccountStgs { get; set; }
        public virtual DbSet<Qbcustomer> Qbcustomers { get; set; }
        public virtual DbSet<QbcustomerStg> QbcustomerStgs { get; set; }
        public virtual DbSet<Qbemployee> Qbemployees { get; set; }
        public virtual DbSet<QbemployeeStg> QbemployeeStgs { get; set; }
        public virtual DbSet<Qbinvoice> Qbinvoices { get; set; }
        public virtual DbSet<QbinvoiceStg> QbinvoiceStgs { get; set; }
        public virtual DbSet<Qbitem> Qbitems { get; set; }
        public virtual DbSet<QbitemStg> QbitemStgs { get; set; }
        public virtual DbSet<Qbterm> Qbterms { get; set; }
        public virtual DbSet<QbtermStg> QbtermStgs { get; set; }
        public virtual DbSet<Qbvendor> Qbvendors { get; set; }
        public virtual DbSet<QbvendorStg> QbvendorStgs { get; set; }
        public virtual DbSet<QbwageItem> QbwageItems { get; set; }
        public virtual DbSet<QbwageItemStg> QbwageItemStgs { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }
        public virtual DbSet<RevisionRoom> RevisionRooms { get; set; }
        public virtual DbSet<RevisionRoomProductCategory> RevisionRoomProductCategories { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomCategoryLineItem> RoomCategoryLineItems { get; set; }
        public virtual DbSet<RoomServicePlan> RoomServicePlans { get; set; }
        public virtual DbSet<ScheduledEmail> ScheduledEmails { get; set; }
        public virtual DbSet<Schema> Schemas { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<ServicePlan> ServicePlans { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<ShippingCalendarEvent> ShippingCalendarEvents { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<ThirdPartySupportContract> ThirdPartySupportContracts { get; set; }
        public virtual DbSet<TimeClock> TimeClocks { get; set; }
        public virtual DbSet<TimeClockBkup> TimeClockBkups { get; set; }
        public virtual DbSet<TimeLog> TimeLogs { get; set; }
        public virtual DbSet<TroubleTicket> TroubleTickets { get; set; }
        public virtual DbSet<TroubleTicketAssignment> TroubleTicketAssignments { get; set; }
        public virtual DbSet<TroubleTicketDueDate> TroubleTicketDueDates { get; set; }
        public virtual DbSet<TroubleTicketRoom> TroubleTicketRooms { get; set; }
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }
        public virtual DbSet<ZipLatLon> ZipLatLons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=ARIZONA;Initial Catalog=PM_PROD;Persist Security Info=True;User ID=PM;Password=%kENnB3L+Le");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity");

                entity.Property(e => e.BillableRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.Key, "UX_HangFire_CounterAggregated_Key")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AspNetSqlCacheTablesForChangeNotification>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK__AspNet_S__93F7AC6996C2B608");

                entity.ToTable("AspNet_SqlCacheTablesForChangeNotification");

                entity.Property(e => e.TableName).HasColumnName("tableName");

                entity.Property(e => e.ChangeId).HasColumnName("changeId");

                entity.Property(e => e.NotificationCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("notificationCreated")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C9831F9822C")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE43C3060C9")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__309103312D25FCBE")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4DDCAC6946")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__5E8471B4");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__5F7895ED");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC58257C44E5")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__101BCD48");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC590404BF74");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__15D4A69E");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC068B454B3B")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId }, "aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__19A53782");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__1A995BBB");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C51A8EEE8");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__737F8E9A");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B2FEE7BC4")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__7D08F8D4");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC19231EBDF");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D47227967")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__4E4E09EB");
            });

            modelBuilder.Entity<AspnetUsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760AD71EB23EF");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId, "aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__01CDADF1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__00D989B8");
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C81037252AFE");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<CalendarEvent>(entity =>
            {
                entity.ToTable("CalendarEvent");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key, "IX_HangFire_Counter_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CreditCardChargeQueue>(entity =>
            {
                entity.ToTable("CreditCardChargeQueue");

                entity.Property(e => e.CreditCardChargeQueueId).HasColumnName("CreditCardChargeQueueID");

                entity.Property(e => e.AccountRefListId).HasMaxLength(100);

                entity.Property(e => e.ExpenseLineAccountRefListId)
                    .HasMaxLength(100)
                    .HasColumnName("ExpenseLineAccountRefListID");

                entity.Property(e => e.ExpenseLineAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpenseLineBillableStatus).HasMaxLength(100);

                entity.Property(e => e.ExpenseLineCustomerRefListId)
                    .HasMaxLength(100)
                    .HasColumnName("ExpenseLineCustomerRefListID");

                entity.Property(e => e.ExpenseLineSalesRepRefListId)
                    .HasMaxLength(100)
                    .HasColumnName("ExpenseLineSalesRepRefListID");

                entity.Property(e => e.PayeeEntityRefListId).HasMaxLength(100);

                entity.Property(e => e.TxnDate).HasColumnType("datetime");

                entity.Property(e => e.TxnId).HasMaxLength(100);

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.CreditCardChargeQueues)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK__CreditCar__Expen__2816B9EE");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingFaxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingPhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactRole)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Industry)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QbcustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("QBCustomerListId");

                entity.Property(e => e.Source)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Terms).HasMaxLength(250);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IndustryType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.IndustryTypeId)
                    .HasConstraintName("FK_Customer_IndustryType");

                entity.HasOne(d => d.ParentCustomer)
                    .WithMany(p => p.InverseParentCustomer)
                    .HasForeignKey(d => d.ParentCustomerId)
                    .HasConstraintName("FK_Customer_Customer");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_Customer_Team");
            });

            modelBuilder.Entity<CustomerDocumentTracking>(entity =>
            {
                entity.ToTable("CustomerDocumentTracking");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Document).IsRequired();

                entity.Property(e => e.DocumentExpirationDate).HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerDocumentTrackings)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDocumentTracking_Customer");
            });

            modelBuilder.Entity<CustomerSalesperson>(entity =>
            {
                entity.ToTable("CustomerSalesperson");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerSalespeople)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerSalesperson_Customer");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CustomerSalespeople)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerSalesperson_Employee");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistinguishedName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayPayListId).HasMaxLength(200);

                entity.Property(e => e.HolidayPayPayListId).HasMaxLength(200);

                entity.Property(e => e.JuryDutyPayListId).HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerDn)
                    .IsUnicode(false)
                    .HasColumnName("ManagerDN");

                entity.Property(e => e.MandEqbaccountListId)
                    .HasMaxLength(400)
                    .HasColumnName("MandEQBAccountListId");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName10)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName7)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName8)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscName9)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue10)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue7)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue8)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MiscValue9)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OvertimePayListId).HasMaxLength(200);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PtopayListId)
                    .HasMaxLength(200)
                    .HasColumnName("PTOPayListId");

                entity.Property(e => e.QbcreditCardRef)
                    .HasMaxLength(80)
                    .HasColumnName("QBCreditCardRef");

                entity.Property(e => e.QbemployeeListId)
                    .HasMaxLength(200)
                    .HasColumnName("QBEmployeeListID");

                entity.Property(e => e.RegularPayListId).HasMaxLength(200);

                entity.Property(e => e.SamaccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SAMAccountName");

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Location_Employee");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Employee_Employee");

                entity.HasOne(d => d.PurchaseTeam)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PurchaseTeamId)
                    .HasConstraintName("fk_PurchaseTeamId");
            });

            modelBuilder.Entity<EmployeeExpirationItem>(entity =>
            {
                entity.ToTable("EmployeeExpirationItem");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpires).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsSafety)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeExpirationItems)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeExpirationItem_EmployeeId");
            });

            modelBuilder.Entity<EmployeeLoad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeeLoad");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistinguishedName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerDn)
                    .IsUnicode(false)
                    .HasColumnName("ManagerDN");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SAmaccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sAMAccountName");

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.ToTable("Expense");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedByApOn).HasColumnType("datetime");

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(4000);

                entity.Property(e => e.CompanyAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreditCardChargeListId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ExpenseCode)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDate).HasColumnType("date");

                entity.Property(e => e.JournalEntryListId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.Merchant).HasMaxLength(4000);

                entity.Property(e => e.Miles).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PersonalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PushedToQb).HasColumnName("PushedToQB");

                entity.Property(e => e.PushedToQbon)
                    .HasColumnType("datetime")
                    .HasColumnName("PushedToQBOn");

                entity.Property(e => e.RejectReason).IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.TroubleTicketId).HasColumnName("TroubleTicketID");

                entity.Property(e => e.Vendor).HasMaxLength(400);

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.ExpenseApprovedByNavigations)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK__Expense__Approve__0CC4A255");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Expense__Custome__29FF0260");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ExpenseEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Expense__Employe__3DA53D03");

                entity.HasOne(d => d.ExpenseType)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.ExpenseTypeId)
                    .HasConstraintName("FK__Expense__Expense__3AC8D058");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK__Expense__LeadID__2AF32699");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK__Expense__Payment__3BBCF491");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Expense__Project__0D4A0F3E");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .HasConstraintName("FK__Expense__Trouble__39D4AC1F");
            });

            modelBuilder.Entity<ExpenseFile>(entity =>
            {
                entity.ToTable("ExpenseFile");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(800);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ExpenseFiles)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__ExpenseFi__Emplo__2D15D6CC");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.ExpenseFiles)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK__ExpenseFi__Expen__2E09FB05");
            });

            modelBuilder.Entity<ExpenseJournalEntryQueue>(entity =>
            {
                entity.HasKey(e => e.ExpenseJournalEntryId)
                    .HasName("PK__ExpenseJ__DF63D115C4FDD93F");

                entity.ToTable("ExpenseJournalEntryQueue");

                entity.Property(e => e.ExpenseJournalEntryId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillableStatus).HasMaxLength(80);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectCode).HasMaxLength(800);

                entity.Property(e => e.QbcustomerListId)
                    .HasMaxLength(800)
                    .HasColumnName("QBCustomerListID");

                entity.Property(e => e.TxnDate).HasColumnType("datetime");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.ExpenseJournalEntryQueues)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK__ExpenseJo__Expen__4A0B13E8");
            });

            modelBuilder.Entity<ExpenseType>(entity =>
            {
                entity.ToTable("ExpenseType");

                entity.Property(e => e.DefaultAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpenseName).HasMaxLength(500);

                entity.Property(e => e.MileageAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QbaccountListId)
                    .HasMaxLength(200)
                    .HasColumnName("QBAccountListID");

                entity.Property(e => e.QbvendorListId)
                    .HasMaxLength(400)
                    .HasColumnName("QBVendorListId");
            });

            modelBuilder.Entity<ExpensesToPushToQb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ExpensesToPushToQB");

                entity.Property(e => e.AccountType).HasMaxLength(200);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerCustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("CustomerCustomerListID");

                entity.Property(e => e.DefaultAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmployeeCcref)
                    .HasMaxLength(80)
                    .HasColumnName("EmployeeCCRef");

                entity.Property(e => e.EmployeeListId)
                    .HasMaxLength(200)
                    .HasColumnName("EmployeeListID");

                entity.Property(e => e.ExpenseAccountListId)
                    .HasMaxLength(400)
                    .HasColumnName("ExpenseAccountListID");

                entity.Property(e => e.ExpenseCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDate).HasColumnType("date");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.LeadCustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("LeadCustomerListID");

                entity.Property(e => e.Merchant)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PaymentTypeAccountListId)
                    .HasMaxLength(200)
                    .HasColumnName("PaymentTypeAccountListID");

                entity.Property(e => e.PersonalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectCustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("ProjectCustomerListID");

                entity.Property(e => e.TtcustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("TTCustomerListID");

                entity.Property(e => e.VendorListId)
                    .HasMaxLength(200)
                    .HasColumnName("VendorListID");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_Hash_Key");

                entity.HasIndex(e => new { e.Key, e.Field }, "UX_HangFire_Hash_Key_Field")
                    .IsUnique();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Htmltext>(entity =>
            {
                entity.ToTable("HTMLText");

                entity.Property(e => e.HtmltextId).HasColumnName("HTMLTextId");

                entity.Property(e => e.Html)
                    .IsRequired()
                    .HasColumnName("HTML")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<IndustryType>(entity =>
            {
                entity.ToTable("IndustryType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemComment>(entity =>
            {
                entity.ToTable("ItemComment");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ItemComments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ItemComment_Customer");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ItemComments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemComment_Employee");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.ItemComments)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_ItemComment_Lead");

                entity.HasOne(d => d.LeadQuoteRevision)
                    .WithMany(p => p.ItemComments)
                    .HasForeignKey(d => d.LeadQuoteRevisionId)
                    .HasConstraintName("FK_itemcomment_LeadQuoteRevision");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ItemComments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ItemComment_Project");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.ItemComments)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .HasConstraintName("FK_ItemComment_TroubleTicket");
            });

            modelBuilder.Entity<ItemFile>(entity =>
            {
                entity.ToTable("ItemFile");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ThumbnailPath).IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ItemFiles)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ItemFile_Customer");

                entity.HasOne(d => d.EmployeeDocument)
                    .WithMany(p => p.ItemFileEmployeeDocuments)
                    .HasForeignKey(d => d.EmployeeDocumentId)
                    .HasConstraintName("FK_ItemFile_EmployeeDocumentId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ItemFileEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemFile_Employee");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.ItemFiles)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_ItemFile_Lead");

                entity.HasOne(d => d.LeadQuoteRevision)
                    .WithMany(p => p.ItemFiles)
                    .HasForeignKey(d => d.LeadQuoteRevisionId)
                    .HasConstraintName("FK_ItemFile_LeadQuoteRevision");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ItemFiles)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ItemFile_Project");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ItemFiles)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_ItemFile_Room");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.ItemFiles)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .HasConstraintName("FK_ItemFile_TroubleTicket");
            });

            modelBuilder.Entity<ItemFollowUp>(entity =>
            {
                entity.ToTable("ItemFollowUp");

                entity.Property(e => e.FollowUpWhen).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PtorequestId).HasColumnName("PTORequestId");

                entity.HasOne(d => d.AssignedToEmployee)
                    .WithMany(p => p.ItemFollowUps)
                    .HasForeignKey(d => d.AssignedToEmployeeId)
                    .HasConstraintName("FK_ItemFollowUp_Employee");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ItemFollowUps)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ItemFollowUp_Customer");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.ItemFollowUps)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_ItemFollowUp_Lead");

                entity.HasOne(d => d.LeadQuoteRevision)
                    .WithMany(p => p.ItemFollowUps)
                    .HasForeignKey(d => d.LeadQuoteRevisionId)
                    .HasConstraintName("FK_itemfollowup_LeadQuoteRevision");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ItemFollowUps)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ItemFollowUp_Project");

                entity.HasOne(d => d.Ptorequest)
                    .WithMany(p => p.ItemFollowUps)
                    .HasForeignKey(d => d.PtorequestId)
                    .HasConstraintName("FK_ItemFollowUp_PTORequest");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.ItemFollowUps)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .HasConstraintName("FK_ItemFollowUp_TroubleTicket");
            });

            modelBuilder.Entity<ItemFollower>(entity =>
            {
                entity.ToTable("ItemFollower");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ItemFollowers)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ItemFollower_Customer");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ItemFollowers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemFollower_Employee");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.ItemFollowers)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_ItemFollower_Lead");

                entity.HasOne(d => d.LeadQuoteRevision)
                    .WithMany(p => p.ItemFollowers)
                    .HasForeignKey(d => d.LeadQuoteRevisionId)
                    .HasConstraintName("FK_itemfollower_LeadQuoteRevision");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ItemFollowers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ItemFollower_Project");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.ItemFollowers)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .HasConstraintName("FK_ItemFollower_TroubleTicket");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt");

                entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.ToTable("JobParameter", "HangFire");

                entity.HasIndex(e => new { e.JobId, e.Name }, "IX_HangFire_JobParameter_JobIdAndName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("JobQueue", "HangFire");

                entity.HasIndex(e => new { e.Queue, e.FetchedAt }, "IX_HangFire_JobQueue_QueueAndFetchedAt");

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JournalEntryQueue>(entity =>
            {
                entity.HasKey(e => e.ExpenseJournalEntryId)
                    .HasName("PK__JournalE__DF63D1151BDEAFD8");

                entity.ToTable("JournalEntryQueue");

                entity.Property(e => e.ExpenseJournalEntryId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillableStatus).HasMaxLength(80);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectCode).HasMaxLength(800);

                entity.Property(e => e.QbcustomerListId)
                    .HasMaxLength(800)
                    .HasColumnName("QBCustomerListID");

                entity.Property(e => e.TxnDate).HasColumnType("datetime");

                entity.Property(e => e.TxnId).HasMaxLength(100);

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.JournalEntryQueues)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK__JournalEn__Expen__253A4D43");
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.ToTable("Lead");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AnticipatedBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AnticipatedEndDate).HasColumnType("datetime");

                entity.Property(e => e.AnticipatedStartDate).HasColumnType("datetime");

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClosureRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactRole)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DesignApprovalDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Industry)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PricingApprovalDate).HasColumnType("date");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbcustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("QBCustomerListId");

                entity.Property(e => e.Source)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.LeadCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .HasConstraintName("FK_Lead_Employee");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Lead_Customer");

                entity.HasOne(d => d.DesignApprover)
                    .WithMany(p => p.LeadDesignApprovers)
                    .HasForeignKey(d => d.DesignApproverId)
                    .HasConstraintName("FK_Lead_DesignApproverId");

                entity.HasOne(d => d.IndustryType)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.IndustryTypeId)
                    .HasConstraintName("FK_Lead_IndustryType");

                entity.HasOne(d => d.LeadType)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.LeadTypeId)
                    .HasConstraintName("FK_Lead_LeadType");

                entity.HasOne(d => d.PricingApprover)
                    .WithMany(p => p.LeadPricingApprovers)
                    .HasForeignKey(d => d.PricingApproverId)
                    .HasConstraintName("FK_Lead_PricingApproverId");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_Lead_Team");
            });

            modelBuilder.Entity<LeadAssignment>(entity =>
            {
                entity.ToTable("LeadAssignment");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeadAssignments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadAssignment_Employee");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadAssignments)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadAssignment_Lead");
            });

            modelBuilder.Entity<LeadQuote>(entity =>
            {
                entity.ToTable("LeadQuote");

                entity.Property(e => e.BillingAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingPhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingState)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingLocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShippingPhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadQuotes)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadQuote_Lead");
            });

            modelBuilder.Entity<LeadQuoteRevision>(entity =>
            {
                entity.ToTable("LeadQuoteRevision");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DesignApprovedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DesignApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.ManagerApprovedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PricingApprovedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PricingApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedForApprovalBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedForApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.LeadQuote)
                    .WithMany(p => p.LeadQuoteRevisions)
                    .HasForeignKey(d => d.LeadQuoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadQuoteRevision_LeadQuote");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.LeadQuoteRevisions)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_LeadQuoteRevision_Team");
            });

            modelBuilder.Entity<LeadQuoteRevisionAssignment>(entity =>
            {
                entity.ToTable("LeadQuoteRevisionAssignment");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeadQuoteRevisionAssignments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadQRAssignment_Employee");

                entity.HasOne(d => d.LeadQuoteRevision)
                    .WithMany(p => p.LeadQuoteRevisionAssignments)
                    .HasForeignKey(d => d.LeadQuoteRevisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadQRAssignment_Lead");
            });

            modelBuilder.Entity<LeadStartStopDate>(entity =>
            {
                entity.ToTable("LeadStartStopDate");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadStartStopDates)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadStartStopDate_LeadId");
            });

            modelBuilder.Entity<LeadType>(entity =>
            {
                entity.ToTable("LeadType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_List_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(100);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType");

                entity.Property(e => e.Name).HasMaxLength(80);

                entity.Property(e => e.QbaccountListId)
                    .HasMaxLength(200)
                    .HasColumnName("QBAccountListID");
            });

            modelBuilder.Entity<PriceCalculation>(entity =>
            {
                entity.ToTable("PriceCalculation");

                entity.Property(e => e.Percent1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Percent2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Percent3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductTypes)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpperBound1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpperBound2).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PriceCalculations)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceCalculation_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.DefaultMclorder).HasColumnName("DefaultMCLOrder");

                entity.Property(e => e.DefaultMclquantity).HasColumnName("DefaultMCLQuantity");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Eoldate).HasColumnName("EOLDate");

                entity.Property(e => e.IsDefaultOnMcl).HasColumnName("IsDefaultOnMCL");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Msrp)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MSRP");

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.QbvendorId)
                    .HasMaxLength(500)
                    .HasColumnName("QBVendorId");

                entity.Property(e => e.Vendor)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductCategory");

                entity.HasOne(d => d.SupercededBy)
                    .WithMany(p => p.InverseSupercededBy)
                    .HasForeignKey(d => d.SupercededById)
                    .HasConstraintName("FK_Product_Product");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.AccountingCloseDate).HasColumnType("datetime");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Budget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodingBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateServicePlanEnd).HasColumnType("datetime");

                entity.Property(e => e.DateServicePlanStart).HasColumnType("datetime");

                entity.Property(e => e.DateWorkCompleted).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LaborBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LegacyServicePlan)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.ProductActual).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbcustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("QBCustomerListId");

                entity.Property(e => e.ShippingAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingState)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignoffNotes).IsUnicode(false);

                entity.Property(e => e.SignoffSignature).IsUnicode(false);

                entity.Property(e => e.SignoffSubmittedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountingStatus)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.AccountingStatusId)
                    .HasConstraintName("fk_Project_ProjectAccountingStatus");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.ProjectCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .HasConstraintName("FK_Project_CreatedById");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Customer");

                entity.HasOne(d => d.FromQuoteRevision)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.FromQuoteRevisionId)
                    .HasConstraintName("FK_Project_LeadQuoteRevision");

                entity.HasOne(d => d.LeadTechnician)
                    .WithMany(p => p.ProjectLeadTechnicians)
                    .HasForeignKey(d => d.LeadTechnicianId)
                    .HasConstraintName("FK_Project_Employee");

                entity.HasOne(d => d.ProgrammerTechnician)
                    .WithMany(p => p.ProjectProgrammerTechnicians)
                    .HasForeignKey(d => d.ProgrammerTechnicianId)
                    .HasConstraintName("FK_Project_ProgrammerTechnician");

                entity.HasOne(d => d.ServicePlan)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ServicePlanId)
                    .HasConstraintName("FK_Project_ServicePlan");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_Project_Team");
            });

            modelBuilder.Entity<ProjectAccountingStatus>(entity =>
            {
                entity.HasKey(e => e.AccountingStatusId)
                    .HasName("PK__ProjectA__40D26B93C27C92A6");

                entity.ToTable("ProjectAccountingStatus");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectAssignment>(entity =>
            {
                entity.ToTable("ProjectAssignment");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ProjectAssignments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectAssignment_Employee");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectAssignments)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectAssignment_Project");
            });

            modelBuilder.Entity<ProjectMclproduct>(entity =>
            {
                entity.ToTable("ProjectMCLProduct");

                entity.Property(e => e.ProjectMclproductId).HasColumnName("ProjectMCLProductId");

                entity.Property(e => e.BinNumber).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyReason).IsUnicode(false);

                entity.Property(e => e.OrderNotes).IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuotePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SerialNumbers).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vendor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrderedByEmployee)
                    .WithMany(p => p.ProjectMclproductOrderedByEmployees)
                    .HasForeignKey(d => d.OrderedByEmployeeId)
                    .HasConstraintName("FK_ProjectMCLProduct_Employee");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProjectMclproducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProjectMCLProduct_Product");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectMclproducts)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectMCLProduct_Project");

                entity.HasOne(d => d.ReceivedByEmployee)
                    .WithMany(p => p.ProjectMclproductReceivedByEmployees)
                    .HasForeignKey(d => d.ReceivedByEmployeeId)
                    .HasConstraintName("FK_ProjectMCLProduct_Employee1");
            });

            modelBuilder.Entity<ProjectProduct>(entity =>
            {
                entity.ToTable("ProjectProduct");

                entity.Property(e => e.BinNumber).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("ETA");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyReason).IsUnicode(false);

                entity.Property(e => e.OrderNotes).IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuotePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SerialNumbers).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrderedByEmployee)
                    .WithMany(p => p.ProjectProductOrderedByEmployees)
                    .HasForeignKey(d => d.OrderedByEmployeeId)
                    .HasConstraintName("FK_ProjectProduct_Employee");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProjectProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProjectProduct_Product");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectProducts)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProduct_Project");

                entity.HasOne(d => d.ProjectRoom)
                    .WithMany(p => p.ProjectProducts)
                    .HasForeignKey(d => d.ProjectRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProduct_ProjectRoom");

                entity.HasOne(d => d.ReceivedByEmployee)
                    .WithMany(p => p.ProjectProductReceivedByEmployees)
                    .HasForeignKey(d => d.ReceivedByEmployeeId)
                    .HasConstraintName("FK_ProjectProduct_Employee1");
            });

            modelBuilder.Entity<ProjectProductReceived>(entity =>
            {
                entity.ToTable("ProjectProductReceived");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProjectProduct)
                    .WithMany(p => p.ProjectProductReceiveds)
                    .HasForeignKey(d => d.ProjectProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProductReceived_ProjectProduct1");

                entity.HasOne(d => d.ReceivedByEmployee)
                    .WithMany(p => p.ProjectProductReceiveds)
                    .HasForeignKey(d => d.ReceivedByEmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProductReceived_Employee");
            });

            modelBuilder.Entity<ProjectRoom>(entity =>
            {
                entity.ToTable("ProjectRoom");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectRooms)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRoom_Project");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ProjectRooms)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRoom_Room");
            });

            modelBuilder.Entity<ProjectStartStopDate>(entity =>
            {
                entity.ToTable("ProjectStartStopDate");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectStartStopDates)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectStartStopDate_ProjectId");
            });

            modelBuilder.Entity<ProjectStatus>(entity =>
            {
                entity.ToTable("ProjectStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.ToTable("ProjectTask");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ProjectTasks)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ProjectTask_Activity");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectTasks)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTask_Project");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.ProjectTasks)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_ProjectTask_Team");
            });

            modelBuilder.Entity<ProjectTaskAssignment>(entity =>
            {
                entity.ToTable("ProjectTaskAssignment");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ProjectTaskAssignments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTaskAssignment_Employee");

                entity.HasOne(d => d.ProjectTask)
                    .WithMany(p => p.ProjectTaskAssignments)
                    .HasForeignKey(d => d.ProjectTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTaskAssignment_ProjectTask");
            });

            modelBuilder.Entity<Ptorequest>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("PTORequest");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.RejectionReason).IsUnicode(false);

                entity.HasOne(d => d.ApproverNavigation)
                    .WithMany(p => p.PtorequestApproverNavigations)
                    .HasForeignKey(d => d.Approver)
                    .HasConstraintName("FK_PTORequest_Employee2");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PtorequestEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PTORequest_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PtorequestModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PTORequest_Employee1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Ptorequests)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PTORequest_PTOStatus");
            });

            modelBuilder.Entity<PtorequestDay>(entity =>
            {
                entity.ToTable("PTORequestDay");

                entity.Property(e => e.PtorequestDayId).HasColumnName("PTORequestDayId");

                entity.Property(e => e.ForDay).HasColumnType("date");

                entity.Property(e => e.PtorequestId).HasColumnName("PTORequestId");

                entity.HasOne(d => d.Ptorequest)
                    .WithMany(p => p.PtorequestDays)
                    .HasForeignKey(d => d.PtorequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PTORequestDay_PTORequest");
            });

            modelBuilder.Entity<Ptostatus>(entity =>
            {
                entity.ToTable("PTOStatus");

                entity.Property(e => e.PtostatusId).HasColumnName("PTOStatusId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Qbaccount>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("QBAccount");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.AccountNumber).HasMaxLength(200);

                entity.Property(e => e.AccountType).HasMaxLength(200);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankNumber).HasMaxLength(200);

                entity.Property(e => e.Desc).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ParentAccountListId)
                    .HasMaxLength(200)
                    .HasColumnName("ParentAccountListID");

                entity.Property(e => e.SpecialAccountType).HasMaxLength(200);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<QbaccountStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBAccount_stg");

                entity.Property(e => e.AccountNumber).HasMaxLength(200);

                entity.Property(e => e.AccountType).HasMaxLength(200);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankNumber).HasMaxLength(200);

                entity.Property(e => e.Desc).HasMaxLength(200);

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ParentAccountListId)
                    .HasMaxLength(200)
                    .HasColumnName("ParentAccountListID");

                entity.Property(e => e.SpecialAccountType).HasMaxLength(200);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Qbcustomer>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("QBCustomer");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ParentListId)
                    .HasMaxLength(200)
                    .HasColumnName("ParentListID");

                entity.Property(e => e.Phone).HasMaxLength(200);

                entity.Property(e => e.TermsListId)
                    .HasMaxLength(200)
                    .HasColumnName("TermsListID");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<QbcustomerStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBCustomer_stg");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ParentListId)
                    .HasMaxLength(200)
                    .HasColumnName("ParentListID");

                entity.Property(e => e.Phone).HasMaxLength(200);

                entity.Property(e => e.TermsListId)
                    .HasMaxLength(200)
                    .HasColumnName("TermsListID");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Qbemployee>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("QBEmployee");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(400);

                entity.Property(e => e.HiredDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.SickHoursAvailable).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.VacationHoursAvailable).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<QbemployeeStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBEmployee_stg");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(400);

                entity.Property(e => e.HiredDate).HasColumnType("datetime");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.SickHoursAvailable).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.VacationHoursAvailable).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Qbinvoice>(entity =>
            {
                entity.HasKey(e => e.TxnId)
                    .HasName("PK_Invoice");

                entity.ToTable("QBInvoice");

                entity.HasIndex(e => e.Other, "QBInvoice_Idx_Other");

                entity.Property(e => e.TxnId)
                    .HasMaxLength(200)
                    .HasColumnName("TxnID");

                entity.Property(e => e.AppliedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceRemaining).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("CustomerListID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(400)
                    .HasColumnName("PONumber");

                entity.Property(e => e.RefNumber).HasMaxLength(400);

                entity.Property(e => e.SalesTaxTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TermsListId)
                    .HasMaxLength(400)
                    .HasColumnName("TermsListID");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate).HasColumnType("datetime");

                entity.Property(e => e.TxnNumber).HasMaxLength(400);
            });

            modelBuilder.Entity<QbinvoiceStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBInvoice_stg");

                entity.Property(e => e.AppliedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceRemaining).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("CustomerListID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(400)
                    .HasColumnName("PONumber");

                entity.Property(e => e.RefNumber).HasMaxLength(400);

                entity.Property(e => e.SalesTaxTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TermsListId)
                    .HasMaxLength(400)
                    .HasColumnName("TermsListID");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxnDate).HasColumnType("datetime");

                entity.Property(e => e.TxnId)
                    .HasMaxLength(200)
                    .HasColumnName("TxnID");

                entity.Property(e => e.TxnNumber).HasMaxLength(400);
            });

            modelBuilder.Entity<Qbitem>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("QBItem");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<QbitemStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBItem_stg");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<Qbterm>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("QBTerm");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.DiscountPct).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<QbtermStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBTerm_stg");

                entity.Property(e => e.DiscountPct).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Qbvendor>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("QBVendor");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AltAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AltCityStateZip)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AltContact)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AltPhone).IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Classification)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.Note1Date).HasColumnType("datetime");

                entity.Property(e => e.Note2Date).HasColumnType("datetime");

                entity.Property(e => e.Note3Date).HasColumnType("datetime");

                entity.Property(e => e.Note4Date).HasColumnType("datetime");

                entity.Property(e => e.Note5Date).HasColumnType("datetime");

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TermsRef)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.VendorTaxIdent)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTypeRef)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.W9received)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("W9Received");

                entity.Property(e => e.Website)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbvendorStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBVendor_stg");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AltAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AltCityStateZip)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AltContact)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AltPhone).IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Classification)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.Contact)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ListId)
                    .HasMaxLength(500)
                    .HasColumnName("ListID");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.Note1Date).HasColumnType("datetime");

                entity.Property(e => e.Note2Date).HasColumnType("datetime");

                entity.Property(e => e.Note3Date).HasColumnType("datetime");

                entity.Property(e => e.Note4Date).HasColumnType("datetime");

                entity.Property(e => e.Note5Date).HasColumnType("datetime");

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TermsRef)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.VendorTaxIdent)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTypeRef)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.W9received)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("W9Received");

                entity.Property(e => e.Website)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbwageItem>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("QBWageItem");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.WageType).HasMaxLength(200);
            });

            modelBuilder.Entity<QbwageItemStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBWageItem_stg");

                entity.Property(e => e.ListId)
                    .HasMaxLength(200)
                    .HasColumnName("ListID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.WageType).HasMaxLength(200);
            });

            modelBuilder.Entity<QueuedEmail>(entity =>
            {
                entity.ToTable("QueuedEmail");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.DateProcessed).HasColumnType("datetime");

                entity.Property(e => e.DateQueued).HasColumnType("datetime");

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.EmailTokens)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.NotificationKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);
            });

            modelBuilder.Entity<RevisionRoom>(entity =>
            {
                entity.ToTable("RevisionRoom");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DesignTotalOverride).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomTotals).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServicesTotalOverride).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShippingCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShippingMethod)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SowclientRequirements)
                    .HasColumnName("SOWClientRequirements")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SowkeyComponents)
                    .HasColumnName("SOWKeyComponents")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sowsummary)
                    .HasColumnName("SOWSummary")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Taxes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.LeadQuoteRevision)
                    .WithMany(p => p.RevisionRooms)
                    .HasForeignKey(d => d.LeadQuoteRevisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevisionRoom_LeadQuoteRevision");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RevisionRooms)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_RevisionRoom_Room");
            });

            modelBuilder.Entity<RevisionRoomProductCategory>(entity =>
            {
                entity.ToTable("RevisionRoomProductCategory");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.RevisionRoomProductCategories)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevisionRoomProductCategory_ProductCategory");

                entity.HasOne(d => d.RevisionRoom)
                    .WithMany(p => p.RevisionRoomProductCategories)
                    .HasForeignKey(d => d.RevisionRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevisionRoomProductCategory_RevisionRoom");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SowclientRequirements)
                    .HasColumnName("SOWClientRequirements")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SowkeyComponents)
                    .HasColumnName("SOWKeyComponents")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sowsummary)
                    .HasColumnName("SOWSummary")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room__CustomerId__367C1819");
            });

            modelBuilder.Entity<RoomCategoryLineItem>(entity =>
            {
                entity.ToTable("RoomCategoryLineItem");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Expense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Labor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Msrp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MSRP");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OrigMsrp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OrigMSRP");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RoomCategoryLineItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_RoomCategoryLineItem_Product");

                entity.HasOne(d => d.RevisionRoomProductCategory)
                    .WithMany(p => p.RoomCategoryLineItems)
                    .HasForeignKey(d => d.RevisionRoomProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomCategoryLineItem_RevisionRoomProductCategory");
            });

            modelBuilder.Entity<RoomServicePlan>(entity =>
            {
                entity.ToTable("RoomServicePlan");

                entity.Property(e => e.DateServicePlanEnd).HasColumnType("datetime");

                entity.Property(e => e.DateServicePlanStart).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.RoomServicePlans)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomServicePlan_ProjectId");

                entity.HasOne(d => d.RoomCategoryLineItem)
                    .WithMany(p => p.RoomServicePlans)
                    .HasForeignKey(d => d.RoomCategoryLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomServicePlan_RoomCategoryLineItemId");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RoomServicePlans)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomServicePlan_RoomId");
            });

            modelBuilder.Entity<ScheduledEmail>(entity =>
            {
                entity.ToTable("ScheduledEmail");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DailyStartTime).HasColumnType("datetime");

                entity.Property(e => e.EmailTo).HasMaxLength(100);

                entity.Property(e => e.LastEnd).HasColumnType("datetime");

                entity.Property(e => e.LastStart).HasColumnType("datetime");

                entity.Property(e => e.ProcedureName)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<ServicePlan>(entity =>
            {
                entity.ToTable("ServicePlan");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ServicePlans)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ServicePlan_Product");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_Set_Key");

                entity.HasIndex(e => new { e.Key, e.Value }, "UX_HangFire_Set_KeyAndValue")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ShippingCalendarEvent>(entity =>
            {
                entity.ToTable("ShippingCalendarEvent");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "HangFire");

                entity.HasIndex(e => e.JobId, "IX_HangFire_State_JobId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.Property(e => e.CanViewProcurement).HasColumnName("canViewProcurement");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TeamMember>(entity =>
            {
                entity.ToTable("TeamMember");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamMember_Employee");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamMember_Team");
            });

            modelBuilder.Entity<ThirdPartySupportContract>(entity =>
            {
                entity.ToTable("ThirdPartySupportContract");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ThirdPartySupportContracts)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThirdPartySupportContract_Project");
            });

            modelBuilder.Entity<TimeClock>(entity =>
            {
                entity.ToTable("TimeClock");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.ClockIn).HasColumnType("datetime");

                entity.Property(e => e.ClockInLocationX).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ClockInLocationY).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ClockInMethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClockOut).HasColumnType("datetime");

                entity.Property(e => e.ClockOutLocationX).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ClockOutLocationY).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ClockOutMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EditBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.EditReason).IsUnicode(false);

                entity.Property(e => e.OriginalClockIn).HasColumnType("datetime");

                entity.Property(e => e.OriginalClockOut).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TimeClocks)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeClock_Employee");
            });

            modelBuilder.Entity<TimeClockBkup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TimeClockBkup");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.ClockIn).HasColumnType("datetime");

                entity.Property(e => e.ClockInLocationX).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ClockInLocationY).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ClockInMethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClockOut).HasColumnType("datetime");

                entity.Property(e => e.ClockOutLocationX).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ClockOutLocationY).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ClockOutMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EditBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.EditReason).IsUnicode(false);

                entity.Property(e => e.OriginalClockIn).HasColumnType("datetime");

                entity.Property(e => e.OriginalClockOut).HasColumnType("datetime");

                entity.Property(e => e.TimeClockId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TimeLog>(entity =>
            {
                entity.ToTable("TimeLog");

                entity.Property(e => e.ForDate).HasColumnType("datetime");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TimeLogs)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeLog_Activity");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TimeLogs)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_TimeLog_Customer");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TimeLogs)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeLog_Employee");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.TimeLogs)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_TimeLog_Lead");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TimeLogs)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_TimeLog_Project");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.TimeLogs)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .HasConstraintName("FK_TimeLog_TroubleTicket");
            });

            modelBuilder.Entity<TroubleTicket>(entity =>
            {
                entity.ToTable("TroubleTicket");

                entity.Property(e => e.AccountingCloseDate).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDue).HasColumnType("datetime");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbcustomerListId)
                    .HasMaxLength(400)
                    .HasColumnName("QBCustomerListId");

                entity.Property(e => e.SignoffSubmittedBy).HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TroubleTickets)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_TroubleTicket_Customer");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.TroubleTickets)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_TroubleTicket_Lead");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TroubleTickets)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_TroubleTicket_Project");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TroubleTickets)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_TroubleTicket_Team");
            });

            modelBuilder.Entity<TroubleTicketAssignment>(entity =>
            {
                entity.HasKey(e => e.TroubleTicketAssignment1);

                entity.ToTable("TroubleTicketAssignment");

                entity.Property(e => e.TroubleTicketAssignment1).HasColumnName("TroubleTicketAssignment");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TroubleTicketAssignments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TroubleTicketAssignment_Employee");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.TroubleTicketAssignments)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TroubleTicketAssignment_TroubleTicket");
            });

            modelBuilder.Entity<TroubleTicketDueDate>(entity =>
            {
                entity.ToTable("TroubleTicketDueDate");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.TroubleTicketDueDates)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TroubleTicketDueDate_TroubleTicketId");
            });

            modelBuilder.Entity<TroubleTicketRoom>(entity =>
            {
                entity.ToTable("TroubleTicketRoom");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.TroubleTicketRooms)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TroubleTicketRoom_Room");

                entity.HasOne(d => d.TroubleTicket)
                    .WithMany(p => p.TroubleTicketRooms)
                    .HasForeignKey(d => d.TroubleTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TroubleTicketRoom_TroubleTicket");
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZipLatLon>(entity =>
            {
                entity.ToTable("ZipLatLon");

                entity.Property(e => e.Lat).HasColumnType("decimal(20, 10)");

                entity.Property(e => e.Lon).HasColumnType("decimal(20, 10)");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
