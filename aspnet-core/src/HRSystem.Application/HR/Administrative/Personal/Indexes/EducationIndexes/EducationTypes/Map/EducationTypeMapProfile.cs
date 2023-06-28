using AutoMapper;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Dto;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Map
{
    public class EducationTypeMapProfile :Profile
    {
        public EducationTypeMapProfile()
        {
            CreateMap<EducationType,EducationTypeDto> ();
            CreateMap<EducationTypeDto,EducationType>();
        }
    }
}
