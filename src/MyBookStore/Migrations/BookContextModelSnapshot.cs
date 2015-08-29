using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using MyBookStore.Models;

namespace MyBookStore.Migrations
{
    [ContextType(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("SqlServer:DefaultSequenceName", "DefaultSequence")
                .Annotation("SqlServer:Sequence:.DefaultSequence", "'DefaultSequence', '', '1', '10', '', '', 'Int64', 'False'")
                .Annotation("SqlServer:ValueGeneration", "Sequence");
            
            builder.Entity("MyBookStore.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("FirstMidName");
                    
                    b.Property<string>("LastName");
                    
                    b.Key("AuthorID");
                });
            
            builder.Entity("MyBookStore.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<int>("AuthorID");
                    
                    b.Property<string>("Genre");
                    
                    b.Property<decimal>("Price");
                    
                    b.Property<string>("Title");
                    
                    b.Property<int>("Year");
                    
                    b.Key("BookID");
                });
            
            builder.Entity("MyBookStore.Models.Book", b =>
                {
                    b.Reference("MyBookStore.Models.Author")
                        .InverseCollection()
                        .ForeignKey("AuthorID");
                });
        }
    }
}
