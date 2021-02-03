using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;

#nullable disable

namespace Poems.Data.Models
{
    public partial class DNS_Beta_2Context : DbContext
    {
        public DNS_Beta_2Context()
        {
        }

        public DNS_Beta_2Context(DbContextOptions<DNS_Beta_2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AchievedWordsCount> AchievedWordsCounts { get; set; }
        public virtual DbSet<ActionReason> ActionReasons { get; set; }
        public virtual DbSet<AdScreen> AdScreens { get; set; }
        public virtual DbSet<AdType> AdTypes { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookActiveAgain> BookActiveAgains { get; set; }
        public virtual DbSet<BookCategory> BookCategories { get; set; }
        public virtual DbSet<BookContributor> BookContributors { get; set; }
        public virtual DbSet<BookFormat> BookFormats { get; set; }
        public virtual DbSet<BookInputType> BookInputTypes { get; set; }
        public virtual DbSet<BookStopped> BookStoppeds { get; set; }
        public virtual DbSet<BooksTwc> BooksTwcs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<ChannelLocation> ChannelLocations { get; set; }
        public virtual DbSet<ChannelType> ChannelTypes { get; set; }
        public virtual DbSet<CollectedBook> CollectedBooks { get; set; }
        public virtual DbSet<ComplimentaryCopy> ComplimentaryCopies { get; set; }
        public virtual DbSet<ComplimentaryCopyReceptor> ComplimentaryCopyReceptors { get; set; }
        public virtual DbSet<ComplimentaryType> ComplimentaryTypes { get; set; }
        public virtual DbSet<ContentType> ContentTypes { get; set; }
        public virtual DbSet<Contributor> Contributors { get; set; }
        public virtual DbSet<ContributorContributorRole> ContributorContributorRoles { get; set; }
        public virtual DbSet<ContributorProbability> ContributorProbabilities { get; set; }
        public virtual DbSet<ContributorProbabilityDetail> ContributorProbabilityDetails { get; set; }
        public virtual DbSet<ContributorRole> ContributorRoles { get; set; }
        public virtual DbSet<Coordinate> Coordinates { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CoverRatio> CoverRatios { get; set; }
        public virtual DbSet<CssVersionsApi> CssVersionsApis { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyExchange> CurrencyExchanges { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dimension> Dimensions { get; set; }
        public virtual DbSet<Dnslog> Dnslogs { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentActionReason> DocumentActionReasons { get; set; }
        public virtual DbSet<DocumentCategory> DocumentCategories { get; set; }
        public virtual DbSet<DocumentContributor> DocumentContributors { get; set; }
        public virtual DbSet<DocumentPrice> DocumentPrices { get; set; }
        public virtual DbSet<DocumentPriceHistory> DocumentPriceHistories { get; set; }
        public virtual DbSet<DocumentStopped> DocumentStoppeds { get; set; }
        public virtual DbSet<DocumentTag> DocumentTags { get; set; }
        public virtual DbSet<DocumentTask> DocumentTasks { get; set; }
        public virtual DbSet<DocumentTaskAction> DocumentTaskActions { get; set; }
        public virtual DbSet<DocumentTaskFreelancer> DocumentTaskFreelancers { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<ExternalReport> ExternalReports { get; set; }
        public virtual DbSet<FeaturedPanel> FeaturedPanels { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Format> Formats { get; set; }
        public virtual DbSet<FreelancerLanguage> FreelancerLanguages { get; set; }
        public virtual DbSet<FreelancerRole> FreelancerRoles { get; set; }
        public virtual DbSet<FreelancerUser> FreelancerUsers { get; set; }
        public virtual DbSet<FreelancerUserRole> FreelancerUserRoles { get; set; }
        public virtual DbSet<Ftpqueue> Ftpqueues { get; set; }
        public virtual DbSet<IllustratedBook> IllustratedBooks { get; set; }
        public virtual DbSet<ImageResize> ImageResizes { get; set; }
        public virtual DbSet<InputType> InputTypes { get; set; }
        public virtual DbSet<InputTypeCost> InputTypeCosts { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceFile> InvoiceFiles { get; set; }
        public virtual DbSet<Isbnregistration> Isbnregistrations { get; set; }
        public virtual DbSet<IssueDimension> IssueDimensions { get; set; }
        public virtual DbSet<IssueNumber> IssueNumbers { get; set; }
        public virtual DbSet<KartoniatAd> KartoniatAds { get; set; }
        public virtual DbSet<KartoniatTemp100Item> KartoniatTemp100Items { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<LogDownloadIssueImage> LogDownloadIssueImages { get; set; }
        public virtual DbSet<MarktingPlan> MarktingPlans { get; set; }
        public virtual DbSet<MiscellaneousTask> MiscellaneousTasks { get; set; }
        public virtual DbSet<MiscellaneousTaskType> MiscellaneousTaskTypes { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsAuthor> NewsAuthors { get; set; }
        public virtual DbSet<NewsPublisher> NewsPublishers { get; set; }
        public virtual DbSet<NewsTag> NewsTags { get; set; }
        public virtual DbSet<NewsUrlSource> NewsUrlSources { get; set; }
        public virtual DbSet<NumberArabicText> NumberArabicTexts { get; set; }
        public virtual DbSet<OnlineBook> OnlineBooks { get; set; }
        public virtual DbSet<OnlineDocument> OnlineDocuments { get; set; }
        public virtual DbSet<OriginalPublisher> OriginalPublishers { get; set; }
        public virtual DbSet<OriginalPublisherInfo> OriginalPublisherInfos { get; set; }
        public virtual DbSet<PaymentReceipt> PaymentReceipts { get; set; }
        public virtual DbSet<PaymentState> PaymentStates { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Poem> Poems { get; set; }
        public virtual DbSet<PoemContributor> PoemContributors { get; set; }
        public virtual DbSet<PoemEra> PoemEras { get; set; }
        public virtual DbSet<PoemLanguage> PoemLanguages { get; set; }
        public virtual DbSet<PoemStructure> PoemStructures { get; set; }
        public virtual DbSet<PoemTask> PoemTasks { get; set; }
        public virtual DbSet<PoemType> PoemTypes { get; set; }
        public virtual DbSet<PrintingHouse> PrintingHouses { get; set; }
        public virtual DbSet<PriorityQueue> PriorityQueues { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<RandomDocId> RandomDocIds { get; set; }
        public virtual DbSet<RandomDocIds8Digit> RandomDocIds8Digits { get; set; }
        public virtual DbSet<Reason> Reasons { get; set; }
        public virtual DbSet<ReceiptFile> ReceiptFiles { get; set; }
        public virtual DbSet<ResetAchievedCount> ResetAchievedCounts { get; set; }
        public virtual DbSet<ResizeType> ResizeTypes { get; set; }
        public virtual DbSet<RofoufAuthor> RofoufAuthors { get; set; }
        public virtual DbSet<RofoufPublisher> RofoufPublishers { get; set; }
        public virtual DbSet<RofoufStatus> RofoufStatuses { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<SettingStep> SettingSteps { get; set; }
        public virtual DbSet<SettingValue> SettingValues { get; set; }
        public virtual DbSet<SourceFormat> SourceFormats { get; set; }
        public virtual DbSet<SpecialCharacter> SpecialCharacters { get; set; }
        public virtual DbSet<Step> Steps { get; set; }
        public virtual DbSet<StockItem> StockItems { get; set; }
        public virtual DbSet<SvgRequest> SvgRequests { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskAction> TaskActions { get; set; }
        public virtual DbSet<TaskFile> TaskFiles { get; set; }
        public virtual DbSet<TaskFreelancer> TaskFreelancers { get; set; }
        public virtual DbSet<TempBookTitle> TempBookTitles { get; set; }
        public virtual DbSet<TempBookTitles2> TempBookTitles2s { get; set; }
        public virtual DbSet<TempItemNumber> TempItemNumbers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransationReceiptCoverage> TransationReceiptCoverages { get; set; }
        public virtual DbSet<TranslationDetail> TranslationDetails { get; set; }
        public virtual DbSet<TranslationScore> TranslationScores { get; set; }
        public virtual DbSet<UrlSource> UrlSources { get; set; }
        public virtual DbSet<UrlSourceTitle> UrlSourceTitles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<VwBook> VwBooks { get; set; }
        public virtual DbSet<VwDocument> VwDocuments { get; set; }
        public virtual DbSet<VwDocumentTask> VwDocumentTasks { get; set; }
        public virtual DbSet<VwTask> VwTasks { get; set; }
        public virtual DbSet<WaitingList> WaitingLists { get; set; }
        public virtual DbSet<WebsiteCommentatorsStatus> WebsiteCommentatorsStatuses { get; set; }
        public virtual DbSet<WebsiteCommentsStatus> WebsiteCommentsStatuses { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }
        public virtual DbSet<WorkflowStep> WorkflowSteps { get; set; }
        public virtual DbSet<WorkflowStepRole> WorkflowStepRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<AchievedWordsCount>(entity =>
            {
                entity.ToTable("AchievedWordsCount");

                entity.Property(e => e.AchievedWordsCountId).HasColumnName("AchievedWordsCountID");

                entity.Property(e => e.AchievedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RateFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.WordType).HasDefaultValueSql("((2))");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.AchievedWordsCounts)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AchievedWordsCount_Task");
            });

            modelBuilder.Entity<ActionReason>(entity =>
            {
                entity.ToTable("ActionReason");

                entity.Property(e => e.ActionReasonId).HasColumnName("ActionReasonID");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.TaskActionId).HasColumnName("TaskActionID");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.ActionReasons)
                    .HasForeignKey(d => d.ReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionReason_Reason");

                entity.HasOne(d => d.TaskAction)
                    .WithMany(p => p.ActionReasons)
                    .HasForeignKey(d => d.TaskActionId)
                    .HasConstraintName("FK_ActionReason_Task_Action");
            });

            modelBuilder.Entity<AdScreen>(entity =>
            {
                entity.ToTable("AdScreen");

                entity.Property(e => e.AdScreenId).HasColumnName("AdScreenID");

                entity.Property(e => e.AdScreenName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AdType>(entity =>
            {
                entity.ToTable("AdType");

                entity.Property(e => e.AdTypeId).HasColumnName("AdTypeID");

                entity.Property(e => e.AdTypeName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.HasIndex(e => e.DocumentType, "IX_Book_DocumentType");

                entity.HasIndex(e => e.TranslationType, "IX_Book_TranslationType");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.ArticlePublicationDate).HasMaxLength(50);

                entity.Property(e => e.AuthoringLanguageId).HasColumnName("AuthoringLanguageID");

                entity.Property(e => e.BlurbArabic).HasMaxLength(4000);

                entity.Property(e => e.BlurbEnglish).HasMaxLength(4000);

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");

                entity.Property(e => e.DocPageNums).HasMaxLength(50);

                entity.Property(e => e.DueDatePublication).HasColumnType("datetime");

                entity.Property(e => e.EpubCssversion).HasColumnName("EpubCSSVersion");

                entity.Property(e => e.FirstTranslationPublishedDate).HasMaxLength(50);

                entity.Property(e => e.HighPriorityDueDate)
                    .HasColumnType("date")
                    .HasColumnName("HighPriority_DueDate");

                entity.Property(e => e.Hight).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCollected).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCoverPainted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGraphicalNovels).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOld).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSelection).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.IssueNumber).HasMaxLength(50);

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.ItemNumberOld).HasColumnName("item_Number_old");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.OriginalPublicationDate).HasMaxLength(4);

                entity.Property(e => e.OriginalPublishedDate).HasMaxLength(50);

                entity.Property(e => e.PublicationDate).HasColumnType("datetime");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.RoyaltiesType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1=Public Domain / 2=Creative Comman / 3=InCopyRight");

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.ShortTitle).HasMaxLength(80);

                entity.Property(e => e.SourceFormatId).HasColumnName("SourceFormatID");

                entity.Property(e => e.SourceLanguageId).HasColumnName("SourceLanguageID");

                entity.Property(e => e.SubTitleArabic).HasMaxLength(200);

                entity.Property(e => e.SubTitleOriginal).HasMaxLength(200);

                entity.Property(e => e.TitleArabic)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TitleOriginal).HasMaxLength(200);

                entity.Property(e => e.TranslationType).HasMaxLength(50);

                entity.Property(e => e.TypeOfInput).HasMaxLength(100);

                entity.Property(e => e.VolumeNumber).HasMaxLength(10);

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkSheetCode).HasMaxLength(10);

                entity.HasOne(d => d.AuthoringLanguage)
                    .WithMany(p => p.BookAuthoringLanguages)
                    .HasForeignKey(d => d.AuthoringLanguageId)
                    .HasConstraintName("FK_Book_Language_Authoring");

                entity.HasOne(d => d.Issue)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IssueId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Book_IssueNumbers");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.BookLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_Book_Language");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK__Book__PublisherI__086B34A6");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.SeriesId)
                    .HasConstraintName("FK_Book_Series");

                entity.HasOne(d => d.SourceFormat)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.SourceFormatId)
                    .HasConstraintName("FK_Book_SourceFormat");

                entity.HasOne(d => d.SourceLanguage)
                    .WithMany(p => p.BookSourceLanguages)
                    .HasForeignKey(d => d.SourceLanguageId)
                    .HasConstraintName("FK_Book_Language_Source");
            });

            modelBuilder.Entity<BookActiveAgain>(entity =>
            {
                entity.ToTable("BookActiveAgain");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiveAgainDate).HasColumnType("datetime");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.BookStoppedId).HasColumnName("BookStoppedID");

                entity.Property(e => e.Reason).IsRequired();

                entity.Property(e => e.StoppDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BookCategory>(entity =>
            {
                entity.ToTable("Book_Category");

                entity.HasIndex(e => e.BookId, "IX_Book_Category_BookID");

                entity.HasIndex(e => e.CategoryId, "IX_Book_Category_CategoryID");

                entity.Property(e => e.BookCategoryId).HasColumnName("BookCategoryID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookCategories)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_Book_Category_Book");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.BookCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Category_Category");
            });

            modelBuilder.Entity<BookContributor>(entity =>
            {
                entity.ToTable("Book_Contributor");

                entity.HasIndex(e => e.BookId, "IX_Book_Contributor_BookID");

                entity.HasIndex(e => e.ContributorRoleId, "IX_Book_Contributor_ContributorRoleID");

                entity.Property(e => e.BookContributorId).HasColumnName("BookContributorID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.ContributorRoleId).HasColumnName("ContributorRoleID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookContributors)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_Book_Contributor_Book");

                entity.HasOne(d => d.ContributorRole)
                    .WithMany(p => p.BookContributors)
                    .HasForeignKey(d => d.ContributorRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Contributor_Contributor_ContributorRole");
            });

            modelBuilder.Entity<BookFormat>(entity =>
            {
                entity.ToTable("BookFormat");

                entity.HasIndex(e => new { e.BookId, e.FormatId, e.Edition }, "UQ_BookID_EditionID_Edition")
                    .IsUnique();

                entity.Property(e => e.BookFormatId).HasColumnName("BookFormatID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Edition).HasDefaultValueSql("((1))");

                entity.Property(e => e.FormatId).HasColumnName("FormatID");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .HasColumnName("ISBN");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookFormats)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookFormat_Book");

                entity.HasOne(d => d.Format)
                    .WithMany(p => p.BookFormats)
                    .HasForeignKey(d => d.FormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookFormat_Format1");
            });

            modelBuilder.Entity<BookInputType>(entity =>
            {
                entity.ToTable("BookInputType");

                entity.HasIndex(e => new { e.BookId, e.InputTypeId }, "UniqeKey_BookInputType")
                    .IsUnique();

                entity.Property(e => e.BookInputTypeId).HasColumnName("BookInputTypeID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Cost).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostQc)
                    .HasColumnName("CostQC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InputTypeId).HasColumnName("InputTypeID");

                entity.Property(e => e.PagesCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.WordsCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookInputTypes)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_BookInputType_Book");

                entity.HasOne(d => d.InputType)
                    .WithMany(p => p.BookInputTypes)
                    .HasForeignKey(d => d.InputTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookInputType_InputType");
            });

            modelBuilder.Entity<BookStopped>(entity =>
            {
                entity.ToTable("BookStopped");

                entity.Property(e => e.BookStoppedId).HasColumnName("BookStoppedID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Reason).IsRequired();

                entity.Property(e => e.StopDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BooksTwc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BooksTWC");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.TitleArabic).HasMaxLength(255);

                entity.Property(e => e.TitleOriginal).HasMaxLength(255);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasIndex(e => e.TitleArabic, "UQ_Category_TitleArabic")
                    .IsUnique();

                entity.HasIndex(e => e.TitleEnglish, "UQ_Category_TitleEnglish")
                    .IsUnique();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.ItemNumberOld).HasColumnName("item_Number_old");

                entity.Property(e => e.TitleArabic)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TitleEnglish)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("Channel");

                entity.HasIndex(e => e.Name, "UQ_ChannelName_Name")
                    .IsUnique();

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.ChannelTypeId).HasColumnName("ChannelTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.ChannelType)
                    .WithMany(p => p.Channels)
                    .HasForeignKey(d => d.ChannelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChannelName_ChannelType");
            });

            modelBuilder.Entity<ChannelLocation>(entity =>
            {
                entity.ToTable("ChannelLocation");

                entity.HasIndex(e => new { e.ChannelId, e.CountryId, e.Year }, "ChannelCountryYearUnique")
                    .IsUnique();

                entity.Property(e => e.ChannelLocationId).HasColumnName("ChannelLocationID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Telephone).HasMaxLength(150);

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.ChannelLocations)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_Channel_ChannelName");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ChannelLocations)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Channel_Country");
            });

            modelBuilder.Entity<ChannelType>(entity =>
            {
                entity.ToTable("ChannelType");

                entity.HasIndex(e => e.Name, "UQ_ChannelType_Name")
                    .IsUnique();

                entity.Property(e => e.ChannelTypeId).HasColumnName("ChannelTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CollectedBook>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.CollectedFromId).HasColumnName("CollectedFromID");

                entity.Property(e => e.FinalBookId).HasColumnName("FinalBookID");
            });

            modelBuilder.Entity<ComplimentaryCopy>(entity =>
            {
                entity.Property(e => e.ComplimentaryCopyId).HasColumnName("ComplimentaryCopyID");

                entity.Property(e => e.BookFormatId).HasColumnName("BookFormatID");

                entity.Property(e => e.ComplimentaryTypeId).HasColumnName("ComplimentaryTypeID");

                entity.Property(e => e.HandOutDate).HasColumnType("datetime");

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.BookFormat)
                    .WithMany(p => p.ComplimentaryCopies)
                    .HasForeignKey(d => d.BookFormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplimentaryCopy_BookFormat");

                entity.HasOne(d => d.ComplimentaryType)
                    .WithMany(p => p.ComplimentaryCopies)
                    .HasForeignKey(d => d.ComplimentaryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplimentaryCopy_ComplimentaryType");
            });

            modelBuilder.Entity<ComplimentaryCopyReceptor>(entity =>
            {
                entity.HasKey(e => e.ComplimentaryCopyId)
                    .HasName("PK_ComplimentaryCopReceptor");

                entity.ToTable("ComplimentaryCopyReceptor");

                entity.Property(e => e.ComplimentaryCopyId)
                    .ValueGeneratedNever()
                    .HasColumnName("ComplimentaryCopyID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.Property(e => e.FreelancerId).HasColumnName("FreelancerID");

                entity.Property(e => e.OriginalPublisherId).HasColumnName("OriginalPublisherID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.ComplimentaryCopyReceptors)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_ComplimentaryCopyReceptor_Channel");

                entity.HasOne(d => d.OriginalPublisher)
                    .WithMany(p => p.ComplimentaryCopyReceptors)
                    .HasForeignKey(d => d.OriginalPublisherId)
                    .HasConstraintName("FK_ComplimentaryCopyReceptor_OriginalPublisher");
            });

            modelBuilder.Entity<ComplimentaryType>(entity =>
            {
                entity.HasIndex(e => e.TypeName, "UQ_ComplimentaryType_Name")
                    .IsUnique();

                entity.Property(e => e.ComplimentaryTypeId).HasColumnName("ComplimentaryTypeID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ContentType>(entity =>
            {
                entity.ToTable("ContentType");

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");

                entity.Property(e => e.ContentTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");
            });

            modelBuilder.Entity<Contributor>(entity =>
            {
                entity.ToTable("Contributor");

                entity.HasIndex(e => new { e.ArabicName, e.ItemNumber }, "U_Name")
                    .IsUnique();

                entity.Property(e => e.ContributorId).HasColumnName("ContributorID");

                entity.Property(e => e.ArabicName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BioArabic).HasMaxLength(4000);

                entity.Property(e => e.BioOriginal).HasMaxLength(4000);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'Male')");

                entity.Property(e => e.HasPhoto).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.ItemNumberOld).HasColumnName("item_Number_old");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.SentNotificationMail).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContributorContributorRole>(entity =>
            {
                entity.HasKey(e => e.ContributorRoleId);

                entity.ToTable("Contributor_ContributorRole");

                entity.HasIndex(e => e.ContributorId, "IX_Contributor_ContributorRole_ContributorID");

                entity.HasIndex(e => e.RoleId, "IX_Contributor_ContributorRole_RoleID");

                entity.Property(e => e.ContributorRoleId).HasColumnName("ContributorRoleID");

                entity.Property(e => e.ContributorId).HasColumnName("ContributorID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Contributor)
                    .WithMany(p => p.ContributorContributorRoles)
                    .HasForeignKey(d => d.ContributorId)
                    .HasConstraintName("FK_Contributor_ContributorRole_Contributor");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ContributorContributorRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contributor_ContributorRole_ContributorRole");
            });

            modelBuilder.Entity<ContributorProbability>(entity =>
            {
                entity.ToTable("ContributorProbability");

                entity.Property(e => e.ContributorProbabilityId).HasColumnName("ContributorProbabilityID");

                entity.Property(e => e.NotToBeAlone)
                    .HasDefaultValueSql("((0))")
                    .HasComment("");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasComment(" Normal = 1,\r\n Arabized = 2,\r\n MultiTask = 3");
            });

            modelBuilder.Entity<ContributorProbabilityDetail>(entity =>
            {
                entity.ToTable("ContributorProbabilityDetail");

                entity.Property(e => e.ContributorProbabilityDetailId)
                    .HasColumnName("ContributorProbabilityDetailID")
                    .HasComment("");

                entity.Property(e => e.ContributorProbabilityId).HasColumnName("ContributorProbabilityID");

                entity.Property(e => e.Detail).HasComment("            Author = 1,\r\n            Reviewer = 2,\r\n            Translator = 3,\r\n            Editor = 4,\r\n            Compiler = 5,\r\n            Commentator = 6,\r\n            Painter = 7,\r\n            StudiedBy = 8,\r\n            IntroducedBy = 9");

                entity.HasOne(d => d.ContributorProbability)
                    .WithMany(p => p.ContributorProbabilityDetails)
                    .HasForeignKey(d => d.ContributorProbabilityId)
                    .HasConstraintName("FK_ContributorProbabilityDetail_ContributorsProbability");

                entity.HasOne(d => d.DetailNavigation)
                    .WithMany(p => p.ContributorProbabilityDetails)
                    .HasForeignKey(d => d.Detail)
                    .HasConstraintName("FK_ContributorProbabilityDetail_ContributorRole");
            });

            modelBuilder.Entity<ContributorRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_Contributor_Role");

                entity.ToTable("ContributorRole");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Coordinate>(entity =>
            {
                entity.Property(e => e.CoordinateId).HasColumnName("CoordinateID");

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.HasIndex(e => e.Name, "UQ_Country_Name")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CoverRatio>(entity =>
            {
                entity.ToTable("CoverRatio");

                entity.Property(e => e.CoverRatioId).HasColumnName("CoverRatioID");

                entity.Property(e => e.FolderName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CssVersionsApi>(entity =>
            {
                entity.ToTable("CSS_Versions_API");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Csstype).HasColumnName("CSSType");

                entity.Property(e => e.DestinationType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeviceType).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.HasIndex(e => e.Name, "UQ_Currency_Name")
                    .IsUnique();

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Isocode)
                    .HasMaxLength(25)
                    .HasColumnName("ISOCode");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Sign).HasMaxLength(25);
            });

            modelBuilder.Entity<CurrencyExchange>(entity =>
            {
                entity.ToTable("CurrencyExchange");

                entity.Property(e => e.CurrencyExchangeId).HasColumnName("CurrencyExchangeID");

                entity.Property(e => e.CurrencyExchangeDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CurrencyExchanges)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CurrencyExchange_Currency");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Dimension>(entity =>
            {
                entity.Property(e => e.DimensionId).HasColumnName("DimensionID");

                entity.Property(e => e.Device).HasMaxLength(50);

                entity.Property(e => e.DimensionType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.S3path)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("S3Path");

                entity.Property(e => e.Usage).HasMaxLength(50);
            });

            modelBuilder.Entity<Dnslog>(entity =>
            {
                entity.ToTable("DNSLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .HasColumnName("client_name");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("page_Name");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.HasIndex(e => e.DocumentType, "IX_Document_DocumentType");

                entity.HasIndex(e => e.TranslationType, "IX_Document_TranslationType");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.AuthoringLanguageId).HasColumnName("AuthoringLanguageID");

                entity.Property(e => e.BlurbArabic).HasMaxLength(4000);

                entity.Property(e => e.BlurbEnglish).HasMaxLength(4000);

                entity.Property(e => e.HighPriorityDueDate)
                    .HasColumnType("date")
                    .HasColumnName("HighPriority_DueDate");

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PublicationDate).HasColumnType("datetime");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.ShortTitle).HasMaxLength(80);

                entity.Property(e => e.SourceFormatId).HasColumnName("SourceFormatID");

                entity.Property(e => e.SourceLanguageId).HasColumnName("SourceLanguageID");

                entity.Property(e => e.SubTitleArabic).HasMaxLength(200);

                entity.Property(e => e.SubTitleOriginal).HasMaxLength(200);

                entity.Property(e => e.TitleArabic)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TitleOriginal).HasMaxLength(200);

                entity.Property(e => e.TranslationType).HasMaxLength(50);

                entity.Property(e => e.WorkSheetCode).HasMaxLength(10);
            });

            modelBuilder.Entity<DocumentActionReason>(entity =>
            {
                entity.HasKey(e => e.ActionReasonId);

                entity.ToTable("DocumentActionReason");

                entity.Property(e => e.ActionReasonId).HasColumnName("ActionReasonID");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.TaskActionId).HasColumnName("TaskActionID");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.DocumentActionReasons)
                    .HasForeignKey(d => d.ReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentActionReason_Reason");

                entity.HasOne(d => d.TaskAction)
                    .WithMany(p => p.DocumentActionReasons)
                    .HasForeignKey(d => d.TaskActionId)
                    .HasConstraintName("FK_DocumentActionReason_DocumentTask_Action");
            });

            modelBuilder.Entity<DocumentCategory>(entity =>
            {
                entity.ToTable("DocumentCategory");

                entity.HasIndex(e => e.CategoryId, "IX_DocumentCategory_CategoryID");

                entity.HasIndex(e => e.DocumentId, "IX_DocumentCategory_DocumentID");

                entity.Property(e => e.DocumentCategoryId).HasColumnName("DocumentCategoryID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DocumentCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentCategory_Category");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.DocumentCategories)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_DocumentCategory_Document");
            });

            modelBuilder.Entity<DocumentContributor>(entity =>
            {
                entity.ToTable("DocumentContributor");

                entity.HasIndex(e => e.ContributorRoleId, "IX_DocumentContributor_ContributorRoleID");

                entity.HasIndex(e => e.DocumentId, "IX_DocumentContributor_DocumentID");

                entity.Property(e => e.DocumentContributorId).HasColumnName("DocumentContributorID");

                entity.Property(e => e.ContributorRoleId).HasColumnName("ContributorRoleID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.HasOne(d => d.ContributorRole)
                    .WithMany(p => p.DocumentContributors)
                    .HasForeignKey(d => d.ContributorRoleId)
                    .HasConstraintName("FK_Document_Contributor_Contributor_ContributorRole");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.DocumentContributors)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_DocumentContributor_Document");
            });

            modelBuilder.Entity<DocumentPrice>(entity =>
            {
                entity.HasKey(e => e.DocuemntPriceId);

                entity.ToTable("DocumentPrice");

                entity.Property(e => e.DocuemntPriceId).HasColumnName("DocuemntPriceID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.DocumentPrices)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentPrice_Currency");
            });

            modelBuilder.Entity<DocumentPriceHistory>(entity =>
            {
                entity.ToTable("DocumentPriceHistory");

                entity.Property(e => e.DocumentPriceHistoryId).HasColumnName("DocumentPriceHistoryID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.DocumentPriceHistories)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_DocumentPriceHistory_Currency");
            });

            modelBuilder.Entity<DocumentStopped>(entity =>
            {
                entity.ToTable("DocumentStopped");

                entity.Property(e => e.DocumentStoppedId).HasColumnName("DocumentStoppedID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Reason).IsRequired();

                entity.Property(e => e.StopDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<DocumentTag>(entity =>
            {
                entity.ToTable("DocumentTag");

                entity.HasIndex(e => new { e.DocumentId, e.TagId }, "UQ_DocumentID_TagID")
                    .IsUnique();

                entity.Property(e => e.DocumentTagId).HasColumnName("DocumentTagID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.DocumentTags)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_DocumentTag_Book");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.DocumentTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentTag_Tag");
            });

            modelBuilder.Entity<DocumentTask>(entity =>
            {
                entity.HasKey(e => e.DocumentTasksId);

                entity.Property(e => e.DocumentTasksId).HasColumnName("DocumentTasksID");

                entity.Property(e => e.ActualEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.EstimatedEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Fes).HasColumnName("FEs");

                entity.Property(e => e.HourCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pes).HasColumnName("PEs");

                entity.Property(e => e.PreviousTaskId).HasColumnName("PreviousTaskID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.DocumentTasks)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_DocumentTask_Document");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.DocumentTasks)
                    .HasForeignKey(d => d.StepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentTask_Step");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.DocumentTasks)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_DocumentTask_User_Role");
            });

            modelBuilder.Entity<DocumentTaskAction>(entity =>
            {
                entity.HasKey(e => e.TaskActionId);

                entity.ToTable("DocumentTask_Action");

                entity.HasIndex(e => new { e.DocumentTasksId, e.Action }, "IX_DocumentTaskID_Action");

                entity.HasIndex(e => new { e.DocumentTasksId, e.Date }, "IX_DocumentTaskID_Date");

                entity.Property(e => e.TaskActionId).HasColumnName("TaskActionID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Comment).HasComment("The Comment of all selected reasons");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DocumentTasksId).HasColumnName("DocumentTasksID");

                entity.Property(e => e.IsNormal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.TargetTaskId).HasColumnName("TargetTaskID");

                entity.HasOne(d => d.DocumentTasks)
                    .WithMany(p => p.DocumentTaskActions)
                    .HasForeignKey(d => d.DocumentTasksId)
                    .HasConstraintName("FK_DocumentTask_Action_DocumentTasks");
            });

            modelBuilder.Entity<DocumentTaskFreelancer>(entity =>
            {
                entity.Property(e => e.DocumentTaskFreelancerId).HasColumnName("DocumentTaskFreelancerID");

                entity.Property(e => e.DocumentTaskId).HasColumnName("DocumentTaskID");

                entity.Property(e => e.FreelancerRoleId).HasColumnName("FreelancerRoleID");

                entity.HasOne(d => d.DocumentTask)
                    .WithMany(p => p.DocumentTaskFreelancers)
                    .HasForeignKey(d => d.DocumentTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentTaskFreelancers_DocumentTasks");

                entity.HasOne(d => d.FreelancerRole)
                    .WithMany(p => p.DocumentTaskFreelancers)
                    .HasForeignKey(d => d.FreelancerRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentTaskFreelancers_FreelancerUser_Role");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("DocumentType");

                entity.Property(e => e.DocumentTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("DocumentTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ExternalReport>(entity =>
            {
                entity.ToTable("ExternalReport");

                entity.Property(e => e.ExternalReportId).HasColumnName("ExternalReportID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DomainUrl)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("DomainURL");

                entity.Property(e => e.ReportTitle)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RouteUrl)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("RouteURL");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.TypePrefix)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<FeaturedPanel>(entity =>
            {
                entity.Property(e => e.FeaturedPanelId).HasColumnName("FeaturedPanelID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Format>(entity =>
            {
                entity.ToTable("Format");

                entity.HasIndex(e => e.Name, "UQ_Name")
                    .IsUnique();

                entity.Property(e => e.FormatId).HasColumnName("FormatID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<FreelancerLanguage>(entity =>
            {
                entity.ToTable("Freelancer_Language");

                entity.Property(e => e.FreelancerLanguageId).HasColumnName("FreelancerLanguageID");

                entity.Property(e => e.FreelancerId).HasColumnName("FreelancerID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.HasOne(d => d.Freelancer)
                    .WithMany(p => p.FreelancerLanguages)
                    .HasForeignKey(d => d.FreelancerId)
                    .HasConstraintName("FK_Freelancer_Language_Freelancer_User");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FreelancerLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Freelancer_Language_Language");
            });

            modelBuilder.Entity<FreelancerRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("FreelancerRole");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FreelancerUser>(entity =>
            {
                entity.HasKey(e => e.FreelancerId);

                entity.ToTable("Freelancer_User");

                entity.Property(e => e.FreelancerId).HasColumnName("FreelancerID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Telephone).HasMaxLength(50);
            });

            modelBuilder.Entity<FreelancerUserRole>(entity =>
            {
                entity.HasKey(e => e.FreelancerRoleId);

                entity.ToTable("FreelancerUser_Role");

                entity.Property(e => e.FreelancerRoleId).HasColumnName("FreelancerRoleID");

                entity.Property(e => e.FreelancerId).HasColumnName("FreelancerID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Freelancer)
                    .WithMany(p => p.FreelancerUserRoles)
                    .HasForeignKey(d => d.FreelancerId)
                    .HasConstraintName("FK_FreelancerUser_Role_Freelancer_User");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FreelancerUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FreelancerUser_Role_Role");
            });

            modelBuilder.Entity<Ftpqueue>(entity =>
            {
                entity.ToTable("FTPQueue");

                entity.HasIndex(e => new { e.ItemNumber, e.Doctype }, "itemNubmerDoctypeUnique")
                    .IsUnique();

                entity.Property(e => e.FtpqueueId).HasColumnName("FTPQueueID");

                entity.Property(e => e.Doctype)
                    .HasMaxLength(50)
                    .HasComment("Doctype may be  'Issue' or 'Article' or 'CSS'");
            });

            modelBuilder.Entity<IllustratedBook>(entity =>
            {
                entity.ToTable("IllustratedBook");

                entity.Property(e => e.IllustratedBookId).HasColumnName("IllustratedBookID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.OnlineOptions).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeriesPrefix).HasMaxLength(25);
            });

            modelBuilder.Entity<ImageResize>(entity =>
            {
                entity.ToTable("ImageResize");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InputType>(entity =>
            {
                entity.ToTable("InputType");

                entity.Property(e => e.InputTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("InputTypeID");

                entity.Property(e => e.CostQc).HasColumnName("CostQC");

                entity.Property(e => e.InputTypeNameAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InputTypeNameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InputTypeCost>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostDate).HasColumnType("date");

                entity.Property(e => e.CostQc).HasColumnName("CostQC");

                entity.Property(e => e.InputTypeId).HasColumnName("InputTypeID");

                entity.HasOne(d => d.InputType)
                    .WithMany(p => p.InputTypeCosts)
                    .HasForeignKey(d => d.InputTypeId)
                    .HasConstraintName("FK_InputTypeCosts_InputType");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.HasIndex(e => e.InvoiceNumber, "UQ_Invoice_Number")
                    .IsUnique();

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ChannelLocationId).HasColumnName("ChannelLocationID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentStateId)
                    .HasColumnName("PaymentStateID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.ChannelLocation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ChannelLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Channel");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Currency");

                entity.HasOne(d => d.PaymentState)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.PaymentStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_PaymentState");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_User");
            });

            modelBuilder.Entity<InvoiceFile>(entity =>
            {
                entity.ToTable("InvoiceFile");

                entity.Property(e => e.InvoiceFileId).HasColumnName("InvoiceFileID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UploadDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceFiles)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceFile_Invoice");
            });

            modelBuilder.Entity<Isbnregistration>(entity =>
            {
                entity.ToTable("ISBNRegistration");

                entity.Property(e => e.IsbnregistrationId).HasColumnName("ISBNRegistrationID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.DigitalIsbn)
                    .HasMaxLength(13)
                    .HasColumnName("DigitalISBN");

                entity.Property(e => e.DigitalRegistrationNumber).HasMaxLength(13);

                entity.Property(e => e.OriginalIsbn)
                    .HasMaxLength(13)
                    .HasColumnName("OriginalISBN");

                entity.Property(e => e.PrintedIsbn)
                    .HasMaxLength(13)
                    .HasColumnName("PrintedISBN");

                entity.Property(e => e.PrintedRegistrationNumber).HasMaxLength(13);
            });

            modelBuilder.Entity<IssueDimension>(entity =>
            {
                entity.HasKey(e => new { e.DimensionId, e.IssueId });

                entity.Property(e => e.DimensionId).HasColumnName("DimensionID");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.UploadDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IssueNumber>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.HasIndex(e => new { e.IssueNumber1, e.Year }, "UK_IssueNumbers_Year")
                    .IsUnique();

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.IssueNumber1)
                    .HasMaxLength(50)
                    .HasColumnName("IssueNumber");

                entity.Property(e => e.IssueTitle).HasMaxLength(255);

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.Property(e => e.Year).HasMaxLength(4);
            });

            modelBuilder.Entity<KartoniatAd>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.HasIndex(e => e.Guid, "UQ_KartoniatAds_GUID")
                    .IsUnique();

                entity.Property(e => e.AdsId).HasColumnName("AdsID");

                entity.Property(e => e.AdScreenId).HasColumnName("AdScreenID");

                entity.Property(e => e.AdTypeId).HasColumnName("AdTypeID");

                entity.Property(e => e.ArchiveDate).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemNumber).HasColumnName("Item_Number");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(256);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.HasOne(d => d.AdScreen)
                    .WithMany(p => p.KartoniatAds)
                    .HasForeignKey(d => d.AdScreenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KartoniatAds_AdScreen");

                entity.HasOne(d => d.AdType)
                    .WithMany(p => p.KartoniatAds)
                    .HasForeignKey(d => d.AdTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KartoniatAds_AdType");
            });

            modelBuilder.Entity<KartoniatTemp100Item>(entity =>
            {
                entity.HasKey(e => e.Number)
                    .HasName("PK_Temp100Item");

                entity.ToTable("KartoniatTemp100Item");

                entity.Property(e => e.Number).ValueGeneratedNever();
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.HasIndex(e => e.TitleArabic, "UQ_Language_TitleArabic")
                    .IsUnique();

                entity.HasIndex(e => e.TitleEnglish, "UQ_Language_TitleEnglish")
                    .IsUnique();

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.TitleArabic)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TitleEnglish)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.T).HasMaxLength(25);
            });

            modelBuilder.Entity<LogDownloadIssueImage>(entity =>
            {
                entity.HasKey(e => e.LogDownloadIssueImagesId);

                entity.ToTable("Log_DownloadIssueImages");

                entity.Property(e => e.LogDownloadIssueImagesId).HasColumnName("Log_DownloadIssueImages_ID");

                entity.Property(e => e.LogType).HasComment("0 = issue\r\n1= article\r\n");
            });

            modelBuilder.Entity<MarktingPlan>(entity =>
            {
                entity.ToTable("MarktingPlan");

                entity.Property(e => e.MarktingPlanId).HasColumnName("MarktingPlanID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.FinishedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.MarktingPlans)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarktingPlan_Book");
            });

            modelBuilder.Entity<MiscellaneousTask>(entity =>
            {
                entity.ToTable("MiscellaneousTask");

                entity.HasIndex(e => e.UserRoleId, "IX_MiscellaneousTask_UserRoleID");

                entity.Property(e => e.MiscellaneousTaskId).HasColumnName("MiscellaneousTaskID");

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.From).HasColumnType("datetime");

                entity.Property(e => e.MiscellaneousTaskTypeId)
                    .HasColumnName("MiscellaneousTaskTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.To).HasColumnType("datetime");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.HasOne(d => d.MiscellaneousTaskType)
                    .WithMany(p => p.MiscellaneousTasks)
                    .HasForeignKey(d => d.MiscellaneousTaskTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MiscellaneousTask_MiscellaneousTaskType");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.MiscellaneousTasks)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MiscellaneousTask_User_Role");
            });

            modelBuilder.Entity<MiscellaneousTaskType>(entity =>
            {
                entity.ToTable("MiscellaneousTaskType");

                entity.HasIndex(e => e.Name, "UQ_MiscellaneousTaskType_Name")
                    .IsUnique();

                entity.Property(e => e.MiscellaneousTaskTypeId).HasColumnName("MiscellaneousTaskTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExactTimeFrom).HasColumnType("time(0)");

                entity.Property(e => e.ExactTimeTo).HasColumnType("time(0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_News_Document");
            });

            modelBuilder.Entity<NewsAuthor>(entity =>
            {
                entity.HasKey(e => e.AuthorId)
                    .HasName("PK_AuthorID");

                entity.ToTable("NewsAuthor");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.ArabicName).HasMaxLength(500);

                entity.Property(e => e.EnglishName).HasMaxLength(500);

                entity.Property(e => e.ItemNumber).HasColumnName("Item_Number");
            });

            modelBuilder.Entity<NewsPublisher>(entity =>
            {
                entity.HasKey(e => e.PublisherId)
                    .HasName("PK_PublisherID");

                entity.ToTable("NewsPublisher");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.ItemNumber).HasColumnName("Item_Number");

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<NewsTag>(entity =>
            {
                entity.ToTable("NewsTag");

                entity.Property(e => e.NewsTagId).HasColumnName("NewsTagID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.NewsTags)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsTag_Document");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.NewsTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsTag_Tag");
            });

            modelBuilder.Entity<NewsUrlSource>(entity =>
            {
                entity.HasKey(e => e.NewSourceId)
                    .HasName("PK_NewSourceID");

                entity.Property(e => e.NewSourceId).HasColumnName("NewSourceID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.NewsUrlSources)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_NewsUrlSources_Document");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.NewsUrlSources)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK_NewsUrlSources_NewsPublisher");
            });

            modelBuilder.Entity<NumberArabicText>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("NumberArabicText");

                entity.Property(e => e.Number).ValueGeneratedNever();

                entity.Property(e => e.ArabicTextNumber)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<OnlineBook>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.ToTable("OnlineBook");

                entity.Property(e => e.BookId)
                    .ValueGeneratedNever()
                    .HasColumnName("BookID");

                entity.Property(e => e.BookCodeAr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BookCodeAR");

                entity.Property(e => e.BookCodeEn)
                    .HasMaxLength(255)
                    .HasColumnName("BookCodeEN");

                entity.Property(e => e.BookIntroSummaryAr)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("BookIntroSummaryAR");

                entity.Property(e => e.BookIntroSummaryEn)
                    .HasMaxLength(4000)
                    .HasColumnName("BookIntroSummaryEN");

                entity.Property(e => e.BookTitleAr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BookTitleAR");

                entity.Property(e => e.BookTitleEn)
                    .HasMaxLength(255)
                    .HasColumnName("BookTitleEN");

                entity.Property(e => e.KalimatBookId).HasColumnName("KalimatBookID");
            });

            modelBuilder.Entity<OnlineDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("OnlineDocument");

                entity.Property(e => e.DocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("DocumentID");

                entity.Property(e => e.DocumentCodeAr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("DocumentCodeAR");

                entity.Property(e => e.DocumentCodeEn)
                    .HasMaxLength(255)
                    .HasColumnName("DocumentCodeEN");

                entity.Property(e => e.DocumentIntroSummaryAr)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("DocumentIntroSummaryAR");

                entity.Property(e => e.DocumentIntroSummaryEn)
                    .HasMaxLength(4000)
                    .HasColumnName("DocumentIntroSummaryEN");

                entity.Property(e => e.DocumentTitleAr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("DocumentTitleAR");

                entity.Property(e => e.DocumentTitleEn)
                    .HasMaxLength(255)
                    .HasColumnName("DocumentTitleEN");

                entity.Property(e => e.KalimatDocumentId).HasColumnName("KalimatDocumentID");
            });

            modelBuilder.Entity<OriginalPublisher>(entity =>
            {
                entity.ToTable("OriginalPublisher");

                entity.Property(e => e.OriginalPublisherId).HasColumnName("OriginalPublisherID");

                entity.Property(e => e.ArabicName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<OriginalPublisherInfo>(entity =>
            {
                entity.ToTable("OriginalPublisherInfo");

                entity.Property(e => e.OriginalPublisherInfoId).HasColumnName("OriginalPublisherInfoID");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.OriginalPublisherId).HasColumnName("OriginalPublisherID");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.HasOne(d => d.OriginalPublisher)
                    .WithMany(p => p.OriginalPublisherInfos)
                    .HasForeignKey(d => d.OriginalPublisherId)
                    .HasConstraintName("FK_OriginalPublisherInfo_OriginalPublisher");
            });

            modelBuilder.Entity<PaymentReceipt>(entity =>
            {
                entity.ToTable("PaymentReceipt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrencyId).HasDefaultValueSql("((52))");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReceiptNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.ChannelLocation)
                    .WithMany(p => p.PaymentReceipts)
                    .HasForeignKey(d => d.ChannelLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReceipt_ChannelLocation");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PaymentReceipts)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReceipt_Currency");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.PaymentReceipts)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReceipt_PaymentType");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.PaymentReceipts)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReceipt_User");
            });

            modelBuilder.Entity<PaymentState>(entity =>
            {
                entity.ToTable("PaymentState");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType");

                entity.HasIndex(e => e.Name, "PaymentTypeNameUnique")
                    .IsUnique();

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<Poem>(entity =>
            {
                entity.Property(e => e.AboutPoetTitleA).HasMaxLength(255);

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.PoemCause).HasMaxLength(255);

                entity.Property(e => e.PoemEraId).HasColumnName("PoemEraID");

                entity.Property(e => e.PoemLanguageId).HasColumnName("PoemLanguageID");

                entity.Property(e => e.PoemPurpose).HasMaxLength(255);

                entity.Property(e => e.PoemStructureId).HasColumnName("PoemStructureID");

                entity.Property(e => e.PoemTitle).HasMaxLength(255);

                entity.Property(e => e.PoemTypeId).HasColumnName("PoemTypeID");

                entity.Property(e => e.PublishingDate).HasColumnType("datetime");

                entity.HasOne(d => d.PoemEra)
                    .WithMany(p => p.Poems)
                    .HasForeignKey(d => d.PoemEraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poems_Poem_Era");

                entity.HasOne(d => d.PoemLanguage)
                    .WithMany(p => p.Poems)
                    .HasForeignKey(d => d.PoemLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poems_Poem_Language");

                entity.HasOne(d => d.PoemStructure)
                    .WithMany(p => p.Poems)
                    .HasForeignKey(d => d.PoemStructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poems_Poem_Structure");

                entity.HasOne(d => d.PoemType)
                    .WithMany(p => p.Poems)
                    .HasForeignKey(d => d.PoemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poems_Poem_Type");
            });

            modelBuilder.Entity<PoemContributor>(entity =>
            {
                entity.ToTable("Poem_Contributor");

                entity.Property(e => e.PoemContributorId).HasColumnName("PoemContributorID");

                entity.Property(e => e.ContributorRoleId).HasColumnName("ContributorRoleID");

                entity.HasOne(d => d.ContributorRole)
                    .WithMany(p => p.PoemContributors)
                    .HasForeignKey(d => d.ContributorRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poem_Contributor_Contributor_ContributorRole");

                entity.HasOne(d => d.Poem)
                    .WithMany(p => p.PoemContributors)
                    .HasForeignKey(d => d.PoemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poem_Contributor_Poems");
            });

            modelBuilder.Entity<PoemEra>(entity =>
            {
                entity.HasKey(e => e.EraId)
                    .HasName("PK__Poem_Era__0FEF67E0C31BB964");

                entity.ToTable("Poem_Era");

                entity.Property(e => e.PoemEra1)
                    .HasMaxLength(50)
                    .HasColumnName("PoemEra");
            });

            modelBuilder.Entity<PoemLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK__Poem_Lan__B93855AB1DE3951F");

                entity.ToTable("Poem_Language");

                entity.Property(e => e.PoemLanguage1)
                    .HasMaxLength(50)
                    .HasColumnName("PoemLanguage");
            });

            modelBuilder.Entity<PoemStructure>(entity =>
            {
                entity.HasKey(e => e.StructureId)
                    .HasName("PK__Poem_Str__4A1C07AB14B6B539");

                entity.ToTable("Poem_Structure");

                entity.Property(e => e.PoemStructure1)
                    .HasMaxLength(50)
                    .HasColumnName("PoemStructure");
            });

            modelBuilder.Entity<PoemTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK__PoemTask__7C6949D176504650");

                entity.ToTable("PoemTask");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.ActualEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EstimatedEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Fes).HasColumnName("FEs");

                entity.Property(e => e.HourCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pes).HasColumnName("PEs");

                entity.Property(e => e.PreviousTaskId).HasColumnName("PreviousTaskID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.WorkflowStepId).HasColumnName("WorkflowStepID");

                entity.HasOne(d => d.Poem)
                    .WithMany(p => p.PoemTasks)
                    .HasForeignKey(d => d.PoemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoemTask_Poems");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.PoemTasks)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_PoemTask_User_Role");
            });

            modelBuilder.Entity<PoemType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__Poem_Typ__516F03B501A51319");

                entity.ToTable("Poem_Type");

                entity.Property(e => e.PoemType1)
                    .HasMaxLength(50)
                    .HasColumnName("PoemType");
            });

            modelBuilder.Entity<PrintingHouse>(entity =>
            {
                entity.ToTable("PrintingHouse");

                entity.HasIndex(e => e.Name, "UQ_PrintingHouse_Name")
                    .IsUnique();

                entity.Property(e => e.PrintingHouseId).HasColumnName("PrintingHouseID");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(255);
            });

            modelBuilder.Entity<PriorityQueue>(entity =>
            {
                entity.HasKey(e => e.PriorityId);

                entity.ToTable("PriorityQueue");

                entity.Property(e => e.PriorityId).HasColumnName("PriorityID");

                entity.Property(e => e.PriorityName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("Publisher");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EnglishName).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.Uri).HasMaxLength(100);

                entity.Property(e => e.UrlCode).HasMaxLength(50);
            });

            modelBuilder.Entity<RandomDocId>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.Property(e => e.Number).ValueGeneratedNever();

                entity.Property(e => e.Used).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RandomDocIds8Digit>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.HasIndex(e => e.NumberOrder, "IX_RandomDocIds8Digits_NumberOrder");

                entity.HasIndex(e => e.Used, "IX_RandomDocIds8Digits_Used");

                entity.Property(e => e.Number).ValueGeneratedNever();
            });

            modelBuilder.Entity<Reason>(entity =>
            {
                entity.ToTable("Reason");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ReceiptFile>(entity =>
            {
                entity.ToTable("ReceiptFile");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UploadDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.ReceiptFiles)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptFile_PaymentReceipt");
            });

            modelBuilder.Entity<ResetAchievedCount>(entity =>
            {
                entity.ToTable("ResetAchievedCount");

                entity.HasIndex(e => e.TaskId, "UQ_ResetAchievedCount_TaskID")
                    .IsUnique();

                entity.Property(e => e.ResetAchievedCountId).HasColumnName("ResetAchievedCountID");

                entity.Property(e => e.ResetCount)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Task)
                    .WithOne(p => p.ResetAchievedCount)
                    .HasForeignKey<ResetAchievedCount>(d => d.TaskId)
                    .HasConstraintName("FK_ResetAchievedCount_Task");
            });

            modelBuilder.Entity<ResizeType>(entity =>
            {
                entity.HasKey(e => e.ResizeId);

                entity.Property(e => e.ResizeId).HasColumnName("ResizeID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ResizeDimension)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ResizeType1).HasColumnName("ResizeType");
            });

            modelBuilder.Entity<RofoufAuthor>(entity =>
            {
                entity.Property(e => e.RofoufAuthorId).HasColumnName("RofoufAuthorID");

                entity.Property(e => e.AuthorName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RofoufFileId).HasColumnName("RofoufFileID");

                entity.HasOne(d => d.RofoufFile)
                    .WithMany(p => p.RofoufAuthors)
                    .HasForeignKey(d => d.RofoufFileId)
                    .HasConstraintName("FK_RofoufAuthors_RofoufStatus");
            });

            modelBuilder.Entity<RofoufPublisher>(entity =>
            {
                entity.Property(e => e.RofoufPublisherId).HasColumnName("RofoufPublisherID");

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RofoufFileId).HasColumnName("RofoufFileID");

                entity.HasOne(d => d.RofoufFile)
                    .WithMany(p => p.RofoufPublishers)
                    .HasForeignKey(d => d.RofoufFileId)
                    .HasConstraintName("FK_RofoufPublishers_RofoufStatus");
            });

            modelBuilder.Entity<RofoufStatus>(entity =>
            {
                entity.HasKey(e => e.RofoufFileId);

                entity.ToTable("RofoufStatus");

                entity.HasIndex(e => e.FileId, "UQ_FileID")
                    .IsUnique();

                entity.Property(e => e.RofoufFileId).HasColumnName("RofoufFileID");

                entity.Property(e => e.CoverUploadDate).HasColumnType("datetime");

                entity.Property(e => e.CoverUserRoleId).HasColumnName("CoverUserRoleID");

                entity.Property(e => e.DataUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.DataUserRoleId).HasColumnName("DataUserRoleID");

                entity.Property(e => e.DropBoxFileStatus).HasMaxLength(100);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileMd5)
                    .HasMaxLength(50)
                    .HasColumnName("FileMD5");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(150)
                    .HasColumnName("isbn");

                entity.Property(e => e.PublicationDate).HasColumnType("datetime");

                entity.Property(e => e.SubTitle).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.TxtPublicationDate)
                    .HasMaxLength(250)
                    .HasColumnName("txtPublicationDate");

                entity.HasOne(d => d.CoverUserRole)
                    .WithMany(p => p.RofoufStatusCoverUserRoles)
                    .HasForeignKey(d => d.CoverUserRoleId)
                    .HasConstraintName("FK_RofoufStatus_User_Role_Cover");

                entity.HasOne(d => d.DataUserRole)
                    .WithMany(p => p.RofoufStatusDataUserRoles)
                    .HasForeignKey(d => d.DataUserRoleId)
                    .HasConstraintName("FK_RofoufStatus_User_Role_Data");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.RoleTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UrlName).HasMaxLength(50);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("RolePermission");

                entity.Property(e => e.RolePermissionId).HasColumnName("RolePermissionID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'DNS')");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermission_Role");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.HasIndex(e => e.TitleArabic, "UK_SeriesTitle")
                    .IsUnique();

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.BlurbArabic).HasMaxLength(4000);

                entity.Property(e => e.BlurbEnglish).HasMaxLength(4000);

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.TitleArabic)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.TitleEnglish).HasMaxLength(256);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("Setting");

                entity.HasIndex(e => e.Name, "UQ_Setting_Name")
                    .IsUnique();

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<SettingStep>(entity =>
            {
                entity.ToTable("SettingStep");

                entity.Property(e => e.SettingStepId).HasColumnName("SettingStepID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.SettingSteps)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettingStep_Setting");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.SettingSteps)
                    .HasForeignKey(d => d.StepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettingStep_Step");
            });

            modelBuilder.Entity<SettingValue>(entity =>
            {
                entity.ToTable("SettingValue");

                entity.HasIndex(e => new { e.SettingId, e.Date, e.BookId, e.UserRoleId }, "UQ_SettingValue_SettingID_Date_BookID")
                    .IsUnique();

                entity.Property(e => e.SettingValueId).HasColumnName("SettingValueID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ValueString).HasMaxLength(50);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.SettingValues)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_SettingValue_Book");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.SettingValues)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettingValue_Setting");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.SettingValues)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_SettingValue_User_Role");
            });

            modelBuilder.Entity<SourceFormat>(entity =>
            {
                entity.ToTable("SourceFormat");

                entity.Property(e => e.SourceFormatId).HasColumnName("SourceFormatID");

                entity.Property(e => e.SourceFormatName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SpecialCharacter>(entity =>
            {
                entity.ToTable("SpecialCharacter");

                entity.Property(e => e.Char)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.ToTable("Step");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.InitialHourCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StepNote).HasMaxLength(1000);

                entity.Property(e => e.StepTitle)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StockItem>(entity =>
            {
                entity.ToTable("StockItem");

                entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

                entity.Property(e => e.BookFormatId).HasColumnName("BookFormatID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrintingHouseId).HasColumnName("PrintingHouseID");

                entity.Property(e => e.ReceivingDate).HasColumnType("datetime");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.BookFormat)
                    .WithMany(p => p.StockItems)
                    .HasForeignKey(d => d.BookFormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItem_BookFormat");

                entity.HasOne(d => d.PrintingHouse)
                    .WithMany(p => p.StockItems)
                    .HasForeignKey(d => d.PrintingHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItem_PrintingHouse");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StockItems)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItem_User");
            });

            modelBuilder.Entity<SvgRequest>(entity =>
            {
                entity.ToTable("SvgRequest");

                entity.Property(e => e.SvgRequestId).HasColumnName("SvgRequestID");

                entity.Property(e => e.CompleteDate).HasColumnType("datetime");

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TestSvg).HasColumnName("TestSVG");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.HasIndex(e => e.ItemNumber, "UQ_ItemNumber")
                    .IsUnique();

                entity.HasIndex(e => e.TagName, "UQ_TagName")
                    .IsUnique();

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.HasIndex(e => new { e.BookId, e.Status }, "IX_Task_BookID_Status");

                entity.HasIndex(e => new { e.WorkflowStepId, e.Status }, "IX_Task_WorkflowStepID_Status");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.ActualEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.EstimatedEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Fes).HasColumnName("FEs");

                entity.Property(e => e.HourCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pes).HasColumnName("PEs");

                entity.Property(e => e.PreviousTaskId).HasColumnName("PreviousTaskID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.WorkflowStepId).HasColumnName("WorkflowStepID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_Task_Book");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_Task_User_Role");
            });

            modelBuilder.Entity<TaskAction>(entity =>
            {
                entity.ToTable("Task_Action");

                entity.HasIndex(e => new { e.TaskId, e.Action }, "IX_TaskID_Action");

                entity.HasIndex(e => new { e.TaskId, e.Date }, "IX_TaskID_Date");

                entity.Property(e => e.TaskActionId).HasColumnName("TaskActionID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Comment).HasComment("The Comment of all selected reasons");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsNormal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.TargetTaskId).HasColumnName("TargetTaskID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskActions)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_Task_Action_Task");
            });

            modelBuilder.Entity<TaskFile>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.TaskId, e.Version });

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.FilePath).IsRequired();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.TaskFiles)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_TaskFiles_Files");
            });

            modelBuilder.Entity<TaskFreelancer>(entity =>
            {
                entity.Property(e => e.TaskFreelancerId).HasColumnName("TaskFreelancerID");

                entity.Property(e => e.FreelancerRoleId).HasColumnName("FreelancerRoleID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.FreelancerRole)
                    .WithMany(p => p.TaskFreelancers)
                    .HasForeignKey(d => d.FreelancerRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskFreelancers_FreelancerUser_Role");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskFreelancers)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskFreelancers_Task");
            });

            modelBuilder.Entity<TempBookTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_BookTitles");

                entity.Property(e => e.Author).HasMaxLength(255);

                entity.Property(e => e.BookTitle)
                    .HasMaxLength(255)
                    .HasColumnName("Book Title");
            });

            modelBuilder.Entity<TempBookTitles2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_BookTitles2");

                entity.Property(e => e.BookTitle)
                    .HasMaxLength(255)
                    .HasColumnName("Book Title");
            });

            modelBuilder.Entity<TempItemNumber>(entity =>
            {
                entity.HasKey(e => e.ItemNumber);

                entity.ToTable("temp_Item_Numbers");

                entity.Property(e => e.ItemNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("item_Number");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");

                entity.HasIndex(e => new { e.InvoiceId, e.BookFormatId }, "BookFormatInvoice")
                    .IsUnique();

                entity.HasIndex(e => new { e.BookFormatId, e.InvoiceId }, "UQ_BookEdition_Invoice")
                    .IsUnique();

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.BookFormatId).HasColumnName("BookFormatID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.PayedPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitNetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitRetailPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BookFormat)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.BookFormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_BookFormat");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Invoice");
            });

            modelBuilder.Entity<TransationReceiptCoverage>(entity =>
            {
                entity.HasKey(e => new { e.TransactionId, e.RecieptId })
                    .HasName("PK_TransationReceiptCoverage_1");

                entity.ToTable("TransationReceiptCoverage");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.RecieptId).HasColumnName("RecieptID");

                entity.Property(e => e.CoverageAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.Reciept)
                    .WithMany(p => p.TransationReceiptCoverages)
                    .HasForeignKey(d => d.RecieptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransationReceiptCoverage_PaymentReceipt");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TransationReceiptCoverages)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransationReceiptCoverage_Transaction");
            });

            modelBuilder.Entity<TranslationDetail>(entity =>
            {
                entity.HasKey(e => e.TranslationDetailsId);

                entity.Property(e => e.TranslationDetailsId).HasColumnName("TranslationDetailsID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TranslationDetails)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TranslationDetails_Task");
            });

            modelBuilder.Entity<TranslationScore>(entity =>
            {
                entity.HasKey(e => e.ScoreId);

                entity.ToTable("Translation_Score");

                entity.Property(e => e.ScoreId).HasColumnName("ScoreID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UrlSource>(entity =>
            {
                entity.HasKey(e => e.SourceId)
                    .HasName("PK_SourceID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SourceUrl).HasMaxLength(500);
            });

            modelBuilder.Entity<UrlSourceTitle>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NewTitle)
                    .HasMaxLength(255)
                    .HasColumnName("New Title");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.Username, "UK_Username")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("User_Role");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User_Role_User");
            });

            modelBuilder.Entity<VwBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Book");

                entity.Property(e => e.ArticlePublicationDate).HasMaxLength(50);

                entity.Property(e => e.AuthoringLanguageId).HasColumnName("AuthoringLanguageID");

                entity.Property(e => e.BlurbArabic).HasMaxLength(4000);

                entity.Property(e => e.BlurbEnglish).HasMaxLength(4000);

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");

                entity.Property(e => e.DigitalIsbn)
                    .HasMaxLength(13)
                    .HasColumnName("DigitalISBN");

                entity.Property(e => e.DigitalRegistrationNumber).HasMaxLength(13);

                entity.Property(e => e.DocPageNums).HasMaxLength(50);

                entity.Property(e => e.DueDatePublication).HasColumnType("datetime");

                entity.Property(e => e.EpubCssversion).HasColumnName("EpubCSSVersion");

                entity.Property(e => e.FinishedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstTranslationPublishedDate).HasMaxLength(50);

                entity.Property(e => e.HighPriorityDueDate)
                    .HasColumnType("date")
                    .HasColumnName("HighPriority_DueDate");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.IssueNumber).HasMaxLength(50);

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.ItemNumberOld).HasColumnName("item_Number_old");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.MarktingDocumentId).HasColumnName("MarktingDocumentID");

                entity.Property(e => e.MarktingPlanId).HasColumnName("MarktingPlanID");

                entity.Property(e => e.MarktingStartDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalIsbn)
                    .HasMaxLength(13)
                    .HasColumnName("OriginalISBN");

                entity.Property(e => e.OriginalPublicationDate).HasMaxLength(4);

                entity.Property(e => e.OriginalPublishedDate).HasMaxLength(50);

                entity.Property(e => e.PrintedIsbn)
                    .HasMaxLength(13)
                    .HasColumnName("PrintedISBN");

                entity.Property(e => e.PrintedRegistrationNumber).HasMaxLength(13);

                entity.Property(e => e.PublicationDate).HasColumnType("datetime");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.ShortTitle).HasMaxLength(80);

                entity.Property(e => e.SourceFormatId).HasColumnName("SourceFormatID");

                entity.Property(e => e.SourceLanguageId).HasColumnName("SourceLanguageID");

                entity.Property(e => e.SubTitleArabic).HasMaxLength(200);

                entity.Property(e => e.SubTitleOriginal).HasMaxLength(200);

                entity.Property(e => e.TitleArabic)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TitleOriginal).HasMaxLength(200);

                entity.Property(e => e.TranslationType).HasMaxLength(50);

                entity.Property(e => e.TypeOfInput).HasMaxLength(100);

                entity.Property(e => e.VolumeNumber).HasMaxLength(10);

                entity.Property(e => e.WorkSheetCode).HasMaxLength(10);
            });

            modelBuilder.Entity<VwDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Document");

                entity.Property(e => e.BlurbArabic).HasMaxLength(4000);

                entity.Property(e => e.BlurbEnglish).HasMaxLength(4000);

                entity.Property(e => e.DocumentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DocumentID");

                entity.Property(e => e.ItemNumber).HasColumnName("item_Number");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PublicationDate).HasColumnType("datetime");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.ShortTitle).HasMaxLength(80);

                entity.Property(e => e.SubTitleArabic).HasMaxLength(200);

                entity.Property(e => e.SubTitleOriginal).HasMaxLength(200);

                entity.Property(e => e.TitleArabic)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TitleOriginal).HasMaxLength(200);

                entity.Property(e => e.TranslationType).HasMaxLength(50);

                entity.Property(e => e.WorkSheetCode).HasMaxLength(10);
            });

            modelBuilder.Entity<VwDocumentTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DocumentTasks");

                entity.Property(e => e.ActualEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentTasksId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DocumentTasksID");

                entity.Property(e => e.EstimatedEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Fes).HasColumnName("FEs");

                entity.Property(e => e.HourCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pes).HasColumnName("PEs");

                entity.Property(e => e.PreviousTaskId).HasColumnName("PreviousTaskID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            modelBuilder.Entity<VwTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Task");

                entity.Property(e => e.ActualEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.EstimatedEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Fes).HasColumnName("FEs");

                entity.Property(e => e.HourCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pes).HasColumnName("PEs");

                entity.Property(e => e.PreviousTaskId).HasColumnName("PreviousTaskID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaskId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TaskID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.WorkflowStepId).HasColumnName("WorkflowStepID");
            });

            modelBuilder.Entity<WaitingList>(entity =>
            {
                entity.ToTable("WaitingList");

                entity.Property(e => e.WaitingListId).HasColumnName("WaitingListID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.WaitingLists)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_WaitingList_Task");
            });

            modelBuilder.Entity<WebsiteCommentatorsStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebsiteCommentatorsStatus");

                entity.Property(e => e.CommentatorId).HasColumnName("CommentatorID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.WebsiteCommentatorId).HasColumnName("WebsiteCommentatorID");
            });

            modelBuilder.Entity<WebsiteCommentsStatus>(entity =>
            {
                entity.HasKey(e => e.WebsiteCommentsId);

                entity.ToTable("WebsiteCommentsStatus");

                entity.Property(e => e.WebsiteCommentsId).HasColumnName("WebsiteCommentsID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.ToTable("Workflow");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorkflowStep>(entity =>
            {
                entity.ToTable("Workflow_Step");

                entity.Property(e => e.WorkflowStepId).HasColumnName("WorkflowStepID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.WorkflowSteps)
                    .HasForeignKey(d => d.StepId)
                    .HasConstraintName("FK_Workflow_Step_Step");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.WorkflowSteps)
                    .HasForeignKey(d => d.WorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workflow_Step_Workflow");
            });

            modelBuilder.Entity<WorkflowStepRole>(entity =>
            {
                entity.ToTable("Workflow_Step_Role");

                entity.Property(e => e.WorkflowStepRoleId).HasColumnName("WorkflowStepRoleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.WorkflowStepId).HasColumnName("WorkflowStepID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.WorkflowStepRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workflow_Step_Role_Role");

                entity.HasOne(d => d.WorkflowStep)
                    .WithMany(p => p.WorkflowStepRoles)
                    .HasForeignKey(d => d.WorkflowStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workflow_Step_Role_Workflow_Step");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
