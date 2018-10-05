﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// --------------------------------------------------------------------------------------------

using McMaster.Extensions.CommandLineUtils;

namespace Microsoft.Oryx.BuildScriptGeneratorCli
{
    [Command("oryx", Description = "Generates scripts and builds source code for multiple languages.")]
    [Subcommand("build", typeof(BuildCommand))]
    internal class Program
    {
        private static int Main(string[] args) => CommandLineApplication.Execute<Program>(args);

        internal int OnExecute(CommandLineApplication app, IConsole console)
        {
            app.ShowHelp();
            return 0;
        }
    }
}