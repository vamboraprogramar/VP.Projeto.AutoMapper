using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP.Projeto.AutoMapper.Service.Implementation;
using VP.Projeto.AutoMapper.Service.Interface;
using VP.Projeto.AutoMapper.Service.Model;

namespace VP.Projeto.AutoMapper.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            JIRAInstance.CreateInstance("https://exemploHostJira.atlassian.net", "usuario@usuario.com", "senha");
            ISubtaskService service = new SubtaskService(JIRAInstance.GetInstance());

            //var subtasks = service.GetSubtasks(new Issue() { ID = "PT-31" });

            service.CreateSubtask(new Issue() { ID = "PT-64" },
                new Issue()
                {
                    Description = "tarefa para testar automapper",
                    Summary = "automapper",
                    Type = "Sub-task",
                    Project = "PT"
                }
            );
        }
    }
}
