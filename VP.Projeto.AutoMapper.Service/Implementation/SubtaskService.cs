using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP.Projeto.AutoMapper.Service.Helpers;
using VP.Projeto.AutoMapper.Service.Interface;
using VP.Projeto.AutoMapper.Service.Model;

namespace VP.Projeto.AutoMapper.Service.Implementation
{
    public class SubtaskService : ISubtaskService
    {
        private Atlassian.Jira.Jira jira;

        public SubtaskService(JIRAInstance instance)
        {
            jira = Atlassian.Jira.Jira.CreateRestClient(instance.Host, instance.User, instance.Password);
            AutoMapperHelper.InitializeMapper();
        }
        public List<Model.Issue> GetSubtasks(Model.Issue parentIssue)
        {
            List<Model.Issue> returnedSubtasks = new List<Model.Issue>();
            foreach (var subtask in jira.Issues.GetSubTasksAsync(parentIssue.ID).Result)
            {
                Model.Issue selectedIssue = Mapper.Map<Atlassian.Jira.Issue, Model.Issue>(subtask);                
                returnedSubtasks.Add(selectedIssue);
            }
            return returnedSubtasks;
        }

        public void CreateSubtask(Model.Issue parentIssue, Model.Issue subtask)
        {
            if (jira != null)
            {
                var newIssue = jira.CreateIssue(subtask.Project, parentIssue.ID);
                newIssue = Mapper.Map<Model.Issue, Atlassian.Jira.Issue>(subtask, newIssue);
                newIssue.SaveChanges();
            }
        }
    }
}
