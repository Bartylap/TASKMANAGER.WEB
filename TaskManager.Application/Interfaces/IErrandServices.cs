using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.ViewModels.Errand;

namespace TaskManager.Application.Interfaces
{
    public interface IErrandServices
    {
        // DODAWANIE ZADANIA 
        int AddErrand(AddErrandVm erand);
        //USUWANIE ZADANIA
        void DeleteErrand(int id);
        // WYŚWIETLANIE LISTY ZADAŃ
        ErrandListVm GetAllErand(string searchString);
        // POBANIE ZADANIA DO EDYCJI
        ErrandVm GetErandToEdit(int id);
        //EDYCJA ZADANIA 
        void UpdateErrand(ErrandVm errand);
        //POBRANIE LISTY KATEGORII
        IQueryable<CategoryVm> GetErrandCategory();
        //POBRANIE LISTY STATUSÓW
        IQueryable<StatusVm> GetErrandStatus();
        // DODAWANIE KATEGORII
        void AddNewCategory(CategoryVm category);
        // POBRANIE LISTY ZADAŃ POFILTROWANYCH
        MyErrandListVm GetErandByCategory(int categoryId);
        // PRZYPISYWANIE ZADANIA DO UŻYTKOWNIAK 
        void AddErrandToUser(ErrandListForAddToUserVm model);
        

    }
}
