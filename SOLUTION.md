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
This task is about using the API, provided by the Gravatar (https://en.gravatar.com/site/implement/).
To address this in a real-life project I would search for a supported NuGet or just implement ourselves - sometimes it is easier to write a couple of lines of code and not drag any external dependencies into a project.
However, there is also a second part to this task - implementing it in the resilient way. Here, I would use `Polly` library and implement several simple retries (short enough, so the user wouldn't suffer from the long-loading page).
If we really want to show the name of the user - it could be made via ajax calls from the frontend and updating the user info once we get the result (there should be some back-off, maybe even exponential, when retrying).
In the worst case we could just not display the name.


Displaying it in near the e-mail is fairly easy - we need to pass it in the viewodel alongside `ResponsiblePartyId` and, potentially, cache the information on our side, to prevent performing a lot of request to Gravatar API.

### Task 9
Task 9 is mostly about frontend, the only thing we need to do on the backend is to extend a `TodoItemController`. Nevertheless, we would need to also add authorization possibilities and anti-forgery (as this is used on other methods in the app). And to perform ajax call to the backend, obviously - this way, we can update the UI without reloading the page.

### Task 10
Task 10 is also requires an extension to the `TodoItem` controller (some `PUT` request to update the rank). Reordering without reloading could be done by re-rendering the list from JS script.

- find element by id
- get values from inside the element tags
- store them in array, reorder, recreate the element

No calls made!

