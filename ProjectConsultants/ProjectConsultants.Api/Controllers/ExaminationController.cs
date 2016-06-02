using ProjectConsultants.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectConsultants.Api.Controllers
{
    public class ExaminationController : ApiController
    {
        
        public List<Questions> GetQuestions()
        {
            var question = new List<Questions>
            {
                new Questions()
                {
                    Id=1,
                    Text="This is question1",
                    Answer=new List<Answers>
                   {
                        new Answers()
                        {
                            Id=1,
                            Text="Option A"
                        },
                        new Answers()
                        {
                            Id=2,
                            Text="Option B"
                        },
                        new Answers()
                        {
                            Id=3,
                            Text="Option C"
                        },
                        new Answers()
                        {
                            Id=4,
                            Text="Option D"
                        }
                   }
                },
                new Questions()
                {
                    Id=2,
                    Text="This is question2",
                    Answer=new List<Answers>
                   {
                        new Answers()
                        {
                            Id=5,
                            Text="Option A"
                        },
                        new Answers()
                        {
                            Id=6,
                            Text="Option B"
                        },
                        new Answers()
                        {
                            Id=7,
                            Text="Option C"
                        },
                        new Answers()
                        {
                            Id=8,
                            Text="Option D"
                        }
                   }
                },
                new Questions()
                {
                    Id=3,
                    Text="This is question3",
                    Answer=new List<Answers>
                   {
                        new Answers()
                        {
                            Id=9,
                            Text="option A"
                        },
                        new Answers()
                        {
                            Id=10,
                            Text="option B"
                        },
                        new Answers()
                        {
                            Id=11,
                            Text="option C"
                        },
                        new Answers()
                        {
                            Id=12,
                            Text="option D"
                        }
                   }
                },
                new Questions()
                {
                    Id=4,
                    Text="This is question4",
                    Answer=new List<Answers>
                   {
                        new Answers()
                        {
                            Id=13,
                            Text="option A"
                        },
                        new Answers()
                        {
                            Id=14,
                            Text="option B"
                        },
                        new Answers()
                        {
                            Id=15,
                            Text="option C"
                        },
                        new Answers()
                        {
                            Id=16,
                            Text="option D"
                        }
                   }
                },
                new Questions()
                {
                    Id=5,
                    Text="This is question5",
                    Answer=new List<Answers>
                   {
                        new Answers()
                        {
                            Id=17,
                            Text="option A"
                        },
                        new Answers()
                        {
                            Id=18,
                            Text="option B"
                        },
                        new Answers()
                        {
                            Id=19,
                            Text="option C"
                        },
                        new Answers()
                        {
                            Id=20,
                            Text="option Ds"
                        }
                   }
                }
            };
            return question;
        }

    }
    }
    




