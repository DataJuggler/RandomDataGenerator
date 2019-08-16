

#region using statements

using DataJuggler.Core.UltimateHelper;
using RandomData.EF.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;

#endregion

namespace RandomData.EF.Data
{

    #region class DataContext
    /// <summary>
    /// This object is the Entity Framework Data Context for this project
    /// </summary>
    public class DataContext : DbContext
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        ///     Initializes a new instance of a DataContext object
        /// </summary>
        public DataContext() : base ("RandomDataConnection")
        {             
             // initialize the database
            Database.SetInitializer<DataContext>(null);
            this.Database.Initialize(false);
            this.Configuration.LazyLoadingEnabled = false;
        }
        #endregion
        
        #region Methods
            
            #region OnModelCreating(DbModelBuilder modelBuilder)
            /// <summary>
            /// The on model creating.
            /// </summary>
            /// <param name="modelBuilder">
            /// The model builder.
            /// </param>
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                // Map the tables since EF gets confused on table names that do not end in S 
                modelBuilder.Entity<Address>().ToTable("Address");
                modelBuilder.Entity<City>().ToTable("City");
                modelBuilder.Entity<FirstName>().ToTable("FirstName");
                modelBuilder.Entity<LastName>().ToTable("LastName");
                modelBuilder.Entity<Member>().ToTable("Member");
                modelBuilder.Entity<Setting>().ToTable("Setting");
                modelBuilder.Entity<State>().ToTable("State");
                modelBuilder.Entity<StreetName>().ToTable("StreetName");
                modelBuilder.Entity<ZipCode>().ToTable("ZipCode");
                
                // call the base method
                base.OnModelCreating(modelBuilder);
            }
            #endregion
            
            #region SaveChanges()
            /// <summary>
            /// method Save Changes
            /// </summary>
            public override int SaveChanges()
            {
                // initial value
                int returnValue = 0;
                
                try
                {              
                    returnValue = base.SaveChanges();
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("SaveChanges", "DBContext", error);
                }
                
                // return value
                return returnValue;
            }
            #endregion

        #endregion
        
        #region Properties
            
            #region Address
            /// <summary>
            ///     Gets or sets the Address
            /// </summary>
            public IDbSet<Address> Address { get; set; }
            #endregion
            
            #region City
            /// <summary>
            ///     Gets or sets the City.
            /// </summary>
            public IDbSet<City> City { get; set; }
            #endregion
            
            #region FirstName
            /// <summary>
            ///     Gets or sets the FirstName
            /// </summary>
            public IDbSet<FirstName> FirstName { get; set; }
            #endregion
            
            #region LastName
            /// <summary>
            ///     Gets or sets the LastName
            /// </summary>
            public IDbSet<LastName> LastName { get; set; }    
            #endregion
            
            #region Member
            /// <summary>
            /// Gets or sets the Member
            /// </summary>
            public IDbSet<Member> Member { get; set; }
            #endregion
            
            #region Setting
            /// <summary>
            ///     Gets or sets the Setting
            /// </summary>
            public IDbSet<Setting> Setting { get; set; }
            #endregion
            
            #region State
            /// <summary>
            /// Gets or sets the State.
            /// </summary>
            public IDbSet<State> State { get; set; }
            #endregion
            
            #region StreetName
            /// <summary>
            ///     Gets or sets the StreetName
            /// </summary>
            public IDbSet<StreetName> StreetName { get; set; }
            #endregion

            #region ZipCode
            /// <summary>
            ///     Gets or sets the ZipCode.
            /// </summary>
            public IDbSet<ZipCode> ZipCode { get; set; }
            #endregion

        #endregion
        
    }
    #endregion

}
