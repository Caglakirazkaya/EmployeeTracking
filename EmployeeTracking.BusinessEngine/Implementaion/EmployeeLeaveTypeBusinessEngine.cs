using AutoMapper;
using EmployeeTarcking.Data.Contracts;
using EmployeeTarcking.Data.DbModels;
using EmployeeTracking.BusinessEngine.Contracts;
using EmployeeTracking.Common.ContractsModels;
using EmployeeTracking.Common.ResultModels;
using EmployeeTracking.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeTracking.BusinessEngine.Implementaion
{
    public class EmployeeLeaveTypeBusinessEngine: IEmployeeLeaveTypeBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            
        }

        public Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    _unitOfWork.employeeLeaveType.Add(leaveType);
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, ResultContant.RecordCreateSuccessfully);
                }
                catch(Exception ex)
                {
                    return new Result<EmployeeLeaveTypeVM>(false, ResultContant.RecordCreateNotSuccessfully + "=>" + ex.Message.ToString());
                }
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, "Parametre Olarak Geçilen Data Boş Olmaz");
            }
        }

        public Result<EmployeeLeaveTypeVM> GetAllEmployeeLeaveType(int id)
        {
            var data = _unitOfWork.employeeLeaveType.Get(id);
            if (data != null)
            {
                var leaveType = _mapper.Map<EmployeeLeaveType, EmployeeLeaveTypeVM>(data);
                return new Result<EmployeeLeaveTypeVM>(true, ResultContant.RecordFound, leaveType);
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, ResultContant.RecordNotFound);
            }
        }

        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes()
        {
            var data = _unitOfWork.employeeLeaveType.GetAll().ToList();            
            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(true, ResultContant.RecordFound, leaveTypes);

        }

        public Result<EmployeeLeaveTypeVM> UpdateEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    _unitOfWork.employeeLeaveType.Update(leaveType);
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, ResultContant.RecordUpdateSuccessfully);
                }
                catch (Exception ex)
                {
                    return new Result<EmployeeLeaveTypeVM>(false, ResultContant.RecordUpdateNotSuccessfully + "=>" + ex.Message.ToString());
                }
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, "Parametre Olarak Geçilen Data Boş Olmaz");
            }
        }
    }
}
