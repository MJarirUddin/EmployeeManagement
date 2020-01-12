using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeEditViewModel : EmployeeCreateViewModel
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public int Id { get; set; }
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        public string ExistingPhotoPath { get; set; }
    }
}
