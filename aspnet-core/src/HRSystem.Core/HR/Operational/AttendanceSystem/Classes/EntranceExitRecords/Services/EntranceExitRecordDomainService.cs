﻿using Abp.Domain.Repositories;
using HRSystem.HR.Operational.AttendanceSystem.Classes.AttendanceRecords;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.AttendanceSystem.Classes.EntranceExitRecords.Services
{
    public class EntranceExitRecordDomainService : IEntranceExitRecordDomainService
    {
        private readonly IRepository<EntranceExitRecord,Guid> _entranceExitRecordRepository;

        public EntranceExitRecordDomainService(IRepository<EntranceExitRecord, Guid> entranceExitRecordRepository)
        {
            _entranceExitRecordRepository = entranceExitRecordRepository;
        }

        public async Task Delete(Guid id)
        {
            await _entranceExitRecordRepository.DeleteAsync(id);
        }

        public async Task<List<EntranceExitRecord>> GetAll()
        {
            return _entranceExitRecordRepository.GetAllIncluding(x =>x.Employee).ToList();
        }

        public async Task<EntranceExitRecord> GetbyId(Guid id)
        {
            EntranceExitRecord entranceExitRecord = await _entranceExitRecordRepository.GetAsync(id);
            if (entranceExitRecord != null)
            {
                await _entranceExitRecordRepository.EnsurePropertyLoadedAsync(entranceExitRecord, x => x.Employee);
            }
            return entranceExitRecord;
        }

        public void ImportDataFromExcel(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; 

                    int startRow = worksheet.Dimension.Start.Row;
                    int endRow = worksheet.Dimension.End.Row;
                    int startColumn = worksheet.Dimension.Start.Column;
                    int endColumn = worksheet.Dimension.End.Column;

                    for (int row = startRow + 1; row <= endRow; row++) // Start from 2nd row (skipping headers)
                    {
                        List<string> rowData = new List<string>();

                        for (int col = startColumn; col <= endColumn; col++)
                        {
                            var cellValue = worksheet.Cells[row, col].Value?.ToString();
                            rowData.Add(cellValue);
                        }
                    }
                }
            }
        }

        public async Task<EntranceExitRecord> Insert(EntranceExitRecord entranceExitRecord)
        {
            return await _entranceExitRecordRepository.InsertAsync(entranceExitRecord);
        }

        public async Task<EntranceExitRecord> Update(EntranceExitRecord entranceExitRecord)
        {
            return await _entranceExitRecordRepository.UpdateAsync(entranceExitRecord);

        }
    }
}
