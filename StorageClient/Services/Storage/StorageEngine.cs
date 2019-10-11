﻿using AltinnCLI.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AltinnCLI.Services.Storage
{
    public class StorageEngine : ApplicationEngineBase, IService, IHelp
    {
        private ICommandHandler commandHandler;

        public StorageEngine()
        {
        }


        public virtual void Run(ICommandHandler commandHandler)
        {
            commandHandler.Run();
            Console.WriteLine("It's a me! Storage");
        }

  
        public string Name
        {
            get
            {
                return "Storage";
            }
        }

        public string GetHelp()
        {
            return "Storage\nusage: storage <operation> -<option>\n\noperations:\ngetAttachment";
        }

    }
}