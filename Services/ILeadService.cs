using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public interface ILeadService
    {

        public Task<Lead?> GetLeadByIdAsync(int id);

        public Task<List<Lead>> GetAllLeadsAsync(string? Status = null , string? Source = null);

        public Task<Lead?> CreateLeadAsync(string fullName, string email, string phone, int? propertyId, string source);

        public Task<Lead?> UpdateLeadAsync(int id, string fullName, string email, string phone, int? propertyId, string source, string status);

        public Task<bool> DeleteLeadAsync(int id);

    }
}
