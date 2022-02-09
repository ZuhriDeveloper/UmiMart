using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.System.Commands.SeedSampleData
{
    public class SampleDataSeeder
    {
        private readonly IApplicationDbContext _context;
        private readonly IUserManager _userManager;

        private readonly Dictionary<int, Member> Employees = new Dictionary<int, Member>();

        public SampleDataSeeder(IApplicationDbContext context, IUserManager userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task SeedAllAsync(CancellationToken cancellationToken)
        {
            if (_context.Members.Any())
            {
                return;
            }

            await SeedMemberAsync(cancellationToken);
            await SeedUsersAsync(cancellationToken);

        }

        private async Task SeedMemberAsync(CancellationToken cancellationToken)
        {
            var members = new[]
            {
                new Member{ FullName = "Achmad Zuhri",MembershipNumber="0001",CardNumber="0001"},
                 new Member{ FullName = "Fakhrizal",MembershipNumber="0002",CardNumber="0002"}
            };

            _context.Members.AddRange(members);
            await _context.SaveChangesAsync(cancellationToken);
        }

        private async Task SeedUsersAsync(CancellationToken cancellationToken)
        {
            var result = await _userManager.CreateUserAsync("administrator", "administrator");

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
