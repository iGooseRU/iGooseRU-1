﻿using System.IO;
using System.IO.Compression;
using Backups.Classes;
using Backups.Repository;

namespace Backups.ArchiverTools
{
    public class SingleStorage : IAlgorithm
    {
        public void CreateArchive(RestorePoint restorePoint, IRepository repository)
        {
            repository.SingleStorageArchive(restorePoint);
        }
    }
}