# Solution

## Task 1
Successful run (after running the migration, of course).

## Task 2
As written in the task, I've updated `Details.cshtml` file. However, from my point of view, this is not just a question of presentation, so in the real-life project I would insist on changes either into the `Model` or `Controller` part of MVC pattern.

## Task 3
Easy fix - glad we caught it early 😅

## Task 4
Easy fix 💪

## Task 5
Solution for this one is not as clean as it could be. 
Originally, I'm a backend developer - although I don't mind extending my set of capabilities. So, I required to do some research to complete the task (how to call C# function from JS in ASP.NET and how to re-render in a new location).
Nevertheless, this task solution could be improved - at least without setting the location as a string, since this could be hard to maintain in the future.

## Task 6
Nice extension to make! I would also propose limiting users to edit only lists they have ownership of - now they are able to also edit lists they are not owners of.

## Task 7
For me this task was also mostly about the frontend - unfortunately, I had some time figuring out how to select elements and pass them on in the location string.

## Tasks 8 - 10
Unfortunately, I didn't manage to complete tasks 8-10 since I am in a trip currently and designating time to job-search-related tasks could be difficult. So, in order not to prolong the wait I've decided to at least describe how I would approach the tasks.

### Task 8
The approach I chose for this task was as follows:

1. Don't use any NuGet packages for the gravatar API - just generate models from a sample json response (comment left in the code)
2. Try loading gravatar name for every single user when it is possible (and it is not set in the cache already - timespan is chosen to be one day since there are a lot of services which tell you that "after you update your data it will be actualised in one day")
3. Set in cache once loaded (15 seconds timeout is set in the HTTP client so we don't wait to long - could be less. However, no retries - retries on our side would require creating a whole new API endpoint and sending AJAX calls from the frontend)
4. For displaying name in lists (edit and create to do item) - the solution was, due to the limit of time, load names for users who already have the name stored in the cache. Obviously, it is not an ideal solution - however, refactoring the usage of `dbContext` would require more time (separation of concerns seems to be a little bit broken in the project)

Displaying the names only for users, who have already logged in after the change was introduced is, obviously, a limitation - however, due to the lack of time on the project and demanding stakeholders (joking) it was decided to made a nice facade and then fix the problem after the release :)

### Task 9
Task 9 is mostly about frontend, the only thing we need to do on the backend is to extend a `TodoItemController`. Nevertheless, we would need to also add authorization possibilities and anti-forgery (as this is used on other methods in the app). And to perform ajax call to the backend, obviously - this way, we can update the UI without reloading the page.

### Task 10
Task 10 is also requires an extension to the `TodoItem` controller (some `PUT` request to update the rank). Reordering without reloading could be done by re-rendering the list from JS script.

- find element by id
- get values from inside the element tags
- store them in array, reorder, recreate the element

No calls made!

