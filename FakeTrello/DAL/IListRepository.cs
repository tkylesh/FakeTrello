using FakeTrello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTrello.DAL
{
    //interface segregation
    interface IListRepository
    {
        //create methods
        #region create methods
        void AddList(string name, Board board);
        void AddList(string name, int boardId);
        #endregion

        //Read
        List GetList(int listId);
        List<List> GetListsFromBoard(int boardId); // List of Trello Lists

        //delete
        bool RemoveList(int listId);
    }
}
