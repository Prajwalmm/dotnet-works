using webapiAndServices.Controllers;
using webapiAndServices.Models;

namespace webapiAndServices.Services
{
    public interface IOurPeopleService
    {
        List<ourPeople> GetAllHeros(bool? isActive);

        ourPeople? GetHerosByID(int id);

        ourPeople AddOurHero(AddUpdateOurPeople obj);

        ourPeople? UpdateOurHero(int id, AddUpdateOurPeople obj);

        bool DeleteHerosByID(int id);
    }
}
