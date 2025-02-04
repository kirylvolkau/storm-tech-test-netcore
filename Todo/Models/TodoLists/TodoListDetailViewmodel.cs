﻿using System.Collections.Generic;
using Todo.Models.TodoItems;

namespace Todo.Models.TodoLists
{
    public class TodoListDetailViewmodel
    {
        public int TodoListId { get; }
        public string Title { get; }
        public ICollection<TodoItemSummaryViewmodel> Items { get; }
        public bool HideCompleted { get; set; }
        public TodoListSortingOption SortBy { get; set; }

        public TodoListDetailViewmodel(
            int todoListId,
            string title,
            ICollection<TodoItemSummaryViewmodel> items,
            bool hideCompleted,
            TodoListSortingOption sortBy)
        {
            Items = items;
            TodoListId = todoListId;
            Title = title;
            HideCompleted = hideCompleted;
            SortBy = sortBy;
        }
    }
}
