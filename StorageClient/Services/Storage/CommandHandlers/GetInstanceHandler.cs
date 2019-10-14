﻿using AltinnCLI.Core;
using StorageClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltinnCLI.Services.Storage
{
    public class GetInstanceHandler : CommandHandlerBase, ICommandHandler, IHelp
    {
        public string Name
        {
            get
            {
                return "GetInstance";
            }
        }

        public string ServiceProvider
        {
            get
            {
                return "Storage";
            }
        }

        public string GetHelp()
        {
            throw new NotImplementedException();
        }

        public bool Run(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
