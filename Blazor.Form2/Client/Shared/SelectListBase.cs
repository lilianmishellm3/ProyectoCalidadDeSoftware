using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Form2.Shared;
using Microsoft.AspNetCore.Components;

namespace Blazor.Form2.Client.Shared
{
    public class SelectListBase:ComponentBase
    {
        public List<Answers> list { get; set; }

        

        protected override Task OnInitializedAsync()
        {
            list = new List<Answers>()
            {
                new Answers( ){
                    Id = 1,
                    Description ="Nunca"
                },
                new Answers( ){
                    Id = 2,
                    Description ="Casi Nunca"
                },
                new Answers( ){
                    Id = 3,
                    Description ="Aveces"
                },
                new Answers( ){
                    Id = 4,
                    Description ="Casi Siempre"
                },

                 new Answers( ){
                    Id = 5,
                    Description ="Siempre"
                }
            };

            return base.OnInitializedAsync();
        }
    }
}
