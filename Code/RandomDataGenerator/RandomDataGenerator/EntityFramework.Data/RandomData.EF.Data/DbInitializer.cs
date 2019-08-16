namespace RandomData.EF.Data
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Diagnostics.CodeAnalysis;
    using RandomData.EF.Data.Entities;
    
    /// <summary>
    ///     The web db initialize.
    /// </summary>
  
    public class DbInitializer : CreateDatabaseIfNotExists<DbContext>
    {
        #region Methods

        /// <summary>
        /// The seed.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        protected override void Seed(DbContext context)
        {              
            base.Seed(context);
        }

        #endregion
    }
}