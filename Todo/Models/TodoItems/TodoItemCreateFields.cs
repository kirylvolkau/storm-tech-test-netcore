﻿using System.ComponentModel.DataAnnotations;
using Todo.Data.Entities;

namespace Todo.Models.TodoItems
{
    public class TodoItemCreateFields
    {
        public int TodoListId { get; set; }
        public string Title { get; set; }
        public string TodoListTitle { get; set; }
        public string ResponsiblePartyId { get; set; }
        public Importance Importance { get; set; } = Importance.Medium;

        [Range(0, int.MaxValue)]
        public int Rank { get; set; } = 1;

        public TodoItemCreateFields() { }

        public TodoItemCreateFields(int todoListId, string todoListTitle, string responsiblePartyId)
        {
            TodoListId = todoListId;
            TodoListTitle = todoListTitle;
            ResponsiblePartyId = responsiblePartyId;
        }
    }
}
