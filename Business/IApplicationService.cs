using Business.Requests.Application;
using Business.Responses.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicationService
    {
        ApplicationResponse Add(CreateApplicationRequest request);
        ApplicationResponse Update(UpdateApplicationRequest request);
        void Delete(int id);
        List<ApplicationResponse> GetAll();
        ApplicationResponse GetById(int id);
    }
}
