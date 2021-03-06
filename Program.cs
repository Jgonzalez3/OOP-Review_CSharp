﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myWatch = new StopWatch();
            myWatch.StartTime();
            //Thread Sleep is like SetTimeout for JavaScript
            Thread.Sleep(1000);
            myWatch.StopTime();
            
            var myPost = new Post("Virtue", "So Help me God");
            myPost.VoteUp();
            myPost.VoteUp();
            myPost.VoteUp();
            myPost.VoteDown();
            myPost.DisplayVotes();
            
            //var dbMigrator = new DbMigrator(new FileLogger("C:\\Documents\\CodingDojo\\Bootcamp\\C#\\OOP\\log.txt"));
            //Logs are stored at this path.
            //
                //dbMigrator.Migrate();

            WorkFlow WorkFlow = new WorkFlow();
            WorkFlow.Add(new VideoUploader());
            WorkFlow.Add(new CallWebService());
            WorkFlow.Add(new SendEmail());
            WorkFlow.Add(new ChangeStatus());

            var engine  = new WorkFlowEngine();
            engine.Run(WorkFlow);

            List<object> tList = new List<object>();
            tList.Add("Javier");
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
