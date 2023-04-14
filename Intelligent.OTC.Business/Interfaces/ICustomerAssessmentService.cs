﻿using Intelligent.OTC.Domain.DataModel;
using Intelligent.OTC.Domain.DomainModel;
using Intelligent.OTC.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelligent.OTC.Business.Interfaces
{
    public interface ICustomerAssessmentService
    {
        CustomerAssessmentModel getCustomerAssessment(VCustomerAssessmentDto vCustomerAssessmentDto);

        int getCustomerAssessmentCount();

        bool updateCustomerAssessmentCount(T_CustomerAssessment customerAssessment);

        string exportCustomerAssessment(VCustomerAssessmentDto vCustomerAssessmentDto);
    }

}
