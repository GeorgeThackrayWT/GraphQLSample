using DataObjects.DTOS;

namespace Abstractions.Models
{
    public interface IUserLookup
    {
        UserInfoDto GetUserName();

        string GetLoginName();
    }
}
