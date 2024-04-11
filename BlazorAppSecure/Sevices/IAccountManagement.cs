using BlazorAppSecure.Model;

namespace BlazorAppSecure.Sevices
{
    public interface IAccountManagement
    {
        public Task<FormResult> RegisterAsync(string email, string password);

        public Task<FormResult> LoginAsync(string email, string password);

        public Task LogoutAsync();

        public Task<bool> CheckAuthenticatedAsync();

        public Task<FormResult> AddRole(string[] roles);

        public Task<List<Role>> GetRoles();

    }
}
