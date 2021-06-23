using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSchoolWASM.Services;
using BlazorSchoolWASM.Models;

namespace BlazorSchoolWASM.Pages
{
    public partial class EditStudent
    {
        protected string Message = string.Empty;
        protected bool Saved;
        [Inject]
        public ISchoolDataService SchoolDataService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Student student { get; set; } = new Student();

        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            if (!String.IsNullOrEmpty(Id))
            {
                var studentId = Convert.ToInt32(Id);
                student = await SchoolDataService.GetStudentDetails(studentId);
            }
        }
        //thông báo khi submit valid
        protected async Task HandleValidSubmit()
        {
            if (String.IsNullOrEmpty(Id)) // thêm mới nếu không có id học sinh
            {
                var res = await SchoolDataService.AddStudent(student);
                if (res == null)
                {
                    Saved = true;
                    Message = "Student has been added";
                }
                else
                {
                    Message = "Something went wrong";
                }
            }
            else //update student
            {
                await SchoolDataService.UpdateStudentDetails(student);
                Saved = true;
                Message = "Student has been updated";
                //Message = student.StudentID.ToString() + student.StudentName;
            }
        }
        //thông báo khi submit invalid
        protected async Task HandleInvalidSubmit()
        {
            await SchoolDataService.UpdateStudentDetails(student);
            Saved = true;
            Message = "Student has been updated";
            //Message = student.StudentID.ToString() + student.StudentName;
        }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        protected void goback()
        {
            navigationManager.NavigateTo("/School");
        }
        protected async Task DeleteStudent()
        {
            if (!String.IsNullOrEmpty(Id))
            {
                var studentId = Convert.ToInt32(Id);
                await SchoolDataService.DeleteStudent(studentId);

                navigationManager.NavigateTo("/School");
            }

            Message = "Delete error!!!";
        }
    }
}
