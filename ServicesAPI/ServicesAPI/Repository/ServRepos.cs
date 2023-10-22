﻿using Microsoft.EntityFrameworkCore;
using ServicesAPI.Models;
using ServicesAPI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesAPI.Repository
{
    public class ServRepos : IServRepos
    {
        private readonly CommunityGateDatabaseContext _context;

        public ServRepos()
        {

        }
        public ServRepos(CommunityGateDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<ServiceDetails> GetAllServices()
        {
            List<Services> data = _context.Services.Include(x => x.Resident).ToList();

            List<ServiceDetails> serviceDetailsList = new List<ServiceDetails>();
            foreach (var ser in data)
            {
                ServiceDetails tempservicedetails = new ServiceDetails()
                {
                    ServiceId = ser.ServiceId,
                    AppointmentTime = ser.AppointmentTime,
                    ServiceMessage = ser.ServiceMessage,
                    ServiceStatus = ser.ServiceStatus,
                    ServicePrice = ser.ServicePrice,
                    ServiceType = ser.ServiceType,
                    ResidentHouseNo=ser.Resident.ResidentHouseNo,
                    ResidentName=ser.Resident.ResidentName,
                    ResidentId=ser.ResidentId
                    
                };
                serviceDetailsList.Add(tempservicedetails);
            }
            return serviceDetailsList;
        }

        public Services GetServiceByServiceId(int id)
        {
            var item = _context.Services.Find(id);
            return item;
        }

        public IEnumerable<ServiceDetails> GetServiceByResidentId(int id)
        {
            List<Services> data= _context.Services.Include(x=>x.Employee).ToList();

            List<ServiceDetails> serviceDetailsList = new List<ServiceDetails>();
            foreach(var ser in data)
            {
                if (ser.ResidentId == id)
                {

                    ServiceDetails tempservicedetails = new ServiceDetails()
                    {
                        ResidentId=id,
                        ServiceId = ser.ServiceId,
                        AppointmentTime = ser.AppointmentTime,
                        ServiceMessage = ser.ServiceMessage,
                        ServiceStatus = ser.ServiceStatus,
                        ServicePrice = ser.ServicePrice,
                        ServiceType = ser.ServiceType,
                        EmployeeName = ser.Employee.EmployeeName,
                        EmployeeRating = ser.Employee.EmployeeRating,
                        EmployeeId = ser.EmployeeId
                    };
                    serviceDetailsList.Add(tempservicedetails);
                }
            }
            return serviceDetailsList;
            

        }

        public async Task<Services> PostServices(Services item)
        {
            Services service = null;
            if(item == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                service = new Services() { ServiceType = item.ServiceType, AppointmentTime = item.AppointmentTime, ServiceStatus = "Requested", ServiceMessage = item.ServiceMessage, ServicePrice = item.ServicePrice, EmployeeId = 1014, ResidentId = item.ResidentId };
                await _context.Services.AddAsync(service);
                await _context.SaveChangesAsync();
            }
            return service;
        }

        public async Task<Services> UpdateServiceByResident(Services item,int id)
        {
            Services service = await _context.Services.FindAsync(id);
            service.ServiceType = item.ServiceType;
            service.AppointmentTime = item.AppointmentTime;
            service.ServiceMessage = item.ServiceMessage;
            await _context.SaveChangesAsync();
            return service;
        }

        public async Task<Services> UpdateServiceByEmployee(Services item, int id)
        {
            Services service = await _context.Services.FindAsync(id);
            service.ServiceStatus = item.ServiceStatus;
            service.ServicePrice = item.ServicePrice;
            service.ServiceMessage = item.ServiceMessage;
            service.EmployeeId = item.EmployeeId;
            await _context.SaveChangesAsync();
            return service;
        }

        public async Task<Services> UpdateServiceStatusByEmployee(Services item, int id)
        {
            Services service = await _context.Services.FindAsync(id);
            service.ServiceStatus = item.ServiceStatus;
            await _context.SaveChangesAsync();
            return service;
        }

    }
}
