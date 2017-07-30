using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP.Projeto.AutoMapper.Service.Model;

namespace VP.Projeto.AutoMapper.Service.Interface
{
    public interface ISubtaskService
    {
        List<Model.Issue> GetSubtasks(Model.Issue parentIssue);
        void CreateSubtask(Issue parentIssue, Issue subtask);
    }
}
