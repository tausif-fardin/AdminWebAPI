using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static bool Add(EmployeeModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeModel, Employee>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(n);
            return DataAccessFactory.EmployeeDataAccess().Add(data);
        }
        public static bool Edit(EmployeeModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeModel, Employee>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(n);
            var result = DataAccessFactory.EmployeeDataAccess().Edit(data);
            return result;
        }
        public static List<EmployeeModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<EmployeeModel>>(DataAccessFactory.EmployeeDataAccess().Get());
            return data;
        }
        public static EmployeeModel Details(int id)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<EmployeeModel>(DataAccessFactory.EmployeeDataAccess().Get(id));

            return data;
        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.EmployeeDataAccess().delete(id);
            return data;
        }

    }
}
