using AutoMapper;
using HRSystem.HR.Administrative.Personal.Classes.Certificates.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Certificates.Map
{
    public class CertificateMapProfile : Profile
    {
        public CertificateMapProfile()
        {
            CreateMap<Certificate, ReadCertificateDto>();
            CreateMap<ReadCertificateDto, Certificate>();
            CreateMap<Certificate, InsertCertificateDto>();
            CreateMap<InsertCertificateDto, Certificate>();
            CreateMap<Certificate, UpdateCertificateDto>();
            CreateMap<UpdateCertificateDto, Certificate>();
        }
    }
}
