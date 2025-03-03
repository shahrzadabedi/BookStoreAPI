﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEshopAPI
{
    public class BookEshopDatabaseSettings : IBookEshopDatabaseSettings
    {
        public string BooksCollectionName { get; set; }
        public string BookStoreCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
       
    }

    public interface IBookEshopDatabaseSettings
    {
        string BooksCollectionName { get; set; }
        string BookStoreCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
