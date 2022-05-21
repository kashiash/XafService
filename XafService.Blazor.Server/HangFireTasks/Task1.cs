using Hangfire;
using Hangfire.Console;
using Hangfire.Server;
using System.Threading.Tasks;

namespace XafService.Blazor.Server.HangFireTasks
{
   
    public class Task1
    {
        [Queue("Taski")]
        public static async Task Execute(PerformContext context)
        {
            context.WriteLine("cokolwiek");
        }
    }
}
