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
    public class PackageService
    {
        public static bool Add(PackageModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PackageModel, Package>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Package>(n);
            return DataAccessFactory.PackageDataAccess().Add(data);
        }

        public static bool Edit(PackageModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PackageModel, Package>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Package>(n);
            return DataAccessFactory.PackageDataAccess().Edit(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.PackageDataAccess().Delete(id);
        }

        public static PackageModel Details(int id)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<PackageModel>(DataAccessFactory.PackageDataAccess().Get(id));

            return data;
        }
        public static List<PackageModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageModel>();
                //c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<PackageModel>>(DataAccessFactory.PackageDataAccess().Get());
            return data;
        }
        public static PackageModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageModel>();
                //c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<PackageModel>(DataAccessFactory.PackageDataAccess().Get(id));
            return data;
        }
        public static List<PackageModel> GetByDate(DateTime dateTime)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageModel>();
                //c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<PackageModel>>(DataAccessFactory.PackageDataAccess().GetByDate(dateTime));
            return data;
        }
    }
}
