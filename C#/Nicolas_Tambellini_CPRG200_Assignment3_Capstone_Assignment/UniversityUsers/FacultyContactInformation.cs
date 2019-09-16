using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUsers
{
    public class FacultyContactInformation : ContactInformation
    {
        /// <summary>
        /// office location for faculty member
        /// </summary>
        public string BuildingLocation { get; set; } 

        /// <summary>
        /// Constructor for faculty contact info
        /// </summary>
        /// <param name="EmailAddress"> Faculty email address </param>
        /// <param name="BuildingLocation"> Office location </param>
        public FacultyContactInformation(string EmailAddress, string BuildingLocation) : base(EmailAddress)
        {
            this.BuildingLocation = BuildingLocation;
        }
    }
}
