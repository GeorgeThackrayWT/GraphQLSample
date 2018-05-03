using DataObjects.DTOS;

namespace Abstractions.Models
{
    public interface IUserPermissions
    {
        bool Check(UserActions actions);

        int UserId();
    }
}
