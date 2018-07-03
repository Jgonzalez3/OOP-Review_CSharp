using System;
using System.IO;

namespace OOP{
    public interface ILogger{
        void LogError(string message);
        void LogInfo(string message);
    }
    public class FileLogger : ILogger{
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message){
            Log(message, "Error");
        }
        public void LogInfo(string message){
            Log(message, "INFO");
        }
        private void Log(string message, string messageType){
            using(var streamWriter = new StreamWriter(_path, true)){
                streamWriter.WriteLine("Error: "+ message);
                // streamWriter.Dispose(); When using() automatically calls Dipose() method. Not needed in this case.
            }
            //SteamWrite managed by file resource. Need to dispose once done. Use using()
        }
    }
    public class ConsoleLogger : ILogger{
        public void LogError(string message){
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
        }
        public void LogInfo(string message){
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(message);
        }
    }
    public class DbMigrator{
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger){
            _logger = logger;
        }
        public void Migrate(){
            _logger.LogInfo("Migrating started at "+ DateTime.Now);
            _logger.LogInfo("Migrating finished at " + DateTime.Now);
        }
    }
}