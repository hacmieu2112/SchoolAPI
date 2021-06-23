using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSchoolWASM.Models;
using Microsoft.AspNetCore.Components;
using BlazorSchoolWASM.Services;

namespace BlazorSchoolWASM.Pages
{
    public partial class School
    {

        public IEnumerable<StudentInClass> schools { get; set; }

        public IEnumerable<Student> students { get; set; }

        public IEnumerable<Class> classes { get; set; }

        [Inject]
        public ISchoolDataService SchoolDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            students = (await SchoolDataService.GetAllStudent()).ToList();
        }
    }
}
