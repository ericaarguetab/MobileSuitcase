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
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "Full Stack Developer"
                },

                new Worker()
                {
                    FirstName = "Carlos",
                    LastName = "Pérez",
                    Age = 20,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "Junior Developer"
                },

                new Worker()
                {
                    FirstName = "Pedro",
                    LastName = "Soza",
                    Age = 30,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "Project Manager"
                },

                new Worker()
                {
                    FirstName = "Roberto",
                    LastName = "Martínez",
                    Age = 34,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "Lead Developer"
                },

                new Worker()
                {
                    FirstName = "Luis",
                    LastName = "Fernández",
                    Age = 33,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "Senior Developer"
                },

                 new Worker()
                {
                    FirstName = "Juan",
                    LastName = "Solís",
                    Age = 31,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "Commercial Manager"
                },

                  new Worker()
                {
                    FirstName = "Lucía",
                    LastName = "Hernández",
                    Age = 28,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "Sales Coordinator"
                },

                   new Worker()
                {
                    FirstName = "José",
                    LastName = "Rodríguez",
                    Age = 28,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "QA Leader"
                },

                     new Worker()
                {
                    FirstName = "Francisco",
                    LastName = "Navarro",
                    Age = 26,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "QA Developer"
                },

                     new Worker()
                {
                    FirstName = "Marcos",
                    LastName = "Alfaro",
                    Age = 34,
                    ImagePath = "https://thispersondoesnotexist.com/image",
                    Position = "General Manager"
                },

            };
        }
    }
}
