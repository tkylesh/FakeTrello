﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FakeTrello.Models;

namespace FakeTrello.DAL
{
    public class FakeTrelloRepository : IRepository
    {

        public FakeTrelloContext Context { get; set; } // Property
        //private FakeTrelloContext context; // Data member

        public FakeTrelloRepository()
        {
            Context = new FakeTrelloContext();
        }

        public FakeTrelloRepository(FakeTrelloContext context)
        {
            Context = context;
        }

        

        public void AddBoard(string name, ApplicationUser owner)
        {
            Board board = new Board { Name = name, Owner = owner };
            Context.Boards.Add(board);
            Context.SaveChanges();
        }

        public void AddCard(string name, int listId, string ownerId)
        {
            throw new NotImplementedException();
        }

        public void AddCard(string name, List list, ApplicationUser owner)
        {
            throw new NotImplementedException();
        }

        public void AddList(string name, int boardId)
        {
            throw new NotImplementedException();
        }

        public void AddList(string name, Board board)
        {
            throw new NotImplementedException();
        }

        public bool AttachUser(string userId, int cardId)
        {
            throw new NotImplementedException();
        }

        public bool CopyCard(int cardId, int newListId, string newOwnerId)
        {
            throw new NotImplementedException();
        }

        public Board GetBoard(int boardId)
        {
            //if it does not find it returns null
            // SELECT * FROM Boards WHERE BoardId == boardId
            Board found_board = Context.Boards.FirstOrDefault(b => b.BoardId == boardId);
            return found_board;


            // * Using .First()
            // * try {
            // * Board found_board = Context.Boards.First(b => b.BoardID == boardId);
            // * return found_board;
            // * } catch (Exception e) {
            // * return null;
            // * }
            // * 
            //throws exception if nothing is found
            //Context.Boards.First();
        }

        public List<Board> GetBoardsFromUser(string userId)
        {
            throw new NotImplementedException();
        }

        public Card GetCard(int cardId)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetCardAttendees(int cardId)
        {
            throw new NotImplementedException();
        }

        public List<Card> GetCardsFromBoard(int boardId)
        {
            throw new NotImplementedException();
        }

        public List<Card> GetCardsFromList(int listId)
        {
            throw new NotImplementedException();
        }

        public List GetList(int listId)
        {
            throw new NotImplementedException();
        }

        public List<List> GetListsFromBoard(int boardId)
        {
            throw new NotImplementedException();
        }

        public bool MoveCard(int cardId, int oldListId, int newListId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBoard(int boardId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCard(int cardId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveList(int listId)
        {
            throw new NotImplementedException();
        }
    }
}