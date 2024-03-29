﻿using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Services
{
    public class DriverLicenseTypeAppService : HRSystemAppServiceBase, IDriverLicenseTypeAppService
    {
        private readonly IDriverLicenseTypeDomainService _driverLicenseTypeDomainService;

        public DriverLicenseTypeAppService(IDriverLicenseTypeDomainService driverLicenseTypeDomainService)
        {
            _driverLicenseTypeDomainService = driverLicenseTypeDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
           await _driverLicenseTypeDomainService.DeleteAsync(id);
        }

        public PagedResultDto<DriverLicenseTypeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var driverLicencesTypes = _driverLicenseTypeDomainService.GetAll();
            int total = driverLicencesTypes.Count();
            driverLicencesTypes = driverLicencesTypes.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<DriverLicenseTypeDto>>(driverLicencesTypes.ToList());
            return new PagedResultDto<DriverLicenseTypeDto>(total, list);
        }

        public async Task<DriverLicenseTypeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<DriverLicenseTypeDto>(await _driverLicenseTypeDomainService.GetbyId(id));
        }

        public async Task<DriverLicenseTypeDto> InsertAsync(DriverLicenseTypeDto driverLicenseType)
        {
            return ObjectMapper.Map<DriverLicenseTypeDto>(await _driverLicenseTypeDomainService.InsertAsync(ObjectMapper.Map<DriverLicenseType>(driverLicenseType)));
        }

        public async Task<DriverLicenseTypeDto> UpdateAsync(DriverLicenseTypeDto driverLicenseType)
        {
            return ObjectMapper.Map<DriverLicenseTypeDto>(await _driverLicenseTypeDomainService.UpdateAsync(ObjectMapper.Map<DriverLicenseType>(driverLicenseType)));
        }
    }
}
