using MobileSuitcase.BackEnd.Core.Repositories;
using MobileSuitcase.Entities.Models;
using System;
using System.Collections.Generic;
using System.Net;
using static System.Net.HttpStatusCode;

namespace MobileSuitcase.BackEnd.Persistance.Repositories
{
    public class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        public (HttpStatusCode ResponseCode, string ResponseText, List<Worker>) GetWorkers()
        {
          return (OK, String.Empty, ListAllWorkers());
        }

        private List<Worker> ListAllWorkers()
        {
            return new List<Worker>()
            {
                new Worker()
                {
                    FirstName = "María",
                    LastName = "López",
                    Age = 29,
                    ImagePath = "https://randomuser.me/api/portraits/women/10.jpg",
                    Position = "Full Stack Developer"
                },

                new Worker()
                {
                    FirstName = "Carlos",
                    LastName = "Pérez",
                    Age = 20,
                    ImagePath = "https://randomuser.me/api/portraits/men/10.jpg",
                    Position = "Junior Developer"
                },

                new Worker()
                {
                    FirstName = "Pedro",
                    LastName = "Soza",
                    Age = 30,
                    ImagePath = "https://randomuser.me/api/portraits/men/36.jpg",
                    Position = "Project Manager"
                },

                new Worker()
                {
                    FirstName = "Roberto",
                    LastName = "Martínez",
                    Age = 34,
                    ImagePath = "https://randomuser.me/api/portraits/men/34.jpg",
                    Position = "Lead Developer"
                },

                new Worker()
                {
                    FirstName = "Luis",
                    LastName = "Fernández",
                    Age = 33,
                    ImagePath = "https://randomuser.me/api/portraits/men/33.jpg",
                    Position = "Senior Developer"
                },

                 new Worker()
                {
                    FirstName = "Juan",
                    LastName = "Solís",
                    Age = 31,
                    ImagePath = "https://randomuser.me/api/portraits/men/25.jpg",
                    Position = "Commercial Manager"
                },

                  new Worker()
                {
                    FirstName = "Lucía",
                    LastName = "Hernández",
                    Age = 28,
                    ImagePath = "https://randomuser.me/api/portraits/women/31.jpg",
                    Position = "Sales Coordinator"
                },

                   new Worker()
                {
                    FirstName = "José",
                    LastName = "Rodríguez",
                    Age = 28,
                    ImagePath = "https://randomuser.me/api/portraits/men/15.jpg",
                    Position = "QA Leader"
                },

                     new Worker()
                {
                    FirstName = "Francisco",
                    LastName = "Navarro",
                    Age = 26,
                    ImagePath = "https://randomuser.me/api/portraits/men/43.jpg",
                    Position = "QA Developer"
                },

                     new Worker()
                {
                    FirstName = "Marcos",
                    LastName = "Alfaro",
                    Age = 34,
                    ImagePath = "https://randomuser.me/api/portraits/men/44.jpg",
                    Position = "General Manager"
                },

            };
        }
    }
}
