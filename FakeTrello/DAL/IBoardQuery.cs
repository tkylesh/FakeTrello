using FakeTrello.Models;
using System.Collections.Generic;

namespace FakeTrello.DAL
{
    //Interface segregation
    public interface IBoardQuery
    {
        List<Board> GetBoardsFromUser(string userId);
        Board GetBoard(int boardId);
    }
}