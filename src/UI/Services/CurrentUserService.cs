using UMApplication.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;

namespace UMApplication.UI.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _accessor;
        public CurrentUserService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        public string UserId { get { return _accessor?.HttpContext?.User?.Identity.Name; } }
    }
}
