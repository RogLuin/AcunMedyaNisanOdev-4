using Business.Abstracts;
using Business.Requests.Application;
using Business.Responses.Application;
using Business.Abstracts;
using Business.Requests.Application;
using Business.Responses.Application;
using Entites;
using Data;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;

namespace Business
{
    namespace Business.Concretes
    {
        public class ApplicationManager : IApplicationService
        {
            private readonly ApplicationDbContext _context;

            public ApplicationManager(ApplicationDbContext context)
            {
                _context = context;
            }

            public ApplicationResponse Add(CreateApplicationRequest request)
            {
                var application = new Application
                {
                    ApplicantId = request.ApplicantId,
                    BootcampId = request.BootcampId,
                    State = "PENDING"
                };

                _context.Applications.Add(application);
                _context.SaveChanges();

                return new ApplicationResponse
                {
                    Id = application.Id,
                    ApplicantId = application.ApplicantId,
                    BootcampId = application.BootcampId,
                    State = application.State
                };
            }

            public void Delete(int id)
            {
                var application = _context.Applications.Find(id);
                if (application != null)
                {
                    _context.Applications.Remove(application);
                    _context.SaveChanges();
                }
            }

            public List<ApplicationResponse> GetAll()
            {
                return _context.Applications.Select(a => new ApplicationResponse
                {
                    Id = a.Id,
                    ApplicantId = a.ApplicantId,
                    BootcampId = a.BootcampId,
                    State = a.State
                }).ToList();
            }

            public ApplicationResponse GetById(int id)
            {
                var a = _context.Applications.Find(id);
                return a == null ? null : new ApplicationResponse
                {
                    Id = a.Id,
                    ApplicantId = a.ApplicantId,
                    BootcampId = a.BootcampId,
                    State = a.State
                };
            }

            public ApplicationResponse Update(UpdateApplicationRequest request)
            {
                var a = _context.Applications.Find(request.Id);
                if (a == null) return null;

                a.ApplicantId = request.ApplicantId;
                a.BootcampId = request.BootcampId;
                a.State = request.State;
                _context.SaveChanges();

                return new ApplicationResponse
                {
                    Id = a.Id,
                    ApplicantId = a.ApplicantId,
                    BootcampId = a.BootcampId,
                    State = a.State
                };
            }
        }
    }
}
