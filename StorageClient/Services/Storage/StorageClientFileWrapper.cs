﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using AltinnCLI.Core;

namespace AltinnCLI.Services.Storage
{
    public class StorageClientFileWrapper : IStorageClientWrapper
    {
        public string BaseAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string CreateApplication(string appId, string instanceOwnerId, StringContent content)
        {
            throw new NotImplementedException();
        }

        public Stream GetDocument(int instanceOwnerId, Guid instanceGuid, Guid dataId)
        {
            throw new NotImplementedException();
        }

        public Stream GetDocument(string command)
        {
            throw new NotImplementedException();
        }

        public InstanceResponseMessage GetInstanceMetaData(int? instanceOwnerId = null, Guid? instanceGuid = null)
        {
            throw new NotImplementedException();
        }

        public Stream GetInstances(int instanceOwnerOd, Guid instanceGuid)
        {
            throw new NotImplementedException();
        }
    }
}
