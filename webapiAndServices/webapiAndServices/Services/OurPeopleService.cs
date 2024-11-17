using webapiAndServices.Models;

namespace webapiAndServices.Services
{
    public class OurPeopleService :IOurPeopleService
    {
        private readonly List<ourPeople> _ourHeroesList;
        public OurPeopleService()
        {
            _ourHeroesList = new List<ourPeople>()
            {
                new ourPeople(){
                Id = 1,
                FirstName = "Test",
                LastName = "",
                isActive = true,
                }
            };
        }

        public List<ourPeople> GetAllHeros(bool? isActive)
        {
            return isActive == null ? _ourHeroesList : _ourHeroesList.Where(hero => hero.isActive == isActive).ToList();
        }

        public ourPeople? GetHerosByID(int id)
        {
            return _ourHeroesList.FirstOrDefault(hero => hero.Id == id);
        }

        public ourPeople AddOurHero(AddUpdateOurPeople obj)
        {
            var addHero = new ourPeople()
            {
                Id = _ourHeroesList.Max(hero => hero.Id) + 1,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                isActive = obj.isActive,
            };

            _ourHeroesList.Add(addHero);

            return addHero;
        }

        public ourPeople? UpdateOurHero(int id, AddUpdateOurPeople obj)
        {
            var ourHeroIndex = _ourHeroesList.FindIndex(index => index.Id == id);
            if (ourHeroIndex > 0)
            {
                var hero = _ourHeroesList[ourHeroIndex];

                hero.FirstName = obj.FirstName;
                hero.LastName = obj.LastName;
                hero.isActive = obj.isActive;

                _ourHeroesList[ourHeroIndex] = hero;

                return hero;
            }
            else
            {
                return null;
            }
        }
        public bool DeleteHerosByID(int id)
        {
            var ourHeroIndex = _ourHeroesList.FindIndex(index => index.Id == id);
            if (ourHeroIndex >= 0)
            {
                _ourHeroesList.RemoveAt(ourHeroIndex);
            }
            return ourHeroIndex >= 0;
        }

    }
}
