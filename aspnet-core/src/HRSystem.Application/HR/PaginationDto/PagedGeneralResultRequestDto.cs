using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.PaginationDto
{
    public class PagedGeneralResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
